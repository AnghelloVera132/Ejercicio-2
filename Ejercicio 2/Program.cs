using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el coeficiente: ");
            int coeficiente = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el exponente: ");
            int exponente = int.Parse(Console.ReadLine());
            int resoult = 1;
            for (int i = 0; i < exponente; i++)
            {
                resoult *= coeficiente;
            }
            Console.WriteLine("La potencia es "+ resoult);
            Console.ReadLine();
        }
    }
}
