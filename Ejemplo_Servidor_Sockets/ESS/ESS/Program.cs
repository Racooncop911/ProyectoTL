using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//referencias a sockets
using System.Net;
using System.Net.Sockets;

namespace ESS
{
    class Program
    {
        static void Main(string[] args)
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

                Console.WriteLine("Escuchando...");
                Socket conexion = socket.Accept();

                /* creamos el nuevo socket, para comensar a trabajar con el
                 la aplicacion queda en reposo hasta que el socket se conecte a el cliente
                 una vez conectadom, la aplicacion sique su camino*/
                    
                Console.WriteLine("Conexion Exitosa!!");

                byte[] info = new byte[100];
                string data = "";
                int tamanio = 0;

                tamanio = conexion.Receive(info, 0, info.Length, 0);
                Array.Resize(ref info, tamanio);


                /**/
                data = Encoding.UTF8.GetString(info);
                Console.WriteLine("Info Recibida: {0}", data);

            }
            catch (Exception error)
            {
                Console.WriteLine("Error: {0}", error.ToString());
            }

            Console.WriteLine("Presione cualquier termino para terminar...");
            Console.ReadLine();

        }
    }
}
