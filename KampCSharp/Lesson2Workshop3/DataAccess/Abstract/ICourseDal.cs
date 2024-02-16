using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICourseDal
    {
        void Add(Course course);
        Course Get(Func<Course, bool> filter);
        List<Course> GetAll(Func<Course, bool>? filter = null);
    }
}
