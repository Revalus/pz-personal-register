using PersonalRegister.Data;
using PersonalRegister.UserInterface;

namespace PersonalRegister.Builders
{
    public class AddressBuilder
    {
        private Address address;

        public AddressBuilder(Address address = null) {
            if(address == null)
                this.address = new Address();
            else
                this.address = address;

        }

        public void SetCity() {
            address.City = ValueGetter.GetString("Proszę podać miasto");
        }
        public void SetStreet() {
            address.Street = ValueGetter.GetString("Proszę podać Ulicę");
        }
        public void SetPostcode() {
            address.ZIPCode = ValueGetter.GetString("Proszę podać kod pocztowy");
        }
        public void SetHouseNumber() {
            address.HouseNumber = ValueGetter.GetInt("Proszę podać numer domu");
        }

        public void SetApartamentNumber() {
            address.ApartamentNumber = ValueGetter.GetInt("Proszę podać numer mieszkania (jeśli brak proszę wcisnąć enter)", allowEmpty: true);
        }

        public Address GetAddress() => address;

    }
}