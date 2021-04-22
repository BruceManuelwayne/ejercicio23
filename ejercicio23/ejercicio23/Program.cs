using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateString;
            bool fechaValida=true;
            DateTime parsedDate; 

            Console.WriteLine("Ingrese una fecha: ");
            do
            {
                dateString = Console.ReadLine();
                if(DateTime.TryParse(dateString, out parsedDate))
                {
                    Console.WriteLine(parsedDate);
                    break; 
                }
                else
                {
                    Console.WriteLine("formato invalido, ingrese otra fecha: ");
                    fechaValida = false;
                   
                }


            } while (!fechaValida);
            Console.ReadKey(); 

        }
    }
}
