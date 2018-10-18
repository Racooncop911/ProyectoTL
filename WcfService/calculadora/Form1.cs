using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Suma_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client())
            {
                int a = Convert.ToInt32(txtbxA.Text);
                int b = Convert.ToInt32(txtbxB.Text);
                cliente.GetSuma(a, b);
                OperationResult.Text = cliente.GetSuma(a, b).ToString();
            }
        }

        private void Resta_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client())
            {
                int a = Convert.ToInt32(txtbxA.Text);
                int b = Convert.ToInt32(txtbxB.Text);
                cliente.GetResta(a, b);
                OperationResult.Text = cliente.GetResta(a, b).ToString();
            }
        }

        private void Divi_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client())
            {
                int a = Convert.ToInt32(txtbxA.Text);
                int b = Convert.ToInt32(txtbxB.Text);
                cliente.GetDividir(a, b);
                OperationResult.Text = cliente.GetDividir(a, b).ToString();
            }

        }

        private void Producto_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client())
            {
                int a = Convert.ToInt32(txtbxA.Text);
                int b = Convert.ToInt32(txtbxB.Text);
                cliente.GetProducto(a, b);
                OperationResult.Text = cliente.GetProducto(a, b).ToString();
            }
        }
    }
}
