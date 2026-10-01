using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            bool entradaValida;

            Console.Write("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            while (edad < 0)
            {
                Console.Write("Error: La edad no puede ser negativa. Ingrese nuevamente: ");
                edad = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("¿Tiene una entrada válida? (true/false): ");
            entradaValida = Convert.ToBoolean(Console.ReadLine());

            if (edad >= 18 && entradaValida)
            {
                Console.WriteLine("Puede ingresar a la actividad.");
            }
            else
            {
                Console.WriteLine("No puede ingresar a la actividad.");
            }
        }
    }
}