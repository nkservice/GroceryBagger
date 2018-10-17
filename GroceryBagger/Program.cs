using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryBagger
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Enter Bag Strength");
            string SStrength = Console.ReadLine();
            int strength = System.Convert.ToInt32(SStrength);

            if (strength <= 0 || strength > 50)
            {
                Console.WriteLine("Number must be between 1 and 50");
                Console.ReadLine();

            }

            string[] ListArray = GetList();
            GroceryBagger bagger = new GroceryBagger();
            var test = bagger.MinimumBags(strength, ListArray);

            Console.WriteLine("The number of bags needed is " + test);
            Console.ReadLine();

        }


        public static string[] GetList()
        {
            List<String> list = new List<String>();
            string[] ListArray;
            Console.WriteLine("Enter list items. Type exit when finished.");

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {

                    break;
                }

                if (input.Length <= 0 || input.Length > 50)
                {
                    Console.WriteLine("Item can only between 1 and 50 characters");

                }

                else if (input.Any(char.IsLower) || input.Any(char.IsDigit))
                {

                    Console.WriteLine("Items must be in Uppercase and cannot be numbers");


                }
                else
                {
                    list.Add(input);
                }

                if (list.Count >= 50)
                {
                    Console.WriteLine("Cannot go over 50 items. Please type exit");
                    break;
                }
            }

            ListArray = list.ToArray();
            return ListArray;
        }
    }
}


