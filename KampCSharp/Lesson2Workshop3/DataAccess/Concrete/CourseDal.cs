using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        // Veritabanında Courses tablosu.
        private static List<Course> _courses = new List<Course>();

        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public List<Course> GetAll(Func<Course, bool>? filter = null)
        {
            return filter == null
                ? _courses
                : _courses.Where(filter).ToList();
        }

        public Course Get(Func<Course, bool> filter)
        {
            return _courses.SingleOrDefault(filter);
        }
    }
}
