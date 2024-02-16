using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        // Veritabanında Categories tablosu.
        private static List<Category> _categories = new List<Category>()
        {
            new Category(){Id = 1, Name = "Backend", Description = "Backend programlama", Status = true},
            new Category(){Id = 2, Name = "Frontend", Description = "Frontend programlama", Status = true},
            new Category(){Id = 3, Name = "Mobil", Description = "Mobil programlama", Status = true},
            new Category(){Id = 4, Name = "Gömülü Sistem", Description = "Gömülü Sistem", Status = true}
        };
        public List<Category> GetAll()
        {
            return _categories;
        }

        public Category GetById(int id)
        {
            return _categories.SingleOrDefault(C => C.Id == id);
        }
    }
}
