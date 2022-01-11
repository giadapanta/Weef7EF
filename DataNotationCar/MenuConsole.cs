using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNotationCar
{
    public class MenuConsole
    {
        internal static string GetInfo(string info)
        {
            string s;
            do
            {
                Console.WriteLine($"Inserisci {info}: ");
                s = Console.ReadLine();
            }
            while(string.IsNullOrEmpty(s));
           return s;
        }

        internal static DateTime GetDate(string info)
        {
            DateTime dt; 
            do
            {
                Console.WriteLine($"Inserisci {info}");
                
            }
            while(!DateTime.TryParse(Console.ReadLine(), out dt));  
            return dt;
        }

        internal static int GetInt(string v)
        {
            int i;
            do
            {
                Console.WriteLine($"Inserisci {v}");
               
            }
            while (!int.TryParse(Console.ReadLine(), out i));
            return i;
        }
    }
}
