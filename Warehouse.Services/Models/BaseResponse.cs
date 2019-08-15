using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Warehouse.Services.Models
{
    public class BaseResponse
    {
        public string Message { get; set; }
        public HttpStatusCode Code { get; set; }
    }
}