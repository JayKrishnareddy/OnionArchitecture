using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.CommonModel
{
   public class Customer
    {
        public string CustomerName { get; set; }
        public int PurchasesProduct { get; set; }
        public string PaymentType { get; set; }
    }
}
