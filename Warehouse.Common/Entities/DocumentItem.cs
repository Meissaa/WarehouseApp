using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Common.Entities
{
    public class DocumentItem
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ClientNumber { get; set; }
        public string Title { get; set; }
        public virtual User User { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}
