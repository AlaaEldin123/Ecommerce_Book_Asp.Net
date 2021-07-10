using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookss.Models
{
    public class ItemDetailModel
    {
        public TbItem Item { get; set; }
        public List<TbItem> ListRelatedItems { get; set; }
        public List<TbItem> ListUpSellerItems { get; set; }

    }
}
