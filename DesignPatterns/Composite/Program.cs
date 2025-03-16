using Composite.Component;
using Composite.Composite;
using Composite.Leaf;

IEmployee e1 = new Employee("Prakash Mehta", "R&D");
IEmployee e2 = new Employee("Ramesh Gupta", "HR");
IEmployee e3 = new Employee("Raj Sinha", "IT");
IEmployee e4 = new Employee("Piyush Shah", "Admin");

IEmployee cto = new Manager("Parag Patel", "CTO")
{
    subOrdinates = new List<IEmployee>()
    {
        e1,e3
    }
};

IEmployee coo = new Manager("Rekha Shah", "COO")
{
    subOrdinates = new List<IEmployee>() { e2, e4 }
};

IEmployee ceo = new Manager("Raj Patel", "CEO")
{
    subOrdinates = new List<IEmployee>() { cto, coo }
};

ceo.GetDetails(0);