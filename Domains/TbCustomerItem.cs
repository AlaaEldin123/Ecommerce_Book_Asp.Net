using System;
using System.Collections.Generic;

 
namespace Domains
{
    public partial class TbCustomerItem
    {
        public int ItemId { get; set; }
        public int CustomerId { get; set; }

        public virtual TbCustomer Customer { get; set; }
        public virtual TbItem Item { get; set; }
    }
}
