using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0204
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> testCase = new List<string>
            {
                //"abcabcbb",
                //"bbbbb",
                //"pwwkew",
                "qrsvbspk"
            };
            foreach(var item in testCase)
            {
                Console.WriteLine($"{solution(item)}");
            }
            
            Console.ReadKey();
        }

        private static int solution(string s)
        {
            int keepIndex = 0;
            int moveIndex = 0;
            int max = 0;
            HashSet<char> collection = new HashSet<char>();

            while (moveIndex < s.Length)
            {
                if (!collection.Contains(s[moveIndex]))
                {
                    collection.Add(s[moveIndex]);
                    max = Math.Max(collection.Count, max);
                    moveIndex++;
                }
                else
                {
                    collection.Remove(s[keepIndex]);
                    keepIndex++;
                }
            }
            return max;
        }
    }
}
