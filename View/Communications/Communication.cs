using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Sockets;
using System.Text;
using View.Exceptions;

namespace View.Communications
{
    public class Communication
    {
        public SenderAndReceiver SenderAndReceiver { get; set; }
        private static Communication instance;
        private Socket socket;

        public static Communication Instance
        {
            get
            {
                if (instance == null)
                    instance = new Communication();
                return instance;
            }
        }

        private Communication()
        {

        }

        internal void Connect()
        {
            if (socket != null && socket.Connected)
            {
                return;
            }
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(ConfigurationManager.AppSettings["ip"], Int32.Parse(ConfigurationManager.AppSettings["port"]));
            SenderAndReceiver = new SenderAndReceiver(socket);
        }

        internal void Disconnect()
        {
            socket.Close();
            socket = null;
        }

        internal object Login(Owner owner)
        {
            Request request = new Request
            {
                Operation = Operation.Login,
                RequestObject = owner
            };

            SenderAndReceiver.Send(request);
            Response response = SenderAndReceiver.Receive() as Response;

            if (response.IsSuccessful)
                return response.Result;
            else
                throw new LoginException("Username or password is wrong!");
        }
    }
}
