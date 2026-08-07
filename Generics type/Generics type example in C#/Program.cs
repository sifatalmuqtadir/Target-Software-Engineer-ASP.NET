using Generics_type_example_in_C_;

Box<int> box = new Box<int>();

box.Data = 100;

box.ShowData();

box.Show<string>("Hello C#");

box.Show<double>(3.75);

Console.ReadLine();