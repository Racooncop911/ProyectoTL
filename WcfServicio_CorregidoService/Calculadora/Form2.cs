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
    public partial class Form2 : Form
    {
        int opcion;
        float a;
        float b;
        float c;
        public Form2()
        {
            InitializeComponent();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            opcion = 4;
            using (ServiceReference.Service1Client cliente = new ServiceReference.Service1Client())
            {
                a = Convert.ToInt32(textresultado.Text);
                c = a;
                textresultado.Clear();
            }
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            opcion = 3;
            using (ServiceReference.Service1Client cliente = new ServiceReference.Service1Client())
            {
                a = Convert.ToInt32(textresultado.Text);
                c = a;
                textresultado.Clear();
            }
        }

        private void btnres_Click(object sender, EventArgs e)
        {
            opcion = 2;
            using (ServiceReference.Service1Client cliente = new ServiceReference.Service1Client())
            {
                a = Convert.ToInt32(textresultado.Text);
                c = a;
                textresultado.Clear();

            }
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            opcion = 1;
            using (ServiceReference.Service1Client cliente = new ServiceReference.Service1Client())
            {
                a = Convert.ToInt32(textresultado.Text);
                c = a;
                textresultado.Clear();
            }
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            switch (opcion)
            {
                case 1:
                    using (ServiceReference.Service1Client cliente = new ServiceReference.Service1Client())
                    {
                        b = Convert.ToSingle(textresultado.Text);
                        //b = Convert.ToInt32(textresultado.Text);
                        cliente.GetSuma(a, b);
                        textresultado.Text = Convert.ToString(cliente.GetSuma(a, b));
                    }

                    break;
                case 2:
                    using (ServiceReference.Service1Client cliente = new ServiceReference.Service1Client())
                    {
                        b = float.Parse(textresultado.Text);
                        cliente.GetResta(a, b);
                        textresultado.Text = Convert.ToString(cliente.GetResta(a, b));
                    }
                    break;
                case 3:
                    using (ServiceReference.Service1Client cliente = new ServiceReference.Service1Client())
                    {
                        b = float.Parse(textresultado.Text);
                        cliente.GetMulti(a, b);
                        textresultado.Text = Convert.ToString(cliente.GetMulti(a, b));
                    }
                    break;
                case 4:
                    using (ServiceReference.Service1Client cliente = new ServiceReference.Service1Client())
                    {
                        b = float.Parse(textresultado.Text);
                        cliente.GetDiv(a, b);
                        textresultado.Text = Convert.ToString(cliente.GetDiv(a, b));
                    }
                    break;

                default:
                    break;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            numero("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            numero("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            numero("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            numero("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            numero("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            numero("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            numero("6");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numero("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            numero("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            numero("9");
        }

        private void Form2_Load(object sender, EventArgs e)

        {
            textresultado.Clear();
        }

        public void numero(string number)
        {
            textresultado.Text = textresultado.Text + number;
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            textresultado.Clear();
        }
    }
}
