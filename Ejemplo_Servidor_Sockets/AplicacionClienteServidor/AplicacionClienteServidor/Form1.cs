using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Importamos las librerias de red
using System.Net;
using System.Net.Sockets;

namespace AplicacionClienteServidor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Lisen();

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Writer();
        }

        public void Lisen()
        {

            //el tipo de ip              //que datos       // protocolo
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Creamos el socket
            IPEndPoint IP = new IPEndPoint(IPAddress.Any, 4321);
            //IPAddress.Any escuchara al cliente en toda la red

            try
            {
                //paso 4
                socket.Bind(IP); //socket a la IP
                socket.Listen(1); //lo ponemos a escuchar de un cliente
                //determinamos el tamanio de los clientes conectados

                MessageBox.Show("Lisen...", "!!!!!!!");
                Socket conexion = socket.Accept();

                /* creamos el nuevo socket, para comensar a trabajar con el
                 la aplicacion queda en reposo hasta que el socket se conecte a el cliente
                 una vez conectadom, la aplicacion sique su camino*/

                MessageBox.Show("Exito!!", "!!!!!!!");

                byte[] info = new byte[100];
                string data = "";
                int tamanio = 0;

                tamanio = conexion.Receive(info, 0, info.Length, 0);
                Array.Resize(ref info, tamanio);


                /**/
                data = Encoding.UTF8.GetString(info);

                txtbxSala.Text = data;
            }
            catch (Exception error)
            {
                txtbxSala.Text = error.ToString();
            }
            MessageBox.Show("Mensaje recibido");

        }


        public void Writer()
        {
            /*CLIENTE*/
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint IP = new IPEndPoint(IPAddress.Parse("192.168.43.251"), 4321);
            //Ip del Servidor, y el puerto
            //Se corre en la misma computadora

            try {
                socket.Connect(IP);//conexion
                byte[] info = new byte[100];
                string data = "";
                data = txtbxMM.Text;

                info = Encoding.UTF8.GetBytes(data);

                socket.Send(info);
            } catch(Exception error) {
                MessageBox.Show("Error {0}" + error.ToString(), "!!!!");
            }

        }
    }
}
