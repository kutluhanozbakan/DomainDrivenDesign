

using Order.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Infrastucture.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public Task<int> SaveChangesAsync()
        {
            //db işlemleri
            return Task.FromResult(0);
        }
    }
}
