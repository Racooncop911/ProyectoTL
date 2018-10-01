using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//referencias de cliente-socket
using System.Net;           
using System.Net.Sockets;

namespace ClienteCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint IP = new IPEndPoint(IPAddress.Parse("192.168.43.251"), 4321);
            //Ip del Servidor, y el puerto
            //Se corre en la misma computadora
            try
            {
                socket.Connect(IP);//conexion
                byte[] info = new byte[100];
                string data = "";
                Console.WriteLine("Info a Enviar:  ");
                data = Console.ReadLine();

                info = Encoding.UTF8.GetBytes(data);

                socket.Send(info);

            }
            catch (Exception error)
            {
                Console.WriteLine("Error: {0}", error.ToString());

            }
            Console.WriteLine("Presione cualquier tecla para terminar...");
            Console.ReadLine();

        }

    }
}
