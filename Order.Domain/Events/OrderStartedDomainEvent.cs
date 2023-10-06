using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Events
{
    public class OrderStartedDomainEvent : MediatR.INotification
    {
        public OrderStartedDomainEvent(string userName, AggregateModels.OrderModels.Order order)
        {
            UserName = userName;
            Order = order;
        }

        public string UserName { get; private set; }
        public AggregateModels.OrderModels.Order Order { get; private set; }


    }
}
