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

        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int [] numeros = new int[10]; <- Declarar y construir
            //int [] numeros; <- Solamente declaramos

            for (int num = 0; num < 10; num++) {
                
                textBox1.Text = textBox1.Text + "\r\n" + numeros[num];

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean exist = true;
            int indice = 0;

            for (int num = 0; num < 10; num++)
            {
                if (textBox2.Text == Convert.ToString(numeros[num]))
                {
                    exist = true;
                    indice = num;
                    break;
                }
                else {
                    exist = false;
                }  
                
            }

            if (exist == true)
            {
                MessageBox.Show("Tu numero se encuentra en el indice " + indice);
            }
            else
            {
                MessageBox.Show("Tu numero no existe en el arreglo");
            }


        }
    }
}
