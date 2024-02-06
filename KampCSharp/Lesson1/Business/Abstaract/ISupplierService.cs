using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstaract
{
    public interface ISupplierService<T>
    {
        void GiveMask(T applicant);
    }
}
