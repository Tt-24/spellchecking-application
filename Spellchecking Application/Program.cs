using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellChecker
{
    class Program
    {     
        static void Main(string[] args)
        {
            ////////////////////////////////////LINEAR SEARCH/////////////////////////
            //bool wasStringFound = LinearSearchSpellChecker(dictionary,"Apple");
            //if (wasStringFound == true)
            //{
            //    Console.WriteLine("was found");
            //}
            //else
            //{
            //    Console.WriteLine("was not found");
            //}
            //Console.ReadLine();

            ////////////////////////////////////BINARY SEARCH/////////////////////////
            //BinarySearch mySpellChecker = new BinarySearch();
            //mySpellChecker.Insert("acai");
            //mySpellChecker.Insert("apple");
            //mySpellChecker.Insert("apricot");
            //mySpellChecker.Insert("avocado");
            //mySpellChecker.Insert("banana");
            //mySpellChecker.Insert("beans");
            //mySpellChecker.Insert("beets");
            //mySpellChecker.Insert("blackberries");
            //mySpellChecker.Insert("cabbage");
            //mySpellChecker.Insert("cantaloupe");
            //mySpellChecker.Insert("carrots");
            //mySpellChecker.Insert("cauliflower");
            //mySpellChecker.Insert("dates");
            //mySpellChecker.Insert("edamame");
            //mySpellChecker.Insert("eggplant");
            //mySpellChecker.Insert("endive");
            //mySpellChecker.Insert("feijoa");
            //mySpellChecker.Insert("fennel");
            //mySpellChecker.Insert("figs");
            //mySpellChecker.Insert("garlic");
            //mySpellChecker.Insert("ginger");
            //mySpellChecker.Insert("grapes");
            //mySpellChecker.Insert("gooseberries");
            //mySpellChecker.Insert("guava");
            //mySpellChecker.Insert("huckleberries");
            //mySpellChecker.Insert("hominy");
            //mySpellChecker.Insert("iceberg lettuce");
            //mySpellChecker.Insert("jalapeno");
            //mySpellChecker.Insert("jicama");
            //mySpellChecker.Insert("kale");
            //mySpellChecker.Insert("kiwifruit");
            //mySpellChecker.Insert("leeks");
            //mySpellChecker.Insert("lemons");
            //mySpellChecker.Insert("lentils");
            //mySpellChecker.Insert("lettuce");
            //mySpellChecker.Insert("mandarins");
            //mySpellChecker.Insert("mangos");
            //mySpellChecker.Insert("mint");
            //mySpellChecker.Insert("napa");
            //mySpellChecker.Insert("nectarines");
            //mySpellChecker.Insert("okra");
            //mySpellChecker.Insert("olives");
            //mySpellChecker.Insert("onion");
            //mySpellChecker.Insert("papayas");
            //mySpellChecker.Insert("peaches");
            //mySpellChecker.Insert("pears");
            //mySpellChecker.Insert("quince");
            //mySpellChecker.Insert("radicchio");
            //mySpellChecker.Insert("radishes");
            //mySpellChecker.Insert("spinach");
            //mySpellChecker.Insert("sprouts");
            //mySpellChecker.Insert("squash");
            //mySpellChecker.Insert("strawberries");
            //mySpellChecker.Insert("tangelo");
            //mySpellChecker.Insert("tomato");
            //mySpellChecker.Insert("turnip");
            //mySpellChecker.Insert("ugli fruit");
            //mySpellChecker.Insert("water chestnuts");
            //mySpellChecker.Insert("watercress");
            //mySpellChecker.Insert("watermelon");
            //mySpellChecker.Insert("yums");
            //mySpellChecker.Insert("yuca");
            //mySpellChecker.Insert("zucchini");
            //Console.WriteLine("Alternatives for the word: " + mySpellChecker.GenerateAlternatives("ginget"));
            //mySpellChecker.Display();
            //Console.ReadLine();

            /////////////////////HASHING (OPEN ADDRESSING)/////////////////////////////////////
            ClosedHashingSpellChecker mySpellChecker = new ClosedHashingSpellChecker();
            mySpellChecker.Insert("acai");
            mySpellChecker.Insert("apple");
            mySpellChecker.Insert("apricot");
            mySpellChecker.Insert("avocado");
            mySpellChecker.Insert("banana");
            mySpellChecker.Insert("beans");
            mySpellChecker.Insert("beets");
            mySpellChecker.Insert("blackberries");
            mySpellChecker.Insert("cabbage");
            mySpellChecker.Insert("cantaloupe");
            mySpellChecker.Insert("carrots");
            mySpellChecker.Insert("cauliflower");
            mySpellChecker.Insert("dates");
            mySpellChecker.Insert("edamame");
            mySpellChecker.Insert("eggplant");
            mySpellChecker.Insert("endive");
            mySpellChecker.Insert("feijoa");
            mySpellChecker.Insert("fennel");
            mySpellChecker.Insert("figs");
            mySpellChecker.Insert("garlic");
            mySpellChecker.Insert("ginger");
            mySpellChecker.Insert("grapes");
            mySpellChecker.Insert("gooseberries");
            mySpellChecker.Insert("guava");
            mySpellChecker.Insert("huckleberries");
            mySpellChecker.Insert("hominy");
            mySpellChecker.Insert("iceberg Lettuce");
            mySpellChecker.Insert("jalapeno");
            mySpellChecker.Insert("jicama");
            mySpellChecker.Insert("kale");
            mySpellChecker.Insert("kiwifruit");
            mySpellChecker.Insert("leeks");
            mySpellChecker.Insert("lemons");
            mySpellChecker.Insert("lentils");
            mySpellChecker.Insert("lettuce");
            mySpellChecker.Insert("mandarins");
            mySpellChecker.Insert("mangos");
            mySpellChecker.Insert("mint");
            mySpellChecker.Insert("napa");
            mySpellChecker.Insert("nectarines");
            mySpellChecker.Insert("okra");
            mySpellChecker.Insert("olives");
            mySpellChecker.Insert("onion");
            mySpellChecker.Insert("papayas");
            mySpellChecker.Insert("peaches");
            mySpellChecker.Insert("pears");
            mySpellChecker.Insert("quince");
            mySpellChecker.Insert("radicchio");
            mySpellChecker.Insert("radishes");
            mySpellChecker.Insert("spinach");
            mySpellChecker.Insert("sprouts");
            mySpellChecker.Insert("squash");
            mySpellChecker.Insert("strawberries");
            mySpellChecker.Insert("tangelo");
            mySpellChecker.Insert("tomato");
            mySpellChecker.Insert("turnip");
            mySpellChecker.Insert("ugli fruit");
            mySpellChecker.Insert("water chestnuts");
            mySpellChecker.Insert("watercress");
            mySpellChecker.Insert("watermelon");
            mySpellChecker.Insert("yums");
            mySpellChecker.Insert("yuca");
            mySpellChecker.Insert("zucchini");

            //////mySpellChecker.AddWordsFromFile("dictionary.txt");
            Console.WriteLine("Alternatives for word: " + mySpellChecker.GenerateAlternatives("yuks"));
            mySpellChecker.Display();
            Console.ReadLine();
        }

    }
}
