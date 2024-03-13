using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Linq;
using WebAPIDemo.Models.Repositary.Interfaces;
using WebAPIDemo.Models;

namespace WebAPIDemo.Models.Repositary.Imp
{
    public class ShirtRepoImpl : IshirtRepo
    {
        private List<Shirt> shirts = new List<Shirt>
        {
            new Shirt{ShirtId=101,Brand="OTTO",Size=8,Gender="MEN",Price=1000},
            new Shirt{ShirtId=102,Brand="PLATO",Size=10,Gender="MEN",Price=1100},
            new Shirt{ShirtId=103,Brand="OTTO",Size=12,Gender="WOMEN",Price=1200}

        };
        public List<Shirt> CreateShirt(Shirt shirt)
        {
           var a= shirts.FirstOrDefault(x => x.ShirtId == shirt.ShirtId,null);
            if(a==null)
            {
                shirts.Add(shirt);
                return shirts;
            }
                return null;

        }

        public bool DeleteShirt(int id)
        {
            var v = shirts.FirstOrDefault(x => x.ShirtId == id);
            return shirts.Remove(v);
        }

        public List<Shirt> GetAllShirt()
        {
            return shirts;
        }

        public Shirt GetShirtById(int id)
        {
            var shirt = shirts.FirstOrDefault(x => id == x.ShirtId,null);

            if (shirt != null)
            {
                return shirt;
            }
            else
            {
                throw new Exception("Shirtnotfound");
            }
        }

        public Shirt UpdateShirt(Shirt shirt)
        {
            var oldshirt = shirts.FirstOrDefault(x=>shirt.ShirtId==x.ShirtId,null);
            if (oldshirt != null ? shirts.Remove(oldshirt) ? true : false : false)
                return shirt;
            else
                throw new Exception("ShirtNotFound");
        }
    }
}
