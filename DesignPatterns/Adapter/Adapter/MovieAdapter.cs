using Adapter.Adaptee;
using Adapter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Adapter.Adapter
{
    public class MovieAdapter : MovieManager
    {
        private readonly JsonSerializerOptions options = new()
        {
            WriteIndented = true
        };
        public override string GetMovies()
        {
            string movieXml = base.GetMovies();

            using StringReader stringReader = new(movieXml);

            XmlSerializer xmlSerializer = new(typeof(List<Movie>));
            List<Movie> movies = (List<Movie>)xmlSerializer.Deserialize(stringReader)!;

            string movieJson = JsonSerializer.Serialize(movies, options);
            return movieJson;
        }
    }
}
