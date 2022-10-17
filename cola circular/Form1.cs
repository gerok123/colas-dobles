using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Cola1 p = new Cola1();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            if (p.Llena())
                MessageBox.Show("Error:La pila de elementos esta LLENA");
            else
            {
                p.Insertar(a);
                listBox1.Items.Add(a);
            }
        }

        private void btneliminar1_Click(object sender, EventArgs e)
        {
            string x;
            if (p.Vacia())
                MessageBox.Show("Error:La pila de elementos esta VACIA");
            else
            {
                x = p.Eliminar();
                listBox1.Items.Remove(x);
            }
        }

        private void btninsertar2_Click(object sender, EventArgs e)
        {

            string a = textBox1.Text;
            if (p.Llena())
                MessageBox.Show("Error:La pila de elementos esta LLENA");
            else
            {
                p.Insertar2(a);
                listBox1.Items.Add(a);
            }

        }

        private void btneliminar2_Click(object sender, EventArgs e)
        {
            string x;
            if (p.Vacia())
                MessageBox.Show("Error:La pila de elementos esta VACIA");
            else
            {
                x = p.Eliminar2();
                listBox1.Items.Remove(x);
            }
        }
    }
}
