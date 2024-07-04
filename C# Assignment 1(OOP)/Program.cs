using System.Xml.Linq;
using static C__Assignment_1_OOP_.Program;

namespace C__Assignment_1_OOP_
{
    internal class Program
    {
        #region Q1
        //public enum WeekDays
        //{
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday
        //}
        //static void Main(string[] args)
        //{
        //    // WeekDays days = WeekDays.Monday;

        //    foreach (var day in Enum.GetValues(typeof(WeekDays)))
        //    {
        //        Console.WriteLine($"{day} = {(int)day} ");

        //    }

        //}

        #endregion

        #region Q2

        //public struct Person
        //{
        //    public string Name { get; set; }
        //    public int Age { get; set; }

        //    public Person(string name, int age)
        //    {
        //        Name = name;
        //        Age = age;
        //    }
        //}
        //public static void Main()
        //{
        //    Person[] persons = new Person[3];

        //    persons[0] = new Person("Ali", 25);
        //    persons[1] = new Person("Omar", 24);
        //    persons[2] = new Person("Hamza", 21);


        //    Console.WriteLine($"Name: {persons[0].Name}, Age: {persons[0].Age}");
        //    Console.WriteLine($"Name: {persons[1].Name}, Age: {persons[1].Age}");
        //    Console.WriteLine($"Name: {persons[2].Name}, Age: {persons[2].Age}");            
        //}
        #endregion

        #region Q3

        //public enum Season
        //{
        //    Spring,Summer,Autumn,Winter
        //}
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
        //    string input = Console.ReadLine();

        //    bool CheckSeason = Enum.TryParse(input, true, out Season season);

        //    switch (season)
        //    {
        //        case Season.Spring:
        //            Console.WriteLine("spring is between march to may");
        //            break;
        //        case Season.Summer:
        //            Console.WriteLine("Summer is between June to August");
        //            break;
        //        case Season.Autumn:
        //            Console.WriteLine("Autumn is between September to November");
        //            break;
        //        case Season.Winter:
        //            Console.WriteLine("Winter is between December to February");
        //            break;
        //        default:
        //            Console.WriteLine("Unknown season");
        //            break;

        //    }
        //}
        #endregion

        #region Q5
        //enum Color
        //{
        //    Red,
        //    Green,
        //    Blue
        //}
        //static void Main()
        //{

        //    Console.WriteLine("Enter a color (Red, Green, Blue):");
        //    string input = Console.ReadLine();

        //    bool CheckColor = Enum.TryParse(input, true, out Color color);


        //    switch (color)
        //    {
        //        case Color.Red:
        //        case Color.Green:
        //        case Color.Blue:
        //            Console.WriteLine($"{color} is a primary color.");
        //            break;
        //        default:
        //            Console.WriteLine($"{color} is not a primary color.");
        //            break;
        //    }



        //}
        #endregion

        #region @6

        //public struct Point
        //{
        //    public double X { get; set; }
        //    public double Y { get; set; }

        //    public Point(double x, double y)
        //    {
        //        X = x;
        //        Y = y;
        //    }
        //}
        //public static void Main()
        //{

        //    Console.WriteLine("Enter the first point (X Y):");
        //    string[] point1Input = Console.ReadLine().Split(' ');
        //    double x1 = double.Parse(point1Input[0]);
        //    double y1 = double.Parse(point1Input[1]);

        //    Point point1 = new Point(x1, y1);

        //    Console.WriteLine("Enter the second point (X Y):");
        //    string[] point2Input = Console.ReadLine().Split(' ');
        //    double x2 = double.Parse(point2Input[0]);
        //    double y2 = double.Parse(point2Input[1]);

        //    Point point2 = new Point(x2, y2);

        //    double distance = CalculateDistance(point1, point2);

        //    Console.WriteLine($"The distance between the points is: {distance}");
        //}

        //public static double CalculateDistance(Point p1, Point p2)
        //{
        //    double deltaX = p2.X - p1.X;
        //    double deltaY = p2.Y - p1.Y;
        //    return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        //}
        #endregion

        #region Q7 

        public struct Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
        public static void Main()
        {
            Person[] persons = new Person[3];

            persons[0] = new Person("Ali", 25);
            persons[1] = new Person("Omar", 24);
            persons[2] = new Person("Hamza", 21);


            Person oldest = persons[4];
            for (int i = 1; i < persons.Length; i++)
            {
                if (persons[i].Age > oldest.Age)
                {
                    oldest = persons[i];
                }
            }

            // Display the name and age of the oldest person
            Console.WriteLine($"The oldest person is {oldest.Name} with an age of {oldest.Age}.");

        }


        #endregion
    }
}



