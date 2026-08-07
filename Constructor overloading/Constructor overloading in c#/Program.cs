using Constructor_overloading_in_c_;

Person p = new Person("Junayed", "Islam", "Jadir");
string fullName = p.GetFullName();
Console.WriteLine(fullName);

Person p2 = new Person("Ziad", "Islam");
string fullName1 = p2.GetFullName();
Console.WriteLine(fullName1);

Person p3 = new Person();