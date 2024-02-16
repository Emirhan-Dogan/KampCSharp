using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IInstructorDal
    {
        void Add(Instructor ınstructor);
        Instructor Get(Func<Instructor, bool> filter);
        List<Instructor> GetAll(Func<Instructor, bool>? filter = null);
    }
}
