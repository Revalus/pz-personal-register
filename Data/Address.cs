using System.Xml;
using System.Xml.Serialization;

namespace PersonalRegister.Data
{
    public class Address
    {
        public string ZIPCode{get; set;}
        public string City{get; set;}
        public string Street{get; set;}
        public int HouseNumber{get; set;}

        [XmlElementAttribute(IsNullable = false)]
        public int ApartamentNumber{get; set;}

        public override string ToString()
        {
            string tmpHouseNumber = "";
            if(ApartamentNumber > 0)
                tmpHouseNumber = $"{this.HouseNumber}/{this.ApartamentNumber}";
            else
                tmpHouseNumber = HouseNumber.ToString();

            return $"{this.ZIPCode} {this.City} {this.Street} {tmpHouseNumber}";
        }
    }
}