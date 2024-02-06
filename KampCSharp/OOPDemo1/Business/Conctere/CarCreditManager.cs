using Business.Abstract;
using Entities.Concrete.Credit;
using Entities.Concrete.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Conctere
{
    public class CarCreditManager : BaseCreditManager, ICreditManager
    {
        public override void ApplyForCredit(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + "Araba kerdi başvurusu alındı.");
        }
    }
}
