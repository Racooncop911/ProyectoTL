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
   
    public partial class V2 : Form
    {
        int opciones;
        float a;
        float b;
        float c;
        public V2()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {//NO.1
            numeracion("1");
        }

        private void button3_Click(object sender, EventArgs e)
        {//NO.2
            numeracion("2");
        }

        private void button7_Click(object sender, EventArgs e)
        {//NO.3
            numeracion("3");
        }

        private void button12_Click(object sender, EventArgs e)
        {//NO.4
            numeracion("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {//NO.5
            numeracion("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {//NO.6
            numeracion("6");
        }

        private void button1_Click(object sender, EventArgs e)
        {//NO.7
            numeracion("7");
        }

        private void button16_Click(object sender, EventArgs e)
        {//NO.8
            numeracion("8");
        }

        private void button15_Click(object sender, EventArgs e)
        {//NO.9
            numeracion("9");
        }

        private void button2_Click(object sender, EventArgs e)
        {//NO.0
            numeracion("0");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //TxtResult.Text = TxtResult.Text + '';
        }
        //BOTON DE SUMA
        public void button11_Click(object sender, EventArgs e)
        {
            opciones = 1;
            using (ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client())
            {
                a = Convert.ToInt32(TxtResult.Text);

               
                TxtResult.Clear();
            }
        }
        //BOTON DE RESTA
        public void button10_Click(object sender, EventArgs e)
        {
            
            opciones = 2;
            using (ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client())
            {
                a = Convert.ToInt32(TxtResult.Text);
               
                TxtResult.Clear();
                
            }
        }
        //BOTON DE PRODUCTO
        public void button8_Click(object sender, EventArgs e)
        {
            opciones = 3;
            
            using (ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client())
            {
                a = Convert.ToInt32(TxtResult.Text);

           
                TxtResult.Clear();
            }
        }
        //BOTON DE DIVISION
        public void button14_Click(object sender, EventArgs e)
        {
            opciones = 4;
            
            using (ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client())
            {
                a = Convert.ToInt32(TxtResult.Text);

   
                TxtResult.Clear();
            }
            
        }

        public void button4_Click(object sender, EventArgs e)
        {
            //BOTON DE IGUAL
            switch (opciones)
            {
                case 1://SUMA
                    using (ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client())
                    {
                        
                        b = Convert.ToInt32(TxtResult.Text);
                        //cliente.GetSuma(a, b);
                        //TxtResult.Text = cliente
                        TxtResult.Text = Convert.ToString(cliente.GetSuma(a, b));
                    }
                    
                    break;
                case 2://RESTA
                    using (ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client())
                    {
                        b = float.Parse(TxtResult.Text);
                        //cliente.GetResta(a, b);
                        //TxtResult.Text = cliente
                        TxtResult.Text = Convert.ToString(cliente.GetResta(a, b));
                    }
                    break;
                case 3:
                    using (ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client())
                    {
                        b = float.Parse(TxtResult.Text);
                        //cliente.GetSuma(a, b);
                        //TxtResult.Text = cliente
                        TxtResult.Text = Convert.ToString(cliente.GetProducto(a, b));
                    }
                    break;
                case 4:
                    using (ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client())
                    {
                        b = float.Parse(TxtResult.Text);
                        //cliente.GetSuma(a, b);
                        //TxtResult.Text = cliente
                        TxtResult.Text = Convert.ToString(cliente.GetDividir(a, b));

                    }
                    break;

                default:
                    break;
            }

        }

        private void V2_Load(object sender, EventArgs e)
        {
            TxtResult.Clear();
        }

        public void numeracion (string number)
        {
            TxtResult.Text = TxtResult.Text + number;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            TxtResult.Clear();
        }
    }
}
