using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ClientSO
{
    public class GetAllClientsSO : SystemOperationBase
    {
        public List<Client> Clients { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Clients = repository.GetAll(entity).Cast<Client>().ToList();
        }
    }
}
