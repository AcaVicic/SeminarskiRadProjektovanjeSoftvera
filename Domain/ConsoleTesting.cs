﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ConsoleTesting : IEntity
    {
        public Worker Worker { get; set; }
        public ConsoleNS.Console Console { get; set; }
        public DateTime DateOfTesting { get; set; }
        public string TableName => "ConsoleTesting";

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
