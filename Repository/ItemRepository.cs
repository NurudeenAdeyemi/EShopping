﻿using EShopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopping.Repository
{
    public class ItemRepository : IItemRepository
    {
        private readonly EShoppingContext _dbContext;
        public ItemRepository(EShoppingContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Item FindById(int id)
        {
            return _dbContext.Items.Find(id);
        }

        public Item Create(Item item)
        {
            _dbContext.Items.Add(item);
            _dbContext.SaveChanges();
            return item;
        }

        public Item Update(Item item)
        {
            _dbContext.Items.Update(item);
            _dbContext.SaveChanges();
            return item;
        }

        public void Delete(int id)
        {
            //var customer = FindById(id);
            var item = new Item
            {
                ItemId = id
            };
            if (item != null)
            {
                _dbContext.Items.Remove(item);
                _dbContext.SaveChanges();
            }
        }

        public List<Item> GetAll()
        {
            return _dbContext.Items.ToList();

        }

        public bool Exists(int id)
        {
            return _dbContext.Items.Any(e => e.ItemId == id);
        }
    }
}
