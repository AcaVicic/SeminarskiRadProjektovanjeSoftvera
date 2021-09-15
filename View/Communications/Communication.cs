using Common;
using Domain;
using Console = Domain.ConsoleNS.Console;
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

        internal void AddWorker(Worker worker)
        {
            Request request = new Request() { Operation = Operation.AddWorker, RequestObject = worker };

            SenderAndReceiver.Send(request);
            Response response = SenderAndReceiver.Receive() as Response;

            if (!response.IsSuccessful)
                throw new AddException(response.Error);
        }

        internal void AddConsole(Domain.ConsoleNS.Console console)
        {
            Request request = new Request() { Operation = Operation.AddConsole, RequestObject = console };

            SenderAndReceiver.Send(request);
            Response response = SenderAndReceiver.Receive() as Response;

            if (!response.IsSuccessful)
                throw new AddException(response.Error);
        }

        internal void DeleteConsole(Console console)
        {
            Request request = new Request() { Operation = Operation.DeleteConsole, RequestObject = console };

            SenderAndReceiver.Send(request);
            Response response = SenderAndReceiver.Receive() as Response;

            if (!response.IsSuccessful)
                throw new DeleteException(response.Error);
        }

        internal List<Console> FindConsoles(int consoleType)
        {
            Request request = new Request() { Operation = Operation.FindConsoles, RequestObject = consoleType };

            SenderAndReceiver.Send(request);
            Response response = SenderAndReceiver.Receive() as Response;

            if (!response.IsSuccessful)
                throw new Exception(response.Error);

            return response.Result as List<Console>;
        }

        internal void UpdateConsole(Console console)
        {
            Request request = new Request() { Operation = Operation.UpdateConsole, RequestObject = console };

            SenderAndReceiver.Send(request);
            Response response = SenderAndReceiver.Receive() as Response;

            if (!response.IsSuccessful)
                throw new UpdateException(response.Error);
        }

        internal void AddClient(Client client)
        {
            Request request = new Request() { Operation = Operation.AddClient, RequestObject = client };

            SenderAndReceiver.Send(request);
            Response response = SenderAndReceiver.Receive() as Response;

            if (!response.IsSuccessful)
                throw new AddException(response.Error);
        }

        internal List<Client> FindClients(string searchText)
        {
            Request request = new Request() { Operation = Operation.FindClients, RequestObject = searchText };

            SenderAndReceiver.Send(request);
            Response response = SenderAndReceiver.Receive() as Response;

            if (!response.IsSuccessful)
                throw new Exception(response.Error);

            return response.Result as List<Client>;
        }

        internal List<Worker> FindWorkers(string searchText)
        {
            Request request = new Request() { Operation = Operation.FindWorkers, RequestObject = searchText };

            SenderAndReceiver.Send(request);
            Response response = SenderAndReceiver.Receive() as Response;

            if (!response.IsSuccessful)
                throw new Exception(response.Error);

            return response.Result as List<Worker>;
        }

        internal void DeleteClient(Client client)
        {
            Request request = new Request() { Operation = Operation.DeleteClient, RequestObject = client };

            SenderAndReceiver.Send(request);
            Response response = SenderAndReceiver.Receive() as Response;

            if (!response.IsSuccessful)
                throw new DeleteException(response.Error);
        }

        internal void DeleteWorker(Worker worker)
        {
            Request request = new Request() { Operation = Operation.DeleteWorker, RequestObject = worker };

            SenderAndReceiver.Send(request);
            Response response = SenderAndReceiver.Receive() as Response;

            if (!response.IsSuccessful)
                throw new DeleteException(response.Error);
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
