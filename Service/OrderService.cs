using EShopping.Models;
using EShopping.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopping.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        public Order FindById(int id)
        {
            return orderRepository.FindById(id);
        }

        public Order Create(Order order)
        {
            return orderRepository.Create(order);
        }

        public Order Update(Order order)
        {
            return orderRepository.Update(order);
        }

        public void Delete(int id)
        {
           orderRepository.Delete(id);
        }

        public List<Order> GetAll()
        {
            return orderRepository.GetAll();

        }

        public bool Exists(int id)
        {
            return orderRepository.Exists(id);
        }
    }
}
