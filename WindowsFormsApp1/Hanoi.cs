using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Hanoi
    {
            public string a { get; set; }
            public int pasos { get; set; }

            public void hanoi(int n, char c, char a, char f)
            {
                if (n == 1)
                {
                    Console.WriteLine("El Primero de la Torre " + c + " Hacia la Torre " + f);
                    pasos++;
                }
                else
                {
                    pasos++;
                    hanoi(n - 1, c, f, a);
                    Console.WriteLine("El Primero de la Torre " + c + " Hacia la Torre " + f);
                    hanoi(n - 1, a, c, f);
                }
            }
        }
}
