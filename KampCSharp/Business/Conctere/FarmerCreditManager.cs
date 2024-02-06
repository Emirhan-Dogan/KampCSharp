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
    public class FarmerCreditManager : BaseCreditManager, ICreditManager
    {
        public override double CalculateMonthlyPaymentAmount(BaseCredit baseCredit)
        {
            FarmerCredit farmerCredit = baseCredit as FarmerCredit;

            // çiftçilerle ilgili özel işlemler.
            // örneğim çiftçiler için mevsimsel olarak ödeme geciktirilebilsin.
            if (farmerCredit.SeasonalPaymentDeferred)
            {
                return 0;
            }

            double monthlyPayment = base.CalculateMonthlyPaymentAmount(farmerCredit);

            return monthlyPayment;
        }

        public override void ApplyForCredit(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + "Çiftçi kerdi başvurusu alındı.");
        }
    }
}
