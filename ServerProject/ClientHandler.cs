using Common;
using ControllerClass;
using Domain;
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
            }
            throw new Exception("Operation doesn't exist!");
        }

        internal void Close()
        {
            client.Close();
        }
    }
}
