using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag1_Aufgabe_03
{
    class Program
    {
        static uint batterieLaufzeit = 5;
        static string aufgabe = "Ich reiche Bier."; // Bier ist besser als Butter :)

        static bool istBatterieLaufzeitNiedrig()
        {
            if (batterieLaufzeit < 2)
            {
                return true;
            }
            return false;
        }

        static void fuehreAufgabeAus()
        {
            if(!istBatterieLaufzeitNiedrig())
            {
                Console.WriteLine(aufgabe);
                batterieLaufzeit--;
            }
            else
            {
                Console.WriteLine("Ich muss aufgeladen werden!");
            }
        }
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                fuehreAufgabeAus();
            }
            Console.ReadLine();
        }
    }
}
