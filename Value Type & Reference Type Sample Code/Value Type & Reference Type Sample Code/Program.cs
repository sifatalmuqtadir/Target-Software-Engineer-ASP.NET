using Value_Type___Reference_Type_Sample_Code;

Person p1 = new Person();
p1.firstName = "Junayed";
p1.lastName = "Islam";
string fullName1 = p1.GetFullName();
Console.WriteLine(fullName1);

Person p2 = new Person();
p2.firstName = "Ziad";
p2.lastName = "Islam";
string fullName2 = p2.GetFullName();
Console.WriteLine(fullName2);

Person p3 = new Person();
p3 = p1;
string fullName3 = p3.GetFullName();
Console.WriteLine(fullName3);

Person p4 = new Person();
p4 = p1;
p4.firstName = "Juhayer";
string fullName4 = p4.GetFullName();
Console.WriteLine(fullName4);
Console.WriteLine(fullName1);



Console.ReadKey();