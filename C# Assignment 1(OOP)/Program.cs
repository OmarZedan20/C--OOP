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


            Console.WriteLine($"Name: {persons[0].Name}, Age: {persons[0].Age}");
            Console.WriteLine($"Name: {persons[1].Name}, Age: {persons[1].Age}");
            Console.WriteLine($"Name: {persons[2].Name}, Age: {persons[2].Age}");            
        }
        #endregion

}
}
