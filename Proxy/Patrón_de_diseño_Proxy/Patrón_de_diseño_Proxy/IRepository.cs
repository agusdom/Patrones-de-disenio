using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_de_diseño_Proxy
{
    public interface IRepository
    {
        IList<Customer> GetAll();

        void Save(Customer customer);
    }
}
