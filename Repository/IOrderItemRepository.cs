﻿using EShopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopping.Repository
{
    public interface IOrderItemRepository
    {
        public OrderItem FindById(int id);

        public OrderItem Create(OrderItem orderItem);

        public OrderItem Update(OrderItem orderItem);

        public void Delete(int id);

        public List<OrderItem> GetAll();

        public bool Exists(int id);
    }
}
