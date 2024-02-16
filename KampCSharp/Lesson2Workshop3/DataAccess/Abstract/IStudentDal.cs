using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IStudentDal
    {
        void Add(Student student);
        Student Get(Func<Student, bool> filter);
        List<Student> GetAll(Func<Student, bool>? filter = null);
    }
}
