using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class StudentDal : IStudentDal
    {
        private static List<Student> _students = new List<Student>();

        public void Add(Student student)
        {
            _students.Add(student);
        }

        public List<Student> GetAll(Func<Student, bool>? filter = null)
        {
            return filter == null
                ? _students
                : _students.Where(filter).ToList();
        }

        public Student Get(Func<Student, bool> filter)
        {
            return _students.SingleOrDefault(filter);
        }
    }
}
