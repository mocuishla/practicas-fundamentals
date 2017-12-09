using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CENSORED
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> palabrotas = new List<string>();

            palabrotas.Add("Mierda");
            palabrotas.Add("Cabron");
            palabrotas.Add("Puta");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "acabar")
                {
                     break;//me saca del bucle
                   // return; //me saca del metodo
                }

                string output = input;

                foreach (string palabrota in palabrotas)
                {
                    output = output.Replace(palabrota, palabrota.Substring(0, 1) + "...");
                }

                Console.WriteLine(output);
            }

            Console.WriteLine("Estoy acabando");

        }

    }
}
