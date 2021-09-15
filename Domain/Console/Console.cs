using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ConsoleNS
{
    [Serializable]
    public class Console : IEntity
    {
        [Browsable(false)]
        public int Id { get; set; }
        public ConsoleType ConsoleType { get; set; }
        public bool Available { get; set; }
        public double Price { get; set; }
        [Browsable(false)]
        public string TableName => "Console";
        [Browsable(false)]
        public string InsertValues => $"{(int)ConsoleType}, {Convert.ToInt32(Available)}, {Price}";
        [Browsable(false)]
        public string SetCondition => $"ConsoleId = {Id}";
        [Browsable(false)]
        public string SetValue => $"Available = {Convert.ToInt32(Available)}, Price = {Price}";
        [Browsable(false)]
        public string WhereCondition => "";
        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public string OrderBy => "Price asc";
        [Browsable(false)]
        public string IdName { get; set; } = "ConsoleId";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Console
                {
                    Id = reader.GetInt32(0),
                    ConsoleType = (ConsoleType)reader.GetInt32(1),
                    Available = reader.GetBoolean(2),
                    Price = reader.GetDouble(3)
                });
            }
            return result;
        }
    }
}
