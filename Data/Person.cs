using System;

namespace PersonalRegister.Data
{
    public class Person
    {
        public string Name {get; set;}
        public string Lastname {get; set;}
        public bool Sex {get; set;}
        public DateTime Birthday {get; set;}
        public Address Address {get; set;}
    
        public override string ToString() {
            string tmpSex = "";
            
            if(this.Sex) 
                tmpSex = "Kobieta";
            else
                tmpSex = "Mężczyzna";

            return $"{this.Name} {this.Lastname} {tmpSex} {this.Birthday.ToShortDateString()} {this.Address.ToString()}";
        }
    }

}