using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public Address Address { get; set; }

        public Person(Guid id,string name,int age,string gender,string state,string country,string zip)
        {
            this.Id = id;
            Name = name;
            Age = age;
            Gender = gender;
            this.Address = new Address(state, country, zip);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
        public Person DeepClone()
        {
            return new Person(this.Id, this.Name, this.Age,this.Gender, this.Address.State, this.Address.Country, this.Address.ZipCode);
        }
    }
}
