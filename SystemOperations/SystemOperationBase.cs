using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage;
using Storage.Implementation;

namespace SystemOperations
{
    public abstract class SystemOperationBase
    {
        protected IRepository repository = new Repository();

        public void ExecuteTemplate(IEntity entity)
        {
            try
            {
                repository.OpenConnection();
                repository.BeginTransaction();
                ExecuteOperation(entity);
                repository.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                repository.Rollback();
                throw;
            }
            finally
            {
                repository.CloseConnection();
            }
        }

        protected abstract void ExecuteOperation(IEntity entity);
    }
}
