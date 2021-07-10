using System;
using System.Collections.Generic;

 

namespace Domains
{
    public partial class TbCustomer
    {
        public TbCustomer()
        {
            TbCustomerItems = new HashSet<TbCustomerItem>();
            TbSalesInvoices = new HashSet<TbSalesInvoice>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public virtual TbBusinessInfo TbBusinessInfo { get; set; }
        public virtual ICollection<TbCustomerItem> TbCustomerItems { get; set; }
        public virtual ICollection<TbSalesInvoice> TbSalesInvoices { get; set; }
    }
}
