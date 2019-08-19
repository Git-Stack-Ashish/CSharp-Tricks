using System;

namespace TestLibrary
{
    public class Printing
    {
        public static int id { get; set; }

        public Printing()
        {

        }

        public static void Print()
        {
            Console.WriteLine("This is Printing.Print method.");
        }

        public static int Get()
        {
            return 1;
        }
    }
}
