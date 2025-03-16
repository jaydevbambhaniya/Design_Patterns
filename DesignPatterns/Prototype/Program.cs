using Prototype;

Console.WriteLine("------------Shallow Copy------------");
Copy(false); // Shallow copy

Console.WriteLine("------------Deep Copy------------");

Copy(true); // Deep Copy

static void Copy(bool isDeepCopy)
{
    Person p1 = new Person(Guid.NewGuid(), "Rohit Sharma", 37, "Male", "Gujarat", "India", "356980");
    Person p2 = isDeepCopy ? (Person)p1.DeepClone() : (Person)p1.Clone();

    Console.WriteLine("P1 -> Id: {0}, Name: {1}, Age: {2}, State: {3}, ZipCode: {4}, Country: {5}"
        , p1.Id, p1.Name, p1.Age, p1.Address.State, p1.Address.ZipCode, p1.Address.Country);

    p2.Name = "Virat Kohli";
    p2.Id = Guid.NewGuid();
    p2.Age = 36;
    p2.Address.State = "Delhi";
    p2.Address.ZipCode = "875695";

    Console.WriteLine("P1 -> Id: {0}, Name: {1}, Age: {2}, State: {3}, ZipCode: {4}, Country: {5}"
        , p1.Id, p1.Name, p1.Age, p1.Address.State, p1.Address.ZipCode, p1.Address.Country);

    Console.WriteLine("P2 -> Id: {0}, Name: {1}, Age: {2}, State: {3}, ZipCode: {4}, Country: {5}"
        , p2.Id, p2.Name, p2.Age, p2.Address.State, p2.Address.ZipCode, p2.Address.Country);
}