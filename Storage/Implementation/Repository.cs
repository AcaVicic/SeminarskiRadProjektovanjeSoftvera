using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementation
{
    public class Repository : IRepository
    {
        private Broker broker = new Broker();
        public void Add(IEntity entity)
        {
            broker.Add(entity);
        }

        public void Update(IEntity entity)
        {
            broker.Update(entity);
        }

        public void Delete(IEntity entity)
        {
            broker.Delete(entity);
        }

        public List<IEntity> GetAll(IEntity e)
        {
            return broker.GetAll(e);
        }

        public void OpenConnection()
        {
            broker.OpenConnection();
        }

        public void CloseConnection()
        {
            broker.CloseConnection();
        }

        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }

        public void Commit()
        {
            broker.Commit();
        }

        public void Rollback()
        {
            broker.Rollback();
        }

        
    }
}
