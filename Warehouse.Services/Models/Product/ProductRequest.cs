using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Warehouse.Services.Models.Product
{
    public class ProductRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Amount { get; set; }
        public decimal NetPrice { get; set; }
        public decimal GrossPrice { get; set; }
    }
}