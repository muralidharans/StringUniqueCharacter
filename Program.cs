using System;

namespace StringUniqueCharacters
{
    class Program
    {
        private static bool isuniquechars (string strinput)
        {
            // 256 chars fo
            bool[] bchars = new bool[256];

            foreach(char c in strinput)
            {
                if (bchars[c]== true)
                {
                    return false;
                }
                else
                {
                        bchars[c]= true;
                }

            }

            return true;
            

        }
        static void Main(string[] args)
        {
            Console.WriteLine(isuniquechars("Muralidharan"));
           // Console.WriteLine("Hello World!");
        }
    }
}
