using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Warehouse.Services.Models.Document
{
    public class DocumentRequest
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ClientNumber { get; set; }
        public string Title { get; set; }
    }
}