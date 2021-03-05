using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Models
{
   public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
