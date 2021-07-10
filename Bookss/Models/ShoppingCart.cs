using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookss.Models
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            ListItems = new List<ShoppingCartItem>();
        }
        public List<ShoppingCartItem> ListItems { get; set; }
        public decimal Total { get; set; }
    }
}
