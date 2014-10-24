using System;
using Mapper.Domain;
using Mapper.Mapper;

namespace Mapper.Map
{
    public class AddressModelToAddressMap : IMapHelperMap<AddressModel, Address>
    { 
        public Address Map(AddressModel src, Address dest)
        {
            if (src == null) return null;

            dest.Line1 = src.Line1;
            dest.Line2 = src.Line2;
            dest.City = src.City;
            dest.State = src.State;
            dest.PostalCode = src.PostalCode;
            dest.Country = String.IsNullOrEmpty(src.Country) ? "USA" : src.Country;
            // TODO: mapper for org or accept as constructor param
           // dest.Organization = _defaultOrganization; 
            return dest;
        }
    }
}
