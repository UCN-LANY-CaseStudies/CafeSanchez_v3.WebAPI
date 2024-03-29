﻿using CafeManager5000.DataAccess;
using CafeManager5000.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderHandlingAPITests
{
    public class OrderDaoFixture : IDao<Order>
    {
        public Order Create(Order entity)
        {
            entity.Id = 1;
            return entity;
        }

        public bool Delete(Order entity)
        {
            return entity.Id != 0;
        }

        public IEnumerable<Order> ReadAll()
        {
            return new List<Order>() { new Order
                {
                    Id = 1,
                    CustomerName = "Hans",
                    Discount = 0,
                    State = Order.States.New,
                }
            };
        }

        public bool Update(Order entity)
        {
            return entity.Id != 0 && entity.State != Order.States.Finished;
        }
    }
}
