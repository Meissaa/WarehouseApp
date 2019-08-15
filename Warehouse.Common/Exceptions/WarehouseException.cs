using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Common.Exceptions
{

    [Serializable]
    public class WarehouseException : Exception
    {
        public WarehouseException() { }
        public WarehouseException(string message) : base(message) { }
        public WarehouseException(string message, Exception inner) : base(message, inner) { }
        protected WarehouseException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
