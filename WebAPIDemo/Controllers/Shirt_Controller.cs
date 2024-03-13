using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Models.Service.Imp;
using WebAPIDemo.Models.Service.Interfaces;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    [ApiController]
    [Route("api/shirt")]
    public class ShirtController:ControllerBase
    {
        

        IShirt shirtService = new ShirtService();

        [HttpPut]
        public List<Shirt> CreateShirt([FromBody] Shirt shirt)
        {
            
            return shirtService.CreateShirt(shirt);
        }
        [HttpDelete("{id}")]
        public bool DeleteShirt(int id)
        {
            return shirtService.DeleteShirt(id);
        }
        [HttpGet]
        public List<Shirt> GetAllShirt()
        {
            return shirtService.GetAllShirt();
        }
        [HttpGet("{id}")]
        public Shirt GetShirtById(int id)
        {
            return shirtService.GetShirtById(id);
        }
        [HttpPost]
        public Shirt UpdateShirt(Shirt shirt)
        {
            return shirtService.UpdateShirt(shirt);
        }
    }
}
