using System;
using System.Collections.Generic;

namespace Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We find frequency from hashmap!");
            LinkedHashMap<string, int> LinkedHashMap = new LinkedHashMap<string, int>(18);
            string sentence = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words = sentence.ToLower().Split(" ");
            foreach (string word in words)
            {
                int value = LinkedHashMap.Get(word);
                if (value == default)
                {
                    value = 1;
                }
                else value += 1;
                LinkedHashMap.Add(word, value);
            }
            int frequencyParanoids = LinkedHashMap.Get("paranoids");
            int frequencyAre = LinkedHashMap.Get("are");
            int frequencyThey = LinkedHashMap.Get("they");
            int frequencyBut = LinkedHashMap.Get("but");
            Console.WriteLine("The frequency of Paranoid is: " + frequencyParanoids);
            Console.WriteLine("The frequency of Are is: " + frequencyAre);
            Console.WriteLine("The frequency of They is: " + frequencyThey);
            Console.WriteLine("The frequency of But is: " + frequencyBut);
        }
    }
}
