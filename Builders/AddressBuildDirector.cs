using PersonalRegister.Data;
namespace PersonalRegister.Builders
{
    public class AddressBuildDirector
    {
        private AddressBuilder addressBuilder;
        public AddressBuildDirector()
        {
            addressBuilder = new AddressBuilder();
        }

        public Address createAddress() 
        {
            addressBuilder.SetCity();
            addressBuilder.SetStreet();
            addressBuilder.SetPostcode();
            addressBuilder.SetHouseNumber();
            addressBuilder.SetApartamentNumber();
            return addressBuilder.GetAddress();
        }
    }
}