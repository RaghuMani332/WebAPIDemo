using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Models;

namespace WebAPIDemo.Models.Service.Interfaces
{
    public interface IShirt
    {
        public List<Shirt> CreateShirt(Shirt shirt);
        public Shirt GetShirtById(int id);
        public Shirt UpdateShirt(Shirt shirt);
        public List<Shirt> GetAllShirt();
        public bool DeleteShirt(int id);

    }
}
