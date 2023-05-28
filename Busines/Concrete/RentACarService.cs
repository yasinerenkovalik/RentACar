using Busines.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines.Concrete
{
    public class RentACarService : IRentACarService
    {
        private IRentACarRepository _service;
        public RentACarService()
        {
            _service = new RentACarRepository();
        }
        public Category CreateCategory(Category category)
        {
            return _service.CreateCategory(category);
        }

        public void DeleteCategory(int id)
        {
            _service.DeleteCategory(id);
        }

        public List<Category> GetAll()
        {
            return _service.GetAll();
        }

        public Category GetById(int id)
        {
            return _service.GetById(id);
        }

        public Category UpdateCategory(Category category)
        {
            return _service.UpdateCategory(category);
        }
    }
}
