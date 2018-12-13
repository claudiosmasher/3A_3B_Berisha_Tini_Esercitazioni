using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEsercitazioni
{
    class Program
    {
        static void Main(string[] args)
        {
            string plainText = "";
            string base64EncodedData;


            Console.WriteLine("Inserisci il valore");
            plainText = Convert.ToString(Console.ReadLine());

            byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);


            for (int i =0; i < plainTextBytes.Length; i++)
            {
                Console.WriteLine(plainTextBytes[i]);
                Console.WriteLine(Convert.ToString(plainTextBytes[i], 2));
            }
            base64EncodedData = Convert.ToBase64String(plainTextBytes);
         

            byte[] base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            plainText = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            Console.WriteLine($"la codifica in base 64 della parola {plainText} è {base64EncodedData}");

            int valore12 = 0;

            Console.WriteLine("Inserisci il valore:");
            valore12 = Convert.ToInt32(Console.ReadLine());

            char c = Convert.ToChar(valore12);
            string d = c.ToString();

            Console.WriteLine(d);

            Console.ReadLine();
        }
    }
}
