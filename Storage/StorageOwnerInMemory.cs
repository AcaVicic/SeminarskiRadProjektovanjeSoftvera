using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class StorageOwnerInMemory
    {
        public static List<Owner> Owners { get; set; }
        static StorageOwnerInMemory()
        {
            Owners = new List<Owner>
            {
                new Owner
                {
                    Username = "Vica98",
                    Password = "123"
                }
            };
        }
    }
}
