﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Customer
{
    public class Company : Customer
    {
        public string TaxNumber { get; set; }
        public string CompanyName { get; set; }
    }
}
