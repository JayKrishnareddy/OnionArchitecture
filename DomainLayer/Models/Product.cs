using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Models
{
   public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
    }
}
