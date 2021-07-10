using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookss.Models;
using Domains;

namespace Bookss.Bl

{
    /// <summary>
    /// Creating a dependency injection by creating an interface that includes all of the 
    /// methods written inside of the class.
    /// </summary>
    public interface ICategoryService
    {
        IList<TbCategory> GetAll();
    }
    public class ClsCategories: ICategoryService
    {
        NeStoreWebsiteContext ctx;
        public ClsCategories(NeStoreWebsiteContext neStoreWebsiteContext)
        {
            ctx = neStoreWebsiteContext;
        }
        /// <summary>
        /// get all categories as list
        /// </summary>
        /// <returns></returns>
        public IList<TbCategory> GetAll()
        {
            return ctx.TbCategories.ToList();
        }
    }
}
