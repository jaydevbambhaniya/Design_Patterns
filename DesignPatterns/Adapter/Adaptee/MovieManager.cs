using Adapter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Adapter.Adaptee
{
    public class MovieManager
    {
        private readonly List<Movie> _movies;
        public MovieManager()
        {
            _movies = new List<Movie>()
            {
                new Movie(1,"Animal",8.5M),
                new Movie(2,"KGF",9.7M),
                new Movie(3,"The Dark Nights",7M)
            };
        }

        public virtual string GetMovies()
        {
            using StringWriter stringWriter = new();
            XmlSerializer xmlSerializer = new(_movies.GetType());
            xmlSerializer.Serialize(stringWriter, _movies);
            return stringWriter.ToString();
        }
    }
}
