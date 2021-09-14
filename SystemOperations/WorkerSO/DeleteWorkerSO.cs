﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.WorkerSO
{
    public class DeleteWorkerSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            repository.Delete(entity);
        }
    }
}
