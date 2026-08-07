var students = new[]
{
    new {Id = 1, Name = "Jadir", Department = "CSE"},

    new {Id = 2, Name = "Sifat", Department = "EEE"},

    new {Id = 3, Name = "Alif", Department = "BBA"}
};

foreach (var student in students)
{
    Console.WriteLine("ID: " + student.Id);
    Console.WriteLine("Name: " + student.Name);
    Console.WriteLine("Department: " + student.Department);
    Console.WriteLine();
}