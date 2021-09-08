using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Appointment : IEntity
    {
        public DateTime AppointmentDate { get; set; }
        public Client Client { get; set; }
        public ConsoleNS.Console Console { get; set; }
        public DateTime EndOfAppointment { get; set; }
        public int Discount { get; set; }
        public Worker Worker { get; set; }

        public string TableName => "Appointment";

        public string InsertValues => throw new NotImplementedException();

        public string SetCondition => throw new NotImplementedException();

        public string SetValue => throw new NotImplementedException();

        public string WhereCondition => throw new NotImplementedException();

        public string Join => throw new NotImplementedException();

        public string OrderBy => throw new NotImplementedException();

        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string IdName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
