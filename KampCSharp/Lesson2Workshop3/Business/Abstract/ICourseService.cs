using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {
        Course GetById(int id);
        List<Course> GetAll();
        List<Course> GetAllByCategory(int categoryId);
        void Add(Course course);
    }
}
