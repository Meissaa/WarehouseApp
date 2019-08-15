using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Common.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Amount { get; set; }
        public decimal NetPrice { get; set; }
        public decimal GrossPrice { get; set; }
        public virtual DocumentItem DocumentItem { get; set; }
    }
}
