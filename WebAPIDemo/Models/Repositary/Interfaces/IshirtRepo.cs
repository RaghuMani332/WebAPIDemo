using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Models;

namespace WebAPIDemo.Models.Repositary.Interfaces
{
    public interface IshirtRepo
    {
        public List<Shirt> CreateShirt(Shirt shirt);
        public Shirt GetShirtById(int id);
        public Shirt UpdateShirt(Shirt shirt);
        public List<Shirt> GetAllShirt();
        public bool DeleteShirt(int id);
    }
}
