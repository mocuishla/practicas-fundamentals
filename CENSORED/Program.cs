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
           List <string> palabrotas = new List<string>();

            palabrotas.Add("Mierda");
            palabrotas.Add("Cabron");
            palabrotas.Add("Puta");
            
            string input =  Console.ReadLine();

            string output = input;

            foreach(string palabrota in palabrotas)
            {
                output = output.Replace(palabrota, "Censored");
            }

            Console.WriteLine(output);


            

        }

    }
}
