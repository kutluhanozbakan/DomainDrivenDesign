using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class Address : ValueObject
    {
        //kimliği olmayan bir sınıf olduğu için valueObject sınıfından türettik.
        public string City { get; set; }
        public string Country { get; set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return City; 
            yield return Country;
        }
    }
}
