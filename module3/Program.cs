using System.Xml.Linq;

namespace module3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string MyName = "Jane";
            //byte MyAge = 27;
            //bool HaveIApet = true;
            //double MyShoeSize = 37.5;

            //Console.WriteLine("My name is " + MyName);
            //Console.WriteLine("MyAge " + MyAge);
            //Console.WriteLine("Do I have a pet? " + HaveIApet);
            //Console.WriteLine("My shoe size is " + MyShoeSize);
            //DaysOfWeek MyFavoriteDay;

            //MyFavoriteDay = DaysOfWeek.Friday;

            //Console.WriteLine(MyFavoriteDay);
            //Console.ReadKey();

            TaskN();

        }

        enum DaysOfWeek : byte
        {
            Tuesday,
            Monday,
            Wednesday,
            Friday
        }

        enum Semaphore : int
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }

        static void HelloW()
        {
            Console.WriteLine("\tПривет,\n мир!");
        }

        static void MyAge()
        {
            byte age = 32;
            Console.WriteLine($"Мой возраст {age}");
        }

        static void Task352()
        {
            string name = "Jane";
            byte age = 27;
            string favcolor = "black";
            Console.WriteLine("{0}\n  {1}\n {2}", name, age, favcolor);
        }

        static void Task355()
        {
            string str = Console.ReadLine();
            Console.WriteLine(str);
        }

        static void Del() {
            double result = 5.0 / 2.0;
            Console.WriteLine("5 / 2 = {0}", result);
        }

        static void Task363()
        {
            double result = 5.0 / 2.0 * 3.0;
            Console.WriteLine("5 / 2 * 3 = {0}", result);
        }

        static void Task365()
        {
            int k = -5;
            int b = 10;
            b -= k;
            Console.WriteLine(b);
        }

        static void Task367()
        {
            double result = 10 % 3;
            Console.WriteLine(result);
        }

        static void Task373()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked ((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);
            Console.ReadKey();
        }

        static void Task374()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);

            Console.Write("What is your favorite day of week: ");         
            byte favday = (byte)int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", (DaysOfWeek)favday);

            Console.ReadKey();
        }

        static void TaskN()
        {
            var name = Console.ReadLine();

            var age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);

            Console.Write("What is your favorite day of week? ");

            var day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", day);
        }
    }
}
