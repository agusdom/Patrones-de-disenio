using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_de_diseño_Proxy
{
    public class CustomerRepository : IRepository
    {
        IList<Customer> _costumer;

        public CustomerRepository()
        {
            _costumer = new List<Customer>();
        }

        public IList<Customer> GetAll()
        {
            return _costumer;
        }

        public void Save(Customer customer)
        {
            _costumer.Add(customer);
        }

    }
}
