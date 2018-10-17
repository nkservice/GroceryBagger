using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryBagger
{
    class GroceryBagger
    {
        public int MinimumBags(int strength, String[] itemType)
        {

            Console.WriteLine(strength);
            Console.WriteLine(itemType.Length);
            foreach (string item in itemType)
                {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            return 0;
        }

    }
}
