using EShopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopping.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly EShoppingContext _dbContext;
        public AdminRepository(EShoppingContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Admin FindById(int id)
        {
            return _dbContext.Admins.Find(id);
        }

        public Admin Create(Admin admin)
        {
            _dbContext.Admins.Add(admin);
            _dbContext.SaveChanges();
            return admin;
        }

        public Admin Update(Admin admin)
        {
            _dbContext.Admins.Update(admin);
            _dbContext.SaveChanges();
            return admin;
        }

        public void Delete(int id)
        {
            //var customer = FindById(id);
            var admin = new Admin
            {
                AdminId = id
            };
            if (admin != null)
            {
                _dbContext.Admins.Remove(admin);
                _dbContext.SaveChanges();
            }
        }

        public List<Admin> GetAll()
        {
            return _dbContext.Admins.ToList();

        }

        public bool Exists(int id)
        {
            return _dbContext.Admins.Any(e => e.AdminId == id);
        }

        public Admin FindByEmail(string email)
        {
            return _dbContext.Admins.FirstOrDefault(c => c.Email == email);
        }
    }
}
