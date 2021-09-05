using data.Abstract;
using entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {

        public EfCoreCategoryRepository(ShopContext context):base(context)
        {

        }
        private ShopContext ShopContext
        {
            get { return context as ShopContext; }
        }
        public void DeleteWithDocuments(Category entity)
        {
            


                var cmd = "delete from ProductCategory where CategoryId=@p0";
            ShopContext.Database.ExecuteSqlRaw(cmd, entity.CategoryId);

            ShopContext.Categories.Remove(entity);

    
            
        }

        public List<Category> GetAllByCulture(string culture)
        {
            
                return ShopContext.Categories
                    .Where(i => i.Culture == culture).ToList();
           
        }

        public List<Category> GetByPageSize(int page, int pageSize)
        {
            
                var thermoformCategories = ShopContext
                     .Categories

                     .AsQueryable();
                if (pageSize != 0)
                {
                    thermoformCategories = thermoformCategories
                        .OrderByDescending(p => p.Code);

                }
                return thermoformCategories.Skip((page - 1) * pageSize).Take(pageSize).ToList();
          

        }

        public Category GetBySeoUrl(string seourl)
        {

           
                return ShopContext.Categories
                  .Where(i => i.SeoUrl == seourl)
                  .FirstOrDefault();
         
         
        }

        public List<Category> GetSearchResult(string searchString)
        {
            
                var categories = ShopContext
                    .Categories
                    .Where(i => i.Title.ToLower().Contains(searchString.ToLower()) || i.Description.ToLower().Contains(searchString.ToLower()) || i.Code.ToLower().Contains(searchString.ToLower()))
                    .AsQueryable();
                
                return categories.ToList();
           
        }

        public List<Tuple<string, string>> GetTuple()
        {
            

                var thermoformCategory = ShopContext
                  .Categories
                  .AsQueryable();

                var thermoformCategory2 = thermoformCategory
                     .Select(c => Tuple.Create(c.Code, c.Culture))
                     .ToList();



                return thermoformCategory2;
          
        }
    }
}
// 