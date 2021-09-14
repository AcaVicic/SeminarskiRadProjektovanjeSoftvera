﻿using Domain;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations.WorkerSO;

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
    }
}
