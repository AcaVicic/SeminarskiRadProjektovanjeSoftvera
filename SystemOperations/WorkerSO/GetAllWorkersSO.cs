using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.WorkerSO
{
    public class GetAllWorkersSO : SystemOperationBase
    {
        public List<Worker> Workers { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Workers = repository.GetAll(entity).Cast<Worker>().ToList();
        }
    }
}
