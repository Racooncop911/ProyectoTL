using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btsumar_Click(object sender, EventArgs e)
        {
            using (ServiceReference.Service1Client cliente = new ServiceReference.Service1Client())
            {
                int a = Convert.ToInt32(tbA.Text);
                int b = Convert.ToInt32(tbB.Text);
                lbResultado.Text = cliente.GetSuma(a, b).ToString();
            }

        }

        private void btresta_Click(object sender, EventArgs e)
        {
            using (ServiceReference.Service1Client cliente = new ServiceReference.Service1Client())
            {
                int a = Convert.ToInt32(tbA.Text);
                int b = Convert.ToInt32(tbB.Text);
                lbResultado.Text = cliente.GetResta(a, b).ToString();
            }
        }

        private void btmulti_Click(object sender, EventArgs e)
        {
            using (ServiceReference.Service1Client cliente = new ServiceReference.Service1Client())
            {
                int a = Convert.ToInt32(tbA.Text);
                int b = Convert.ToInt32(tbB.Text);
                lbResultado.Text = cliente.GetMulti(a,b).ToString();
            }

        }

        private void btdiv_Click(object sender, EventArgs e)
        {
            using (ServiceReference.Service1Client cliente = new ServiceReference.Service1Client())
            {
                int a = Convert.ToInt32(tbA.Text);
                int b = Convert.ToInt32(tbB.Text);
                lbResultado.Text = cliente.GetDiv(a,b).ToString();
            }

        }
    }
}
