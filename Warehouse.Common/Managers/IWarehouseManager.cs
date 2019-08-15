using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Common.Entities;

namespace Warehouse.Common.Managers
{
    public interface IWarehouseManager : IDisposable
    {
        void CreateDocument(DocumentItem item);
        void UpdateDocument(DocumentItem item);
        void RemoveDocument(int docId);
        IList<DocumentItem> GetDocuments();
        DocumentItem GetDocumentDetails(int docId);
        void AddProduct(int docId, Product product);
        void UpdateProduct(Product product);
        void RemoveProduct(int docId, int prodId);
        //dodać sumowanie wartości netto i wartości brutto
    }
}
