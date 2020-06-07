using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellChecker
{
    class LinearSearch
    {
        
        static bool LinearSearchSpellChecker(string[] dictionary, string x)
        {
            for (int i = 0; i < dictionary.Length; i++)
            {
                if (dictionary[i] == x)
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
