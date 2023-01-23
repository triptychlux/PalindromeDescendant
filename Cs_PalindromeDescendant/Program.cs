using System;
using System.Collections.Generic;
using System.Linq;

namespace Cs_PalindromeDescendant
{
    class Program
    {
        public static bool PalindromeDescendant(int num)
        {
            
            string s = num.ToString();
            List<char> numberListChar = new List<char>();
            foreach (char c in s)
            {
                numberListChar.Add(c);
            }
            List<string> numberListString = numberListChar.Select(c => c.ToString()).ToList();

            
            List<int> numbers = numberListString.Select(int.Parse).ToList();
            List<int> descendant = new List<int>();

            for (int listCounter = 0; listCounter < numbers.Count(); listCounter = +2)
            {
                for (int i = 0; i < 2; i++)
                {
                    descendant[listCounter+i] = numbers[listCounter+i] + numbers[listCounter+i + 1];
                }
            }

            //List<int> numbers = s?.Split( ).Select(Int32.Parse).ToList();
            //List<int> numbers = s.Split().Select(Int32.Parse).ToList();
            //List<int> numbers = new List<int>();

            Console.WriteLine(descendant);


            //temporary to avoid errors
            return false;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Number required");
            int innum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PalindromeDescendant(innum));
            
        }
    }
}
