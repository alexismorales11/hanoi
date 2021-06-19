using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int pasos;
        public Form1()
        {

            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {

         char TorreInicial = 'A';
         char TorreAuxiliar = 'B';
         char TorreFinal = 'C';
         int n1;
        String Num= txtNumDiscos.Text;
            n1 = int.Parse(Num);
            hanoi(n1, TorreInicial, TorreAuxiliar, TorreFinal);
            
        }
        void hanoi(int n, char c, char a, char f)
        {
            if (n == 1)
            {
                txtPasos.Text = ("El Primero de la Torre " + c + " Hacia la Torre " + f + "\n");
                pasos++;
            }
            else
            {
                pasos++;
                hanoi(n - 1, c, f, a);
                txtPasos.Text = ("El Primero de la Torre " + c + " Hacia la Torre" + f + "\n");
                hanoi(n - 1, a, c, f);
            }
        }
    }

}
