using System;
using System.Collections.Generic;



namespace Collections_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numarray = new int[] {0,1,2,3,4,5,6,7,8,9};
            string[] namearray = new string[] {"Tim", "Martin", "Nikki", "Sara"};
            bool[] truefalse = new bool[] {true, false, true, false, true, false, true, false, true, false};

            List<string> icecream = new List<string>();
            icecream.Add("Mint Chocolate Chip");
            icecream.Add("Cookies and Cream");
            icecream.Add("Cookie Dough");
            icecream.Add("Brownies and Fudge");
            icecream.Add("Rocky Road");
            Console.WriteLine($"There are {icecream.Count} icecreams in the list");
            Console.WriteLine($"The third icecream in the list is {icecream[2]}");
            icecream.RemoveAt(2);
            Console.WriteLine($"There are {icecream.Count} icecreams in the list");

            Dictionary<string,string> users = new Dictionary<string, string>();
            Random rand = new Random();
            // users.Add(namearray[0], icecream[rand.Next(0,icecream.Count)]);
            // users.Add($"{namearray[1]}", $"{icecream[rand.Next(0,icecream.Count)]}");
            // users.Add($"{namearray[2]}", $"{icecream[rand.Next(0,icecream.Count)]}");
            // users.Add($"{namearray[3]}", $"{icecream[rand.Next(0,icecream.Count)]}");

            //create a loop that on each iteratioh does users.Add and also iterates
                //loop name array
            foreach (string name in namearray)
            {
                string randice = icecream[rand.Next(0,icecream.Count)];
                users.Add(name,randice);
            }

            foreach (KeyValuePair<string,string> entry in users)
            {
            Console.WriteLine(entry.Key + " - " + entry.Value);
            }

        }
    }
}
