using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookss.Models
{
    /// <summary>
    /// same as Vm classes specialized for shopping cart or sepete
    /// </summary>
    public class ShoppingCartItem
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ImageName { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public decimal Total { get; set; }
    }
}
