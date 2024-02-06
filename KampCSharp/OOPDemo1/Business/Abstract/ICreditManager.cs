using Entities.Concrete.Credit;
using Entities.Concrete.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICreditManager
    {
        double CalculateMonthlyPaymentAmount(BaseCredit baseCredit);
        void ApplyForCredit(Customer customer);
    }
}
