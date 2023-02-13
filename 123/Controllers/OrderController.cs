using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MusicShop.Repositories;

namespace MusicShop.Controllers
{
    [ApiController]
    [Route("/order")]
    public class OrderController : ControllerBase
    {
        [HttpPut]
        public Order Create(Order order)
        {
            Storage.OrderStorage.Create(order);
            return order;
        }

        [HttpGet]
        public Order Read(int OrderId)
        {
            return Storage.OrderStorage.Read(OrderId);
        }

        [HttpPatch]
        public Order Update(int OrderId, Order newOrder)
        {
            return Storage.OrderStorage.Update(OrderId, newOrder);
        }

        [HttpDelete]
        public bool Delete(int OrderId)
        {
            return Storage.OrderStorage.Delete(OrderId);
        }
    }

}