/*using Microsoft.AspNetCore.Mvc;
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
*/
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPIDemo.Models.DataAccess;
using WebAPIDemo.Models.Repositary.Interfaces;
using WebAPIDemo.Models;

namespace WebAPIDemo.Models.Repositary.Imp
{
    public class ShirtRepoImpl : IshirtRepo
    {
        private ApplicationDbContext _context=new ApplicationDbContext();

      

        public List<Shirt> CreateShirt(Shirt shirt)
        {
            _context.Add(shirt);
            _context.SaveChanges();
            return _context.Dress.ToList();
        }

        public bool DeleteShirt(int id)
        {
            var shirt = _context.Dress.FirstOrDefault(x => x.ShirtId == id);
            if (shirt != null)
            {
                _context.Dress.Remove(shirt);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Shirt> GetAllShirt()
        {
            return _context.Dress.ToList();
        }

        public Shirt GetShirtById(int id)
        {
            var shirt = _context.Dress.FirstOrDefault(x => x.ShirtId == id);
            if (shirt != null)
            {
                return shirt;
            }
            else
            {
                throw new Exception("Shirt not found");
            }
        }

        public Shirt UpdateShirt(Shirt shirt)
        {
            var existingShirt = _context.Dress.FirstOrDefault(x => x.ShirtId == shirt.ShirtId);
            if (existingShirt != null)
            {
                existingShirt.Brand = shirt.Brand;
                existingShirt.Size = shirt.Size;
                existingShirt.Gender = shirt.Gender;
                existingShirt.Price = shirt.Price;

                _context.SaveChanges();
                return existingShirt;
            }
            else
            {
                throw new Exception("Shirt not found");
            }
        }
    }
}
