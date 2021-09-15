using Domain;
using Console = Domain.ConsoleNS.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ConsoleSO
{
    public class GetAllConsolesSO : SystemOperationBase
    {
        public List<Console> Consoles { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Consoles = repository.GetAll(entity).Cast<Console>().ToList();
        }
    }
}
