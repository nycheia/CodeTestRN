using System;
using System.Collections.Generic;
using RestSharp;

namespace CodeTestRN
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex1
            List<Names> nameList = new List<Names>();
            Names p1 = new Names("Robert", "Robertson");
            Names p2 = new Names("Casper", "Sirson");
            Names p3 = new Names("Sir", "Casperson");
            nameList.Add(p1);
            nameList.Add(p2);
            nameList.Add(p3);
            foreach (Names n in nameList)
            {
                Console.Write(n.ToString() + "\n");
            }

            //ex2 call either to check for palindromes, not both at the same time. Last one does not work yet
            //Palindrome.checkPalindrome("Malayalam");
            //Palindrome.checkPalindrome(2002);
            Palindrome.checkPalindrome("stack cats");
            

            // ex3 didnt have time to finish it
            /*string url = "https://swapi.dev/api/people/1";
            var client = new RestClient(url);
            var request = new RestRequest();
            var response = client.GetAsync(request);
            Console.WriteLine(response.Get(request);
            Console.Read();*/
        }
    }
}
