using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Models
{
   public class Customer : BaseEntity
    {
        public string CustomerName { get; set; }
        public int PurchasesProduct { get; set; }
        public string PaymentType { get; set; }
    }
}
