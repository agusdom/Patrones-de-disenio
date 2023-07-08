using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_de_diseño_Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IRepository repo = new CustomerRepositoryProxy();

                Session.CanSave = true;
                Session.CanGetAll = true;

                Customer p1 = new Customer("Customer 1");
                Customer p2 = new Customer("Customer 2");

                repo.Save(p1);
                repo.Save(p2);

                foreach (Customer c in repo.GetAll())
                {
                    Console.WriteLine($"{c._name}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
    Console.ReadKey();
        }
    }
}
