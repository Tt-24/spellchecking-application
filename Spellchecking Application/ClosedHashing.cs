using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ClosedHashingSpellChecker : ISpellChecker
{
    public String[] dictionary = new string[100];    // dictionary used for spellchecker
    public int HashFunction(string x)                // 
    {
        char[] charArray = x.ToCharArray();          // converting a string into char
        int count = 0;
        int convertAscii;     
         
        //// to display the resulted character array 
        for (int i = 0; i < charArray.Length; i++)
        {
            convertAscii = (int)charArray[i];        // converting a char into ascii 
            count += convertAscii;                   // adding the ascii of each character in a string
        }
        int index = count % dictionary.Length;       // using a modulus operator to get the value at which the string should be allocated in the array
        //Console.WriteLine("this is what i think the index should be! " + index);
        return index;
    }

    // Displays the dictionary array and the locations of the string inserted in an array
    public void Display()
    {
        for (int i = 0; i < dictionary.Length; i++)
        {
            Console.WriteLine(i + " " + dictionary[i]);
        }
    }

    // String is inserted in the dictioanry array
    public void Insert(string x)
    {
        int indexValue = HashFunction(x);
        int startIndex = indexValue;
        // If the indexvalue at which the string should be placed is full then it will increment 
        // to the next index till it finds an empty array. 
        while (dictionary[indexValue] != null)
        {
            indexValue++;
            // during the allocation if it couldnt find an empty index till the end position of the array 
            //then it will go back and start searching from the start position of the array, until it reaches 
            // where it started its search for an empty index from. 
            if (indexValue >= dictionary.Length)
            {
                indexValue = 0;       
            }
            if (startIndex == indexValue)
            {
                Console.WriteLine("Cannot Allocate");
                break;
            }
        }
        dictionary[indexValue] = x;
    }

    // It checks if the string inserted can be found in the dictionary array
    public bool Search(string x)
    {
        int indexValue = HashFunction(x);
        int startIndex = indexValue;
        // It iterates through the array until it finds the targeted string
        while (dictionary[indexValue] != x)
        {
            indexValue++;
            if (indexValue >= dictionary.Length)
            {
                indexValue = 0;

            }
            //Console.WriteLine("Is found " + x);
            if (startIndex == indexValue)
            {
                //Console.WriteLine("Not Found");
                return false;
            }
        }
        return true;
    }

    // It generate alternatives for a mispelled word(string) by searching in dictioanry array
    public string GenerateAlternatives(string x)
    {
        string y = "";
        char[] charArray = x.ToCharArray();          // converts string into char 
        // Mutate charcater array - turns every character of teh string into every alphabetical character
        for (int i = 0; i < charArray.Length; i++)
        {
            char originalCharacter = charArray[i];
            for (char j = 'a'; j <= 'z'; j++)
            {
                charArray[i] = j; //mutate
                y = new string(charArray);      //  char is converted into string
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

    // File reading code found on (https://docs.microsoft.com/en-us/dotnet/standard/io/how-to-read-text-from-a-file)
    //public void AddWordsFromFile(string Filename)  
    //{
    //    try
    //    {   // Open the text file using a stream reader.
    //        using (StreamReader sr = new StreamReader("dictionary.txt"))
    //        {
    //            // Read the stream to a string, and write the string to the console.
    //            String line = sr.ReadToEnd();
    //            Insert(line);
    //            Console.WriteLine(line);
    //        }
    //    }
    //    catch (IOException e)
    //    {
    //        Console.WriteLine("The file could not be read:");
    //        Console.WriteLine(e.Message);
    //    }
    //}
    
}

