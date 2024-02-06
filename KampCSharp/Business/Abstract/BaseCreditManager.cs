using Entities.Concrete.Credit;
using Entities.Concrete.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public abstract class BaseCreditManager : ICreditManager
    {
        public virtual double CalculateMonthlyPaymentAmount(BaseCredit baseCredit)
        {
            double monthlyInterestRate = baseCredit.AnnualInterestRate / 12 / 100; // Yıllık faiz oranı

            // Aylık ödeme miktarı
            double monthlyPayment = baseCredit.LoanAmount * (monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, baseCredit.LoanTermMonths)) /
                                     (Math.Pow(1 + monthlyInterestRate, baseCredit.LoanTermMonths) - 1);

            return monthlyPayment;
        }

        public abstract void ApplyForCredit(Customer customer);
    }
}
