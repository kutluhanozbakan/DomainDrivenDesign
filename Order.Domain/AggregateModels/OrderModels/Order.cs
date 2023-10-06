using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class Order : BaseEntity, IAggrageRoot
    {
        //Dışardan müdahale olmaması için kendi içerisinde validasyonlarını ve setleme işlemlerini burada tanımladım.
        public Order(DateTime orderDate, string description, int buyerId, string orderStatus, Address address, ICollection<OrderItem> orderItems)
        {
            if (orderDate < DateTime.Now)
                throw new Exception("Order date must be greater than now");

            if (String.IsNullOrEmpty(address.City))
                throw new Exception("City cannot be empty");

            OrderDate = orderDate;
            Description = description;
            BuyerId = buyerId;
            OrderStatus = orderStatus;
            Address = address;
            OrderItems = orderItems;
        }

        public DateTime OrderDate { get; private set; }
        public string Description { get; private set; }
        public int BuyerId { get; private set; }
        public string OrderStatus { get; private set; }
        public Address Address { get; private set; }
        public ICollection<OrderItem> OrderItems { get; private set; }

        public void AddOrderItem(int quantity, decimal price, int productId)
        {
            OrderItem item = new(quantity, price, productId);
            OrderItems.Add(item);
        }
    }

  
}
