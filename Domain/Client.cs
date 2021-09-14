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
    public class Client : IEntity
    {
        [Browsable(false)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Browsable(false)]
        public DateTime DateOfBirth { get; set; }
        public string BirthDate => DateOfBirth.ToString("dd.MM.yyyy.");
        [Browsable(false)]
        public string TableName => "Client";
        [Browsable(false)]
        public string InsertValues => $"'{FirstName}', '{LastName}', '{DateOfBirth:yyyy-MM-dd}'";
        [Browsable(false)]
        public string SetCondition => $"ClientId = {Id}";
        [Browsable(false)]
        public string SetValue => "";
        [Browsable(false)]
        public string WhereCondition => "";
        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public string OrderBy => "FirstName asc, LastName asc";
        [Browsable(false)]
        public string IdName { get; set; } = "ClientId";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Client
                {
                    Id = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    DateOfBirth = reader.GetDateTime(3)
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
