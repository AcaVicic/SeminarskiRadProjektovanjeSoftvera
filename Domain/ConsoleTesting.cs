using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class ConsoleTesting : IEntity
    {
        public Worker Worker { get; set; }
        public ConsoleNS.Console Console { get; set; }
        public DateTime DateOfTesting { get; set; }
        public string TableName => "ConsoleTesting";

        public string InsertValues => $"{Worker.Id}, {Console.Id}, '{DateOfTesting:yyyy-MM-dd}'";

        public string SetCondition => "";

        public string SetValue => "";

        public string WhereCondition => "";

        public string Join => "";

        public string OrderBy => "";

        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string IdName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
