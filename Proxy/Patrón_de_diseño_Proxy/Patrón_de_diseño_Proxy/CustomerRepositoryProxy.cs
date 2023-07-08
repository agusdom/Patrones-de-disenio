using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_de_diseño_Proxy
{
    public class CustomerRepositoryProxy : IRepository
    {
        IRepository _real;

        public IList<Customer> GetAll()
        {
           if (_real == null)
            {
                _real = new CustomerRepository();
            }
            if (Session.CanGetAll)
            {
                return _real.GetAll();
            }
            else
            {
                throw new UnauthorizedAccessException();
            }
        }

        public void Save(Customer customer)
        {
            if (_real == null)
            {
                _real = new CustomerRepository();
            }
            if (Session.CanGetAll)
            {
                _real.Save(customer);
            }
            else
            {
                throw new UnauthorizedAccessException();
            }
        }
    }
}
