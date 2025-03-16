using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Adapter.Model
{
    [Serializable]
    public class Movie 
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public int Id { get; set; }

        [XmlAttribute]
        public decimal Rating { get; set; }

        public Movie() { }
        public Movie(int id,string name,decimal rating)
        {
            Name = name;
            Id = id;
            Rating = rating;
        }
    }
}
