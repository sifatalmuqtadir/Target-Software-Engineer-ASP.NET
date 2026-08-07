using Extensible_dynamic_type_in_C_Sharp;

Student student = new Student();

student.Id = 1;
student.Name = "Jadir";

// Adding dynamic properties at runtime
student.ExtraInformation.Age = 22;
student.ExtraInformation.Address = "Dhaka";
student.ExtraInformation.Department = "CSE";

student.ShowBasicInformation();

Console.WriteLine("Age: " + student.ExtraInformation.Age);
Console.WriteLine("Address: " + student.ExtraInformation.Address);
Console.WriteLine("Department: " + student.ExtraInformation.Department);

Console.ReadLine();