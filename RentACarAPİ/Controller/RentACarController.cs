using Busines.Abstract;
using Busines.Concrete;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RentACarAPİ.Controller
{
    [Route("api/merhaba")]
    [ApiController]
    public class RentACarController : ControllerBase
    {
        private IRentACarService _service;
        public RentACarController()
        {
            _service = new RentACarService();
        }
        [HttpGet]
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
