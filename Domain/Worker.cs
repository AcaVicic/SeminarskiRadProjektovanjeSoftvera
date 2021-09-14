using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Worker : IEntity
    {
        [Browsable(false)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Browsable(false)]
        public string TableName => "Worker";
        [Browsable(false)]
        public string InsertValues => $"'{FirstName}', '{LastName}'";
        [Browsable(false)]
        public string SetCondition => $"WorkerId = {Id}";
        [Browsable(false)]
        public string SetValue => "";
        [Browsable(false)]
        public string WhereCondition => "";
        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public string OrderBy => "FirstName asc, LastName asc";
        [Browsable(false)]
        public string IdName { get; set; } = "WorkerId";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Worker
                {
                    Id = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                });
            }
            return result;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
