using Static_Example_in_C_Sharp;

Student student1 = new Student();
student1.Name = "Jadir";

Student student2 = new Student();
student2.Name = "Rahim";

student1.ShowStudentInfo();

Console.WriteLine();

student2.ShowStudentInfo();

Console.WriteLine();

// Accessing static variable using class name
Console.WriteLine("Common University: " + Student.UniversityName);

Console.WriteLine();

// Calling static method using class name
Student.ShowUniversity();

Console.ReadLine();