using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Common.Entities
{
    public class BaseResponse
    {
        public string Message { get; set; }
        public object Data { get; set; }
        public HttpStatusCode Code { get; set; }
    }
}
