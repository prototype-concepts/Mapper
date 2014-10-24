using Mapper.Domain;
using Mapper.Map;
using Mapper.Mapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mapper
{
    [TestClass]
    public class MapHelperTest
    {
        [TestMethod]
        public void AddressMapperTest()
        {
            var mapper = new MapHelper();
            var addressModel = new AddressModel
            {
                City = "Austin",
                State = "Texas",
                Line1 = "1234 Street",
                PostalCode = "78777"
            };

            var address = mapper
                 .For(new Address())
                 .MapUsing(addressModel, new AddressModelToAddressMap())
                 .Result();

            Assert.AreEqual(address.City, addressModel.City);
            Assert.AreEqual(address.State, addressModel.State);
            Assert.AreEqual(address.Line1, addressModel.Line1);
            Assert.AreEqual(address.PostalCode, addressModel.PostalCode);
            Assert.AreEqual(address.Country, "USA");
        }
    }
}
