using Explicit_interface_implementation_in_C_Sharp;

Person person = new Person();

IStudent student = person;
student.ShowInformation();

ITeacher teacher = person;
teacher.ShowInformation();

Console.ReadLine();