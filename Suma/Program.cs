using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 8;
            double num2 = 4.5;
            double resultado;

            //sumando dos variables
            resultado = num + num2;
            Console.WriteLine("Suma de variables: " + resultado);
            //Suma con un dato explicitamente
            resultado = num + 22;
            Console.WriteLine("Suma con dato explicito: " + resultado);
            //Concatenacion de cadenas
            string saludo = "Hola";
            string nombre = "Hugo";
            Console.WriteLine(saludo + " " + nombre + " " + "Como estas" );
            Console.ReadKey();


        }
    }
}
