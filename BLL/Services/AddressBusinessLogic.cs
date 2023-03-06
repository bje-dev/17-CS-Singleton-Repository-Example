using BLL.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    


    public sealed class AddressBusiness : IGenericBusinessLogic<Address>
    {
            private readonly static AddressBusiness _instance = new AddressBusiness();

        public static AddressBusiness Current
        {
            get
            {
                return _instance;
            }
        }

        private AddressBusiness()
            {
                //Implent here the initialization of your singleton
            }
        



        public void Add(Address obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Address> GetAll()
        {
            throw new NotImplementedException();
        }

        public Address GetOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Address obj)
        {
            throw new NotImplementedException();
        }
    }
}
