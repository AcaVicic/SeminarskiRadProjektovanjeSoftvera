using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.AddAppointmentSO
{
    public class AddAppointmentSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            repository.AddComplex(entity);
        }
    }
}
