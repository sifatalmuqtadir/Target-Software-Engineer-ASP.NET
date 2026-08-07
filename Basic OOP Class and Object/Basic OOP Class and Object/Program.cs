using Basic_OOP_Class_and_Object;

Person p1 = new Person();

p1.firstName = "Junayed";
p1.lastName = "Islam";

string fullName = p1.GetFullName();

Console.WriteLine(fullName);
Console.ReadKey();
