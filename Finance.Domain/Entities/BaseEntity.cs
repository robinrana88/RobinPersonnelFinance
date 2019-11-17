using System;
using System.Collections.Generic;
using System.Text;

namespace Finance.Domain.Entities
{
    public class BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
