using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Common.Entities;

namespace Warehouse.Common.Managers
{
    public interface IWebApiClientManager
    {
        dynamic Login(string username, string password);
        dynamic CreateDocument(DocumentItem item);
        dynamic UpdateDocument(DocumentItem item);
        dynamic RemoveDocument(int docId);
        dynamic GetDocuments();
        dynamic GetDocumentDetails(int docId);
        dynamic AddProduct(int docId, Product product);
        dynamic UpdateProduct(int docId, Product item);
        dynamic RemoveProduct(int docId, int prodId);
        dynamic ServiceRest(string receiveUrl, string methodHttp, string json);
    }
}
