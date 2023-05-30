using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class RentACarRepository : IRentACarRepository
    {
        public Category CreateCategory(Category category)
        {
            using (var dbcontext = new RentACarContext())
            {
                dbcontext.Categories.Add(category);
                dbcontext.SaveChanges();
                return category;
            }
        }

        public void DeleteCategory(int id)
        {
            using (var dbcontext = new RentACarContext())
            {
                var deletecategory = GetById(id);
                dbcontext.Categories.Remove(deletecategory);
                dbcontext.SaveChanges();
            }
        }

        public List<Category> GetAll()
        {
            using (var dbcontext=new RentACarContext())
            {
                return dbcontext.Categories.ToList();
            }
        }

        public Category GetById(int id)
        {
            using (var dbcontext = new RentACarContext())
            {
                return dbcontext.Categories.Find(id);
            }
        }

        public Category UpdateCategory(Category category)
        {
            using (var dbcontext = new RentACarContext())
            {
                dbcontext.Categories.Update(category);
                dbcontext.SaveChanges();
                return category;
            }
        }
    }
}
