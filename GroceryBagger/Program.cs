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
                Console.WriteLine("Enter Bag Strength");
                Console.ReadLine();
            }
            else
            {
                string[] ListArray = GetList();
                GroceryBagger bagger = new GroceryBagger();
                bagger.MinimumBags(strength, ListArray);
            }
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
                else if (list.Count >= 50)
                {
                    Console.WriteLine("Cannot go over 50 items. Please type exit");
                }
                else
                {
                    foreach (var item in list)
                    {
                        if (item.Length <= 0 || item.Length > 50)
                        {
                            Console.WriteLine("Item can only between 1 and 50 characters");
                           
                        }
                        else if (item.Any(char.IsLower) || item.Any(char.IsDigit))
                        {

                            Console.WriteLine("items must be in Uppercase and cannot be numbers");
                           
                        }


                    }
                }
                list.Add(input);
            }

            ListArray = list.ToArray();


            return ListArray;
        }
    }
}


