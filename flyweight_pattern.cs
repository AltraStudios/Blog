using System;
using System.Collections.Generic;

namespace flyweight_pattern
{
    class Program
    {
        public class CharObject
        {
            char myChar;

            public CharObject(char c)
            {
                this.myChar = c;
            }

            public void Display()
            {
                Console.WriteLine(myChar);
            }
        }
        public class FlywieghtFactory
        {
            Dictionary<char, CharObject> pool = new Dictionary<char, CharObject>();
            private static FlywieghtFactory Instance;

            private FlywieghtFactory() { }

            public static FlywieghtFactory GetInstance()
            {
                if (Instance == null)
                    Instance = new FlywieghtFactory();
                return Instance;
            }

            public void DisplayChar(char c)
            {
                if (pool.ContainsKey(c) == false)
                    pool.Add(c, new CharObject(c));

                pool[c].Display();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter characters to load");
            var order = Console.ReadLine();
            char[] chars = order.ToCharArray();

            FlywieghtFactory fFactory = FlywieghtFactory.GetInstance();

            //display chars
            foreach (char c in chars)
            {
                fFactory.DisplayChar(c);
            }

            Console.ReadKey();
        }
    }
}
