using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Client : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string TableName => "Client";

        public string InsertValues => throw new NotImplementedException();

        public string SetCondition => throw new NotImplementedException();

        public string SetValue => throw new NotImplementedException();

        public string WhereCondition => throw new NotImplementedException();

        public string Join => throw new NotImplementedException();

        public string OrderBy => throw new NotImplementedException();

        public string IdName { get; set; } = "ClientId";

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
