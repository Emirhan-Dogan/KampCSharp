using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Credit
{
    public class BaseCredit
    {
        public double LoanAmount { get; set; }
        public int LoanTermMonths { get; set; }
        public double AnnualInterestRate { get; set; }
    }
}
