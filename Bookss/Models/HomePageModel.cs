using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domains;

namespace Bookss.Models
{
    /// <summary>
    /// same as Vm class to deal with the requirements of the view.
    /// it holds a list from each table and not only one property.
    /// </summary>
    public class HomePageModel
    {
        public IEnumerable<TbSlider> lstSliderImages { get; set; }
        public IEnumerable<TbItem> lstNewItems { get; set; }
        public IEnumerable<TbItem> lstAllItems { get; set; }
        public IEnumerable<TbItem> lstCategories { get; set; }
        public IEnumerable<TbItem> lstBestSellers { get; set; }
    }
}
