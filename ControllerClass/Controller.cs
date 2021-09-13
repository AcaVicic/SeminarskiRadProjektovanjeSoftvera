using Domain;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerClass
{
    public class Controller
    {
        private static Controller instance;

        public static Controller Instance
        {
            get
            {
                if (instance == null)
                    instance = new Controller();
                return instance;
            }
        }

        private Controller()
        {

        }

        public Owner Login(object ownerObject)
        {
            Owner owner = (Owner)ownerObject;

            if(StorageOwnerInMemory.Owners.Any(o => o.Username == owner.Username && o.Password == owner.Password))
            {
                return owner;
            }
            return null;
        }
    }
}
