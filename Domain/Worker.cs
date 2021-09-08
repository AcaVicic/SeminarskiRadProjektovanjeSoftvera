using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Worker : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TableName => "Worker";

        public string InsertValues => $"'{FirstName}', '{LastName}'";

        public string SetCondition => throw new NotImplementedException();

        public string SetValue => throw new NotImplementedException();

        public string WhereCondition => throw new NotImplementedException();

        public string Join => throw new NotImplementedException();

        public string OrderBy => throw new NotImplementedException();

        public string IdName { get; set; } = "WorkerId";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
