using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public interface IRepository
    {
        void Add(IEntity entity);
        void AddComplex(IEntity entity);
        void Delete(IEntity entity);
        void Update(IEntity entity);
        List<IEntity> GetAll(IEntity e);

        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
