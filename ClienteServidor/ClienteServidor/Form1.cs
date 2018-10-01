using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ClienteServidor
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
             
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Creamos el socket
            IPEndPoint IP = new IPEndPoint(IPAddress.Any, 1234);
            //IpAddress.Any escuchara al cliente en toda la red
            try
            {
                socket.Bind(IP); // SOCKET A LA IP
                socket.Listen(2); // lo  ponemos a escucha de un cliente (tamaño limite de clientes)
                textBox1.Text = "Escuchando";
                Socket conexion = socket.Accept();
                textBox1.Text = "conectado con exito";
                byte[] info = new byte[100];
                string data = "";
                int tamaño = 0;

                tamaño = conexion.Receive(info, 0, info.Length, 0);
                Array.Resize(ref info, tamaño);

                data = Encoding.UTF8.GetString(info);
                textBox1.Text = "Info recibida: " + data;
                socket.Close();
            }

            catch (Exception error)
            {
                MessageBox.Show("Error: {0}", error.ToString());

            }
            MessageBox.Show("recivido");
            
            // Console.WriteLine("Presione cualquier tecla para terminar");
            // Console.ReadLine();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint IP = new IPEndPoint(IPAddress.Parse("192.168.1.77"), 1234);
            try
            {
                socket.Connect(IP);
                Console.WriteLine("Conectado con exito");
                byte[] info = new byte[100];
                string data = textBox2.Text;
                info = Encoding.UTF8.GetBytes(data);
                socket.Send(info);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: {0}", error.ToString());
            }
            MessageBox.Show("enviado");
            socket.Close();
        }
    }
}
