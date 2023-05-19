using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_of_the_Character_convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char e;
            int i;
            Console.WriteLine("Enter the Character : ");
            e = Convert.ToChar(Console.ReadLine());
            i = (int)e;
            if (e >= 65 && e <= 90)
            {

                Console.WriteLine("The Character is : {0}", char.ToLower(e));

            }
            else if (e >= 97 && e <= 122)
            {
                Console.WriteLine("The Character is : {0}", char.ToUpper(e));
            }
            Console.ReadLine();
        }
    }
    }

