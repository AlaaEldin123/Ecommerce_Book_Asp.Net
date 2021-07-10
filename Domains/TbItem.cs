using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

 

namespace Domains
{
    public partial class TbItem
    {
        public TbItem()
        {
            TbCustomerItems = new HashSet<TbCustomerItem>();
            TbItemImages = new HashSet<TbItemImage>();
            TbPurchaseInvoiceItems = new HashSet<TbPurchaseInvoiceItem>();
            TbSalesInvoiceItems = new HashSet<TbSalesInvoiceItem>();
            TbItemDiscount = new HashSet<TbItemDiscount>();
        }

        public int ItemId { get; set; }
        [Required(ErrorMessage ="Please  Enter Item Name") ]
        public string ItemName { get; set; }
        [Required(ErrorMessage = "Please Enter Salse Price")]
        public decimal SalesPrice { get; set; }
        [Required(ErrorMessage = "Please Enter purchase Price")]
        public decimal PurchasePrice { get; set; }
        [Required(ErrorMessage = "Please Enter Category")]
        public int CategoryId { get; set; }
        [MaxLength (200)]
        public string ImageName { get; set; }
        public DateTime? CreationDate { get; set; }


        public virtual TbCategory Category { get; set; }
        public virtual ICollection<TbCustomerItem> TbCustomerItems { get; set; }
        public virtual ICollection<TbItemImage> TbItemImages { get; set; }
        public virtual ICollection<TbPurchaseInvoiceItem> TbPurchaseInvoiceItems { get; set; }
        public virtual ICollection<TbSalesInvoiceItem> TbSalesInvoiceItems { get; set; }
        public virtual ICollection<TbItemDiscount> TbItemDiscount { get; set; }
    }
}
