using Adapter.Adaptee;
using Adapter.Adapter;

// Movie manager by default gives data in XML
MovieManager manager = new();
Console.WriteLine(manager.GetMovies());

// But my system wants data in JSON
MovieAdapter adapter = new();
string moviesJson = adapter.GetMovies();
Console.WriteLine(moviesJson);