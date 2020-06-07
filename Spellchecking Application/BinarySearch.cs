using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellChecker
{
    class BinarySearch : ISpellChecker
    {
        public String[] dictionary = new string[63];   // dicitonary for binary array

        // uses binary search algorithm: first divides the upper bound and the lower bound with 2 to find the middle 
        // it starts its search from the middle and then compare which one first it should start searching
        public bool Search(string x)
        {
            int mid;
            int lb = 0;
            int ub = dictionary.Length;

            while (ub >= lb)
            {
                mid = (lb + ub) / 2;
                if (dictionary[mid] == x)
                {
                    Console.WriteLine("Found");
                    return true;
                }
                if (x.CompareTo(dictionary[mid]) > 0)
                {
                    lb = mid + 1;

                }
                else
                {
                    ub = mid - 1;
                }
                    
            }
            //Console.WriteLine("Not Found");
            return false;
        }


        // Displays the dictionary array and the locations of the string inserted in an array
        public void Display()
        {
            for (int i = 0; i < dictionary.Length; i++)
            {
                Console.WriteLine(i + " " + dictionary[i]);
            }
        }

        // Insert the string into the dictioanry array
        public void Insert(string x)
        {
            for (int i = 0; i < dictionary.Length; i++)
            {
                if (dictionary[i] == null)
                {
                    dictionary[i] = x;
                    break;
                }
            }
        }

        // It generate alternatives for a mispelled word(string) by searching in dictioanry array
        public string GenerateAlternatives(string x)
        {
            string y = "";
            char[] charArray = x.ToCharArray();     // converts string into char 
            // Mutate charcater array - turns every character of teh string into every alphabetical character
            for (int i = 0; i < charArray.Length; i++)
            {
                char originalCharacter = charArray[i];
                for (char j = 'a'; j <= 'z'; j++)
                {
                    charArray[i] = j; //mutate
                    y = new string(charArray);     //  char is converted into string
                    //Console.WriteLine(y);
                    // search mutated string in the dictionary
                    if (Search(y) == true)
                    {
                        //Console.WriteLine("Found " + y);
                        return y;
                    }
                }
                charArray[i] = originalCharacter;
            }
            y = "Not Found";
            return y;
        }
    }
}
