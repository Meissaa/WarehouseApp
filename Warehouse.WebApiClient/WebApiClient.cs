using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Warehouse.Common.Entities;
using Warehouse.Common.Managers;

namespace Warehouse.WebApiClient
{
    public class WebApiClient : IWebApiClientManager
    {
        private string _baseUrl = "http://localhost:50243/api";
        private string _receiveUrl;

        public WebApiClient()
        {
        }

        public dynamic Login(string username, string password)
        {
            _receiveUrl = "auth/login";
            string json = new JavaScriptSerializer().Serialize(new
            {
                Username = username,
                Password = password
            });
            var response = ServiceRest(_receiveUrl, "POST", json);
            return response;
        }

        #region Document
        public dynamic GetDocuments()
        {
            _receiveUrl = "document";
            return ServiceRest(_receiveUrl, "GET", "");
        }

        public dynamic GetDocumentDetails(int id)
        {
            _receiveUrl = "document/" + id;
            return ServiceRest(_receiveUrl, "GET", "");
        }

        public dynamic CreateDocument(DocumentItem item)
        {
            _receiveUrl = "document";
            var json = JsonConvert.SerializeObject(item);
            return ServiceRest(_receiveUrl, "POST", json);
        }

        public dynamic UpdateDocument(DocumentItem item)
        {
            _receiveUrl = "document";
            var json = JsonConvert.SerializeObject(item);
            return ServiceRest(_receiveUrl, "PUT", json);
        }

        public dynamic RemoveDocument(int id)
        {
            _receiveUrl = "document/" + id;
            return ServiceRest(_receiveUrl, "DELETE", "");
        }
        #endregion

        #region Product
        public dynamic AddProduct(int docId, Product item)
        {
            _receiveUrl = "document/" + docId + "/product";
            var json = JsonConvert.SerializeObject(item);
            return ServiceRest(_receiveUrl, "POST", json);
        }

        public dynamic UpdateProduct(int docId, Product item)
        {
            _receiveUrl = "document/" + docId + "/product/";
            var json = JsonConvert.SerializeObject(item);
            return ServiceRest(_receiveUrl, "PUT", json);
        }

        public dynamic RemoveProduct(int docId, int prodId)
        {
            _receiveUrl = "document/" + docId + "/product/" + prodId;
            return ServiceRest(_receiveUrl, "DELETE", "");
        }

        #endregion

        public dynamic ServiceRest(string receiveUrl, string methodHttp, string json)
        {
            var result = "";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(_baseUrl + "/" + receiveUrl);
            httpWebRequest.Method = methodHttp;
            httpWebRequest.ContentType = "application/json";
            //httpWebRequest.Headers.Add("Authorization", "Custom " + Token);
            if (methodHttp != "GET" && methodHttp != "DELETE")
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(json);
                }
            }
            using (var response = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
                return result;
            }
        }

    }
}
