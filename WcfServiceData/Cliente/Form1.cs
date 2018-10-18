using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//AGREGAR A LA BASE DE DATOS
            using (ServiceReference1.Service1Client servicio = new ServiceReference1.Service1Client())
            {
                ServiceReference1.AlumnosInfo info = new ServiceReference1.AlumnosInfo();
                info.Nombre = textBox2.Text;
                info.ApPaterno = textBox3.Text;
                info.ApMaterno = textBox4.Text;

                if (servicio.CreateAlumno(info) != 0)
                {
                    MessageBox.Show("EXITO!!!");
                }
                else
                {
                    MessageBox.Show("ERROR", "!!!");
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (ServiceReference1.Service1Client servicio = new ServiceReference1.Service1Client())
            {
                cbAlumno.DataSource = servicio.GetAlumnos();
                cbAlumno.DisplayMember = "Nombre";
                cbAlumno.ValueMember = "IDAlumno";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //actualizar // UPDATE
            using (ServiceReference1.Service1Client servicio = new ServiceReference1.Service1Client())
            {
                ServiceReference1.AlumnosInfo info = new ServiceReference1.AlumnosInfo();
                info.IDAlumno = Convert.ToInt32(cbAlumno.SelectedValue);
                info.Nombre = textBox2.Text;
                info.ApPaterno = textBox3.Text;
                info.ApMaterno = textBox4.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //CONSULTAR == READ
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //DELETE == ELIMINAR
        }
    }
}
