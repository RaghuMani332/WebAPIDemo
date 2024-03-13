using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Models.Repositary.Imp;
using WebAPIDemo.Models.Repositary.Interfaces;
using WebAPIDemo.Models.Service.Interfaces;
using WebAPIDemo.Models;

namespace WebAPIDemo.Models.Service.Imp
{
    public class ShirtService : IShirt
    {
        IshirtRepo shirtRepo = new ShirtRepoImpl();

        public List<Shirt> CreateShirt(Shirt shirt)
        {
           return shirtRepo.CreateShirt(shirt);
        }

        public bool DeleteShirt(int id)
        {
            return shirtRepo.DeleteShirt(id);
        }

        public List<Shirt> GetAllShirt()
        {
            return shirtRepo.GetAllShirt();
        }

        public Shirt GetShirtById(int id)
        {
            return shirtRepo.GetShirtById(id);
        }

        public Shirt UpdateShirt(Shirt shirt)
        {
            return shirtRepo.UpdateShirt(shirt);
        }
    }
}
