using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        private static List<Instructor> _instructors = new List<Instructor>();
        public void Add(Instructor ınstructor)
        {
            _instructors.Add(ınstructor);
        }

        public List<Instructor> GetAll(Func<Instructor, bool>? filter = null)
        {
            return filter == null
                ? _instructors
                : _instructors.Where(filter).ToList();
        }

        public Instructor Get(Func<Instructor, bool> filter)
        {
            return _instructors.SingleOrDefault(filter);
        }
    }
}
