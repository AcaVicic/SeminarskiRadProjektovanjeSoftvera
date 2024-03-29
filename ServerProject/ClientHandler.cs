﻿using Common;
using ControllerClass;
using Domain;
using Console = Domain.ConsoleNS.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerProject
{
    public class ClientHandler
    {
        private Socket client;
        private Server server;
        private SenderAndReceiver senderAndReceiver;

        public ClientHandler(Socket client, Server server)
        {
            this.client = client;
            this.server = server;
            senderAndReceiver = new SenderAndReceiver(client);
        }

        internal void Listen()
        {
            try
            {
                while (true)
                {
                    Response response;
                    try
                    {
                        Request request = senderAndReceiver.Receive() as Request;
                        response = OperationHandler(request);
                    }
                    catch (Exception ex)
                    {
                        response = new Response() { IsSuccessful = false, Error = ex.Message };

                    }
                    senderAndReceiver.Send(response);
                }
            }
            catch (Exception)
            {

            }
        }

        private Response OperationHandler(Request request)
        {
            Response response;
            switch (request.Operation)
            {
                case Operation.Login:
                    Owner o = Controller.Instance.Login(request.RequestObject);
                    if (o != null)
                    {
                        response = new Response
                        {
                            IsSuccessful = true,
                            Result = o
                        };
                    }
                    else
                    {
                        response = new Response
                        {
                            IsSuccessful = false
                        };
                    }
                    return response;
                case Operation.AddWorker:
                    Controller.Instance.AddWorker((Worker)request.RequestObject);
                    return response = new Response() { IsSuccessful = true };
                case Operation.FindWorkers:
                    List<Worker> workers = Controller.Instance.FindWorkers(request.RequestObject.ToString());
                    return response = new Response() { IsSuccessful = true, Result = workers };
                case Operation.DeleteWorker:
                    Controller.Instance.DeleteWorker((Worker)request.RequestObject);
                    return response = new Response() { IsSuccessful = true };
                case Operation.AddClient:
                    Controller.Instance.AddClient((Client)request.RequestObject);
                    return response = new Response() { IsSuccessful = true };
                case Operation.FindClients:
                    List<Client> clients = Controller.Instance.FindClients(request.RequestObject.ToString());
                    return response = new Response() { IsSuccessful = true, Result = clients };
                case Operation.DeleteClient:
                    Controller.Instance.DeleteClient((Client)request.RequestObject);
                    return response = new Response() { IsSuccessful = true };
                case Operation.AddConsole:
                    Controller.Instance.AddConsole((Console)request.RequestObject);
                    return response = new Response() { IsSuccessful = true };
                case Operation.FindConsoles:
                    List<Console> consoles = Controller.Instance.FindConsoles((int)request.RequestObject);
                    return response = new Response() { IsSuccessful = true, Result = consoles };
                case Operation.UpdateConsole:
                    Controller.Instance.UpdateConsole((Console)request.RequestObject);
                    return response = new Response() { IsSuccessful = true };
                case Operation.DeleteConsole:
                    Controller.Instance.DeleteConsole((Console)request.RequestObject);
                    return response = new Response() { IsSuccessful = true };
                case Operation.GetAllAvailableConsoles:
                    List<Console> availableConsoles = Controller.Instance.GetAllAvailableConsoles();
                    return response = new Response() { IsSuccessful = true, Result = availableConsoles };
                case Operation.GetAllClients:
                    List<Client> clients1 = Controller.Instance.GetAllClients();
                    return response = new Response() { IsSuccessful = true, Result = clients1 };
                case Operation.GetAllWorkers:
                    List<Worker> workers1 = Controller.Instance.GetAllWorkers();
                    return response = new Response() { IsSuccessful = true, Result = workers1 };
                case Operation.AddAppointment:
                    Controller.Instance.AddAppointment((Appointment)request.RequestObject);
                    return response = new Response() { IsSuccessful = true };
                case Operation.AddConsoleTesting:
                    Controller.Instance.AddConsoleTesting((ConsoleTesting)request.RequestObject);
                    return response = new Response() { IsSuccessful = true };
            }
            throw new Exception("Operation doesn't exist!");
        }

        internal void Close()
        {
            client.Close();
        }
    }
}
