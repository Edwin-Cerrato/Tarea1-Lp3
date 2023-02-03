using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
  
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt16(txtValor.Text);

            //Llamado de Funcion
            ParImpar(valor);
            Signo(valor);
        }

        //Funcion Impar/Par
        private int ParImpar(int num1)

        {
            if ((num1 %2)==0)
            {
                MessageBox.Show("El numero es PAR","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("El numero es IMPAR", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return num1;

        }

        //Funcion Negativo/Positivo
        private int Signo(int num)
        {
            if (num == 0)
            {
                MessageBox.Show(" Es un Numero NEUTRO ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            if (num>0)
            {
                MessageBox.Show(" El numero es Positivo +", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" El numero es Negativo -", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return num;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
        }
    }
}
