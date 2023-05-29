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
    }
}
