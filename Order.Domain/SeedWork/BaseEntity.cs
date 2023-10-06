using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.SeedWork
{
    public abstract class BaseEntity
    {
        //Base entity objemiz, diğer classları buradan türeteceğiz.
        //Sık kullanılan Id olduğu için şimdilik onu ekledim.
        public int Id { get; set; }
    }
}
