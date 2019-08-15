using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Common.Entities;
using Warehouse.Common.Managers;
using log4net;
using Warehouse.Data;
using Warehouse.Common.Exceptions;

namespace Warehouse.Business.Managers
{
    public class WarehouseManager : IWarehouseManager
    {
        private static ILog _log;
        private WarehouseDbContext _db = new WarehouseDbContext();
        private ISecurityManager _securityManager;

        public WarehouseManager(ISecurityManager securityManager) {
            _log = LogManager.GetLogger(this.GetType().FullName);
            _securityManager = securityManager;
        }

        public void AddProduct(int docId, Product product)
        {
            if (product == null)
            {
                _log.Error("Product object is null");
                throw new ArgumentNullException("Product not created");
            }

            var document = _db.DocumentItems.FirstOrDefault(l => l.Id == docId);

            if (document == null) {
                _log.ErrorFormat("Document with id {0} not found", docId);
                throw new WarehouseException(String.Format("Document with id {0} not found", docId));
            }

            product.DocumentItem = document;
            document.Products.Add(product);
            _db.SaveChanges();
        }

        public void CreateDocument(DocumentItem item)
        {
            if (item == null)
            {
                _log.Error("Document not created");
                throw new ArgumentNullException("Document not created");
            }
           
            var userId = _securityManager.GetLoggedUser().Id;
            item.User = _db.Users.First(u => u.Id == userId);

            _db.DocumentItems.Add(item);
            _db.SaveChanges();
        }

        public void Dispose()
        {
            if (_db != null)
            {
                _log.Debug("Release resources");
                _db.Dispose();
            }
        }

        public IList<DocumentItem> GetDocuments()
        {
            var loggedUser = _securityManager.GetLoggedUser();

            var listDocuments = from u in _db.DocumentItems
                                 where u.User.Id == loggedUser.Id
                                 select u;

            return listDocuments.ToList();
        }

        public DocumentItem GetDocumentDetails(int docId)
        {
            var loggedUser = _securityManager.GetLoggedUser();

            var item = _db.DocumentItems.FirstOrDefault(u => u.Id == docId && u.User.Id == loggedUser.Id);
   
            if (item == null)
            {
                _log.ErrorFormat("Document not found");
                throw new WarehouseException("Document not found");
            }

            return item;
        }

        public void RemoveDocument(int docId)
        {
            var loggedUser = _securityManager.GetLoggedUser();

            var document = _db.DocumentItems.FirstOrDefault(u => u.Id == docId && u.User.Id == loggedUser.Id);

            if (document != null)
            {
                _db.Entry<DocumentItem>(document).State = System.Data.Entity.EntityState.Deleted;
                _db.SaveChanges();
            }
            else
            {
                _log.ErrorFormat("Document with not found");
                throw new WarehouseException("Document with not found");
            }
        }

        public void RemoveProduct(int docId, int prodId)
        {
            var product = _db.Products.FirstOrDefault(u => u.Id == prodId && u.DocumentItem.Id == docId);

            if (product != null)
            {
                _db.Entry<Product>(product).State = System.Data.Entity.EntityState.Deleted;
                _db.SaveChanges();
            }
            else
            {
                _log.ErrorFormat("Product with not found");
                throw new WarehouseException("Product with not found");
            }
        }

        public void UpdateDocument(DocumentItem item)
        {
            var document = _db.DocumentItems.Find(item.Id);

            if (document == null)
            {
                _log.ErrorFormat("Document with not found");
                throw new WarehouseException("Document with not found");
            }
            _db.Entry(document).CurrentValues.SetValues(item);
            _db.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            var item = _db.Products.Find(product.Id);

            if (item != null)
            {
                _db.Entry(item).CurrentValues.SetValues(product);
                _db.SaveChanges();
            }
            else
            {
                _log.ErrorFormat("Product with not found");
                throw new WarehouseException("Product with not found");
            }
        }
    }
}
