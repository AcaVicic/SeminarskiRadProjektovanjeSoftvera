using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ConsoleNS
{
    [Serializable]
    public class Console : IEntity
    {
        public int Id { get; set; }
        public ConsoleType ConsoleType { get; set; }
        public bool Free { get; set; }
        public double Price { get; set; }
        
        public string TableName => "Console";

        public string InsertValues => throw new NotImplementedException();

        public string SetCondition => throw new NotImplementedException();

        public string SetValue => throw new NotImplementedException();

        public string WhereCondition => throw new NotImplementedException();

        public string Join => throw new NotImplementedException();

        public string OrderBy => throw new NotImplementedException();

        public string IdName { get; set; } = "ConsoleId";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
