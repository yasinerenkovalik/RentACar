using Busines.Abstract;
using Busines.Concrete;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RentACarAPİ.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentACarController : ControllerBase
    {
        private IRentACarService _service;
        public RentACarController()
        {
            _service = new RentACarService();
        }
        [HttpGet("getall")]
        public List<Category> GetCategories() {
            return _service.GetAll(); 
        }
        [HttpGet("{id}")]
        public Category GetCategories(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost("create")]
        public Category Create(Category category)
        {
            return _service.CreateCategory(category);
        }

        [HttpPut("update")]
        public Category Update(Category category)
        {
            return _service.UpdateCategory(category);
        }
        [HttpDelete("delete/{id}")]
        public void Delete(int id)
        {
             _service.DeleteCategory(id);
        }
    }
}
