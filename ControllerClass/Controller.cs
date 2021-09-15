using Domain;
using Console = Domain.ConsoleNS.Console;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations.ClientSO;
using SystemOperations.WorkerSO;
using SystemOperations.ConsoleSO;
using SystemOperations.AddAppointmentSO;
using SystemOperations.ConsoleTestingSO;

namespace ControllerClass
{
    public class Controller
    {
        private static Controller instance;

        public static Controller Instance
        {
            get
            {
                if (instance == null)
                    instance = new Controller();
                return instance;
            }
        }

        private Controller()
        {

        }

        public Owner Login(object ownerObject)
        {
            Owner owner = (Owner)ownerObject;

            if(StorageOwnerInMemory.Owners.Any(o => o.Username == owner.Username && o.Password == owner.Password))
            {
                return owner;
            }
            return null;
        }

        public void AddWorker(Worker worker)
        {
            AddWorkerSO add = new AddWorkerSO();
            add.ExecuteTemplate(worker);
        }

        public List<Worker> FindWorkers(string searchText)
        {
            Worker worker = new Worker();
            GetAllWorkersSO getAll = new GetAllWorkersSO();
            getAll.ExecuteTemplate(worker);

            return getAll.Workers.Where(w => w.ToString().Contains(searchText)).ToList();
        }

        public void DeleteWorker(Worker worker)
        {
            DeleteWorkerSO delete = new DeleteWorkerSO();
            delete.ExecuteTemplate(worker);
        }

        public void AddClient(Client client)
        {
            AddClientSO add = new AddClientSO();
            add.ExecuteTemplate(client);
        }

        public List<Client> FindClients(string searchText)
        {
            Client client = new Client();
            GetAllClientsSO getAll = new GetAllClientsSO();
            getAll.ExecuteTemplate(client);

            return getAll.Clients.Where(c => c.ToString().Contains(searchText)).ToList();
        }

        public void DeleteClient(Client client)
        {
            DeleteClientSO delete = new DeleteClientSO();
            delete.ExecuteTemplate(client);
        }

        public void AddConsole(Console console)
        {
            AddConsoleSO add = new AddConsoleSO();
            add.ExecuteTemplate(console);
        }

        public List<Console> FindConsoles(int consoleType)
        {
            Console console = new Console();
            GetAllConsolesSO getAll = new GetAllConsolesSO();
            getAll.ExecuteTemplate(console);

            return getAll.Consoles.Where(c => (int)c.ConsoleType == consoleType).ToList();
        }

        public void UpdateConsole(Console console)
        {
            UpdateConsoleSO update = new UpdateConsoleSO();
            update.ExecuteTemplate(console);
        }

        public void DeleteConsole(Console console)
        {
            DeleteConsoleSO delete = new DeleteConsoleSO();
            delete.ExecuteTemplate(console);
        }

        public List<Console> GetAllAvailableConsoles()
        {
            Console console = new Console
            {
                WhereCondition = "Available = 1"
            };
            GetAllConsolesSO getAll = new GetAllConsolesSO();
            getAll.ExecuteTemplate(console);

            return getAll.Consoles;
        }

        public List<Client> GetAllClients()
        {
            Client client = new Client();
            GetAllClientsSO getAll = new GetAllClientsSO();
            getAll.ExecuteTemplate(client);

            return getAll.Clients;
        }

        public List<Worker> GetAllWorkers()
        {
            Worker worker = new Worker();
            GetAllWorkersSO getAll = new GetAllWorkersSO();
            getAll.ExecuteTemplate(worker);

            return getAll.Workers;
        }

        public void AddAppointment(Appointment appointment)
        {
            AddAppointmentSO add = new AddAppointmentSO();
            add.ExecuteTemplate(appointment);

            appointment.Console.Available = false;
            UpdateConsoleSO update = new UpdateConsoleSO();
            update.ExecuteTemplate(appointment.Console);
        }

        public void AddConsoleTesting(ConsoleTesting consoleTesting)
        {
            AddConsoleTestingSO add = new AddConsoleTestingSO();
            add.ExecuteTemplate(consoleTesting);

            consoleTesting.Console.Available = false;
            UpdateConsoleSO update = new UpdateConsoleSO();
            update.ExecuteTemplate(consoleTesting.Console);
        }
    }
}
