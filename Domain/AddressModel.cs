using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper.Domain
{
    public class AddressModel
    {
        public string Line1 { get; set; }
        public object Line2 { get; set; }
        public object City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}
