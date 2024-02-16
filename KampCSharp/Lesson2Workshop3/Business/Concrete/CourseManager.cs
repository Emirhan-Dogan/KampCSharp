using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            this._courseDal = courseDal;
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public List<Course> GetAllByCategory(int categoryId)
        {
            return _courseDal.GetAll(C => C.CategoryId == categoryId);
        }

        public Course GetById(int id)
        {
            return _courseDal.Get(C => C.Id == id);
        }
    }
}
