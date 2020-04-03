using System;
using System.Collections.Generic;
using System.Text;

namespace AB3
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahlenWert = 0;
            Console.WriteLine("Geben Sie Ihre römische Nummer ein");
            string nutzerInput = Console.ReadLine();
            /* evaluate zeichen */
            IDictionary<char, int> uebersetzer = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100}
            };
            int i = 0;
            while (i < nutzerInput.Length)
                {
                int nextVal;
                char currChar = nutzerInput[i];
                int currVal = uebersetzer[currChar];
                if (i < nutzerInput.Length-1)
                {
                    char nextChar = nutzerInput[i + 1];
                    nextVal = uebersetzer[nextChar];
                }
                else
                {
                    nextVal = 0;
                }

                if (currVal < nextVal)
                {
                    zahlenWert -= currVal;
                }
                else if (currVal >= nextVal)
                {
                    zahlenWert += currVal;
                }
                i++;
                }

            /* attempt before I realized we needed subtraction notation */
            /* foreach (char c in nutzerInput)
            {
                switch(c)
                {
                    case 'I':
                        zahlenWert += 1;
                        break;
                    case 'V':
                        zahlenWert += 5;
                        break;
                    case 'X':
                        zahlenWert += 10;
                        break;
                    case 'L':
                        zahlenWert += 50;
                        break;
                    case 'C':
                        zahlenWert += 100;
                        break;
                    default:
                        break;
                }
            }
            */
            if (zahlenWert <= 0)
            {
                Console.WriteLine("Eingabefehler");
            }
            else
            {
                Console.WriteLine("Ihre Zahlenwert ist {0}", zahlenWert);
            }
        }
    }
}
