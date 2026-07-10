using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            string message = "Hello World";
            message = "Hello world 146" + Environment.NewLine + "At bottom" + "\nAt top";


            Console.WriteLine(message);
            Console.WriteLine("hello world");
            int number = 10;
            int result = number + 10;
            Console.WriteLine("Result : " + (number+20));
            Console.ReadLine(); 
            */

            //string message=  Console.ReadLine();
            /*
            Console.WriteLine("Enter any 1st numbers to add: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter any 2nd numbers to add: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int result = number1 + number2;*/
            /*Console.Write("Enter any 1st numbers to add: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter any 2nd numbers to add: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int result = number1 + number2;
            //Console.WriteLine("Your message: " +(number1+number2));
            Console.WriteLine("Sum: " + result);
            Console.ReadKey();
            */

            /*
            Console.Write("Enter your English score: ");
            string englishScoreWithString = Console.ReadLine();
            int englishScore = Convert.ToInt32(englishScoreWithString);
            string result = string.Empty;

            if (englishScore >= 100 || englishScore <=0)
            { 
                result = "You have scored shouuld be 0 to 100"; 
            }
            else if (englishScore >= 50)
            {
                result = "congratulations, you have passed";
            }
            else
            {
                result = "Sorry. you have Failed";
            }
            Console.WriteLine(result);
            Console.ReadKey();
            */

            /*
            for (int i = 1; i <= 10; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
            */

            /*
            int i = 0;
            while (i < 20)
            {
                i++;
                if (i%5==0)
                {
                    continue;
                }
                Console.WriteLine(i); 
            }
            do
            {
                if (true)
                {
                    Console.WriteLine("Hello World");
                }
            } 
            while (false);
            Console.ReadKey();
            */

            /*
            int a = 15;
            long l = 5000;
            //a = l;
            //l = a;
            a = Convert.ToInt32(l);
            bool b = true;
            a = Convert.ToInt32(b);
            char c = 'f';
            a = c;
            Console.WriteLine(a);
            Console.ReadKey();
            decimal d = Convert.ToDecimal(a);
            */
            //int result = Add1(10, 20);
            //Console.WriteLine("Sum: " + result);


            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new int[5]; //{ 10, 20, 30, 40, 50 };
            //numbers[0] = 100;
            //numbers[1] = 200;
            //numbers[2] = 300;
            //numbers[3] = 400;
            //numbers[4] = 500;
            //for (int i = 0; i < numbers.Count(); i++)
            //{
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < numbers.Count(); i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //foreach (var data in numbers)
            //{
            //    Console.WriteLine("output: "+data);
            //}
            //int sum = numbers.Sum();
            //Array.Sort(numbers);
            //Console.WriteLine("Sum: " + sum);
            //Console.ReadKey(); 

            //ArrayList array = new ArrayList();
            //array.Add(10);
            //array.Add("Sifat");
            //array.Add(20.5);
            //array.Add(true);
            //array.Add(false);
            //array.Add('A');

            //array.Remove(20.5);
            //array.RemoveAt(0); // remove by index
            //array.RemoveRange(0, 2); // remove by index and count
            //array.Reverse(); 
            //foreach (var value in array)
            //{
            //    Console.WriteLine(value);
            //}
            //Console.ReadKey();
            //List<string> names = new List<string>();
            //names.Add("Sifat");
            //names.Add("Rifat");
            //names.Add("Rana");
            //names.Remove("Alif");
            //foreach (var name in names)
            //{
            //    if (name == "Rifat")
            //    {
            //        Console.WriteLine("Found: " + name);
            //        break;
            //    }
            //    Console.WriteLine(name);
            //}
            //Console.ReadKey();

            //Stack aStack = new Stack();
            //aStack.Push(10);
            //aStack.Push("Hello");
            //aStack.Push(20.5);

            //foreach(var data in aStack)
            //{
            //    Console.WriteLine(data);
            //}
            //aStack.Pop();

            //foreach (var data in aStack)
            //{
            //    Console.WriteLine(data);
            //}
            //Stack<int> stack = new Stack<int>();

            //Queue<int> anQueue = new Queue<int>();
            //anQueue.Enqueue(10);
            //anQueue.Enqueue(20);
            //anQueue.Enqueue(30);
            //anQueue.Dequeue();

            //foreach(var data in anQueue)
            //{
            //    Console.WriteLine(data);
            //}
            //anQueue.Dequeue();
            //Console.ReadKey();

            //Dictionary<int, string> aDictionary = new Dictionary<int, string>();
            //aDictionary.Add(1, "Sifat");
            //aDictionary.Add(2, "Rifat");

            //string outPut;

            //if (aDictionary.TryGetValue(8, out outPut))
            //{
            //    Console.WriteLine("Find Data: " + outPut);
            //}
            //else
            //{
            //    Console.WriteLine("Data not found");
            //}

            //foreach (var data in aDictionary)
            //{
            //    Console.WriteLine(data.Key + " : " + data.Value);
            //}

            Hashtable aHashtable = new Hashtable();
            aHashtable.Add(1, "Sifat");
            aHashtable.Add(2, "Rifat");

            foreach (var data in aHashtable.Keys)
            {
                Console.WriteLine(data + " : " + aHashtable[data]);
            }
            if (aHashtable.Count > 0)
            {
                Console.WriteLine("Total Count: " + aHashtable.Count);
            }
            Console.ReadKey();
        }
        /*static int Add1(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }*/
    }
}
