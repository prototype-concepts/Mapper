
namespace Mapper.Domain
{
   
    public class Address
    {
        public string Line1 { get; set; }
        public object Line2 { get; set; }
        public object City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public Organization Organization { get; set; }
        public string Country { get; set; }
    }
}
