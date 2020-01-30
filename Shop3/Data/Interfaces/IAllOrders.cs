using Shop3.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop3.Data.Interfaces
{
    public interface IAllOrders
    {
        void createOrder(Order order);
    }
}
