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
            SortedDictionary<string, int> M = new SortedDictionary<string, int>();
            foreach (var num in itemType)
            {
                if (!M.ContainsKey(num))
                {
                    M.Add(num, 0);
                }
                M[num]++;
            }
        
            int ret = 0;
            foreach (KeyValuePair<string, int> p in M)
            {
                ret += (p.Value + strength - 1) / strength;
            }

            return ret;

        }
    }
}
