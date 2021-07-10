using Bookss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domains;


namespace Bookss.Bl
{
    /// <summary>
    /// Creating Interface
    /// </summary>
    public interface IItemService
    {
        List<TbItem> GetAll();
        List<TbItem> GetRelatedItems(decimal price);
        List<TbItem> GetUpSellItems();
        List<VwItemCategories> GetAllItems();
        TbItem GetById(int id);
        TbItem GetByIdWithImages(int id);
        bool Add(TbItem item);
        bool Edit(TbItem item);
        bool Delete(int itemId);

    }

    public class ClsItems: IItemService
    {
        /// <summary>
        /// Creating Constructer for the dbcontext.
        /// </summary>
        NeStoreWebsiteContext ctx;
        public ClsItems(NeStoreWebsiteContext Context )
        {
            ctx = Context;
        }
        /// <summary>
        /// GetAll method shows all of the items as a list, including the category table 
        /// </summary>
        /// <returns></returns>
        public List<TbItem> GetAll()
        {
           
            List<TbItem> lstItems = ctx.TbItems.Include(a=>a.Category).
            OrderByDescending(a => a.CreationDate).ToList();
            return lstItems;
        }
        /// <summary>
        /// GetAllItems to deal with API
        /// </summary>
        /// <returns></returns>
        public List<VwItemCategories> GetAllItems()
        {
            List<VwItemCategories> lstItems = ctx.VwItemCategories.ToList();
            return lstItems;
        }
        /// <summary>
        /// get related items according to price range
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public List<TbItem> GetRelatedItems(decimal price)
        {
            decimal start = price - 3000;
            decimal end = price + 3000;
            List<TbItem> lstItems = ctx.TbItems.Include(a => a.Category).Where(a=> a.SalesPrice>= start && a.SalesPrice<= end).
            OrderByDescending(a => a.CreationDate).ToList();
            return lstItems;
        }
        /// <summary>
        /// GetUpSellItems() gets the up seller items according to the discount and the duration
        /// of the discount
        /// </summary>
        /// <returns></returns>
        public List<TbItem> GetUpSellItems()
        {
            var query = (from items in ctx.TbItems
                        join
                        discount in ctx.TbItemDiscount
                        on items.ItemId equals discount.ItemId
                        where discount.EndDate >= DateTime.Now
                        select items).Include(a => a.Category);
            return query.ToList();
        }
        /// <summary>
        /// gets all the items by id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TbItem GetById(int id)
        {
             
            TbItem item = ctx.TbItems.Include(a => a.Category).FirstOrDefault(a => a.ItemId == id);
            return item;
        }
        /// <summary>
        /// gets the item by its id with its image
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TbItem GetByIdWithImages(int id)
        {
            try
            { 
                TbItem item = ctx.TbItems.Include(a => a.TbItemImages).FirstOrDefault(a => a.ItemId == id);
                return item;
            }
            catch(Exception ex)
            {
              
                return new TbItem();
            }
 
        }
        /// <summary>
        /// to add a new item in the list and the database
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Add(TbItem item)
        {
            try
            {
                ctx.Add<TbItem>(item);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// for editing an existing item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Edit(TbItem item)
        {
            try
            {
                //ctx.Add<TbItem>(item);
                //ctx.SaveChanges();
                ctx.Entry(item).State = EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// to delete an item from database and list by getting its id
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public bool Delete(int itemId)
        {
            try
            {
                TbItem olditem = ctx.TbItems.Where(a => a.ItemId == itemId).FirstOrDefault();
                ctx.TbItems.Remove(olditem);
                //ctx.Add<TbItem>(item);
                ctx.SaveChanges();
                //ctx.Entry(item).State = EntityState.Deleted;
                //ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
