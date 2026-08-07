using Object_Collection_Initializer_in_C_Sharp;

// Object Initializer
Student student1 = new Student()
{
    Id = 1,
    Name = "Jadir",
    Age = 24,
    Address = "Mymensingh"
};

Student student2 = new Student()
{
    Id = 2,
    Name = "Alifa",
    Age = 25,
    Address = "Comilla"
};

Student student3 = new Student()
{
    Id = 3,
    Name = "Alif",
    Age = 23,
    Address = "Dhaka"
};


// Collection Initializer
List<Student> studentList = new List<Student>()
{
    student1,
    student2,
    student3
};


// Showing all student information
foreach (Student student in studentList)
{
    Console.WriteLine("ID: " + student.Id);
    Console.WriteLine("Name: " + student.Name);
    Console.WriteLine("Age: " + student.Age);
    Console.WriteLine("Address: " + student.Address);

    Console.WriteLine();
}

Console.ReadLine();