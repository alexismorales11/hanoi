using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hanoi h = new Hanoi();

            char TorreInicial = 'A';
            char TorreAuxiliar = 'B';
            char TorreFinal = 'C';
            int n;
            String a;
            Console.WriteLine("Número de discos: ");
            a = Console.ReadLine();
            n = int.Parse(a);
            Console.WriteLine("\nLos movimientos a realizar son: \n");
            h.hanoi(n, TorreInicial, TorreAuxiliar, TorreFinal);
            Console.WriteLine("\n El número total de pasos es: " + h.pasos + "\n");
            Console.ReadLine();
        }
    }
}
