﻿using EShopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopping.Repository 
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly EShoppingContext _dbContext;
        public CustomerRepository(EShoppingContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Customer FindById(int id)
        {
            return _dbContext.Customers.Find(id);
        }

        public Customer Create(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
            return customer;
        }

        public Customer Update(Customer customer)
        {
            _dbContext.Customers.Update(customer);
            _dbContext.SaveChanges();
            return customer;
        }

        public void Delete(int id)
        {
            //var customer = FindById(id);
            var customer = new Customer
            {
                CustomerId = id
            };
            if(customer != null)
            {
                _dbContext.Customers.Remove(customer);
                _dbContext.SaveChanges();
            }
        }

        public List<Customer> GetAll()
        {
            return _dbContext.Customers.ToList();
          
        }

        public  bool Exists(int id)
        {
            return _dbContext.Customers.Any(e => e.CustomerId == id);
        }
    }
}