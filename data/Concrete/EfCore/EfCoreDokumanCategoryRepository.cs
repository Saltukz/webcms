using data.Abstract;
using entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data.Concrete.EfCore
{
    public class EfCoreDokumanCategoryRepository : EfCoreGenericRepository<DokumanCategory>, IDokumanCategoryRepository
    {
        public EfCoreDokumanCategoryRepository(ShopContext context):base(context)
        {

        }
        private ShopContext ShopContext
        {
            get { return context as ShopContext; }
        }
        public void DeleteWithDocuments(DokumanCategory entity)
        {
          
               

                var cmd = "delete from DokumanMnMRel where DokumanCategoryId=@p0";
            ShopContext.Database.ExecuteSqlRaw(cmd,entity.DokumanCategoryId);

            ShopContext.Remove(entity);

            ShopContext.SaveChanges();
           
        }

       

        public List<DokumanCategory> GetByPageSize(int page, int pageSize)
        {
            
                var dokumanKategorileri = ShopContext
                     .DokumanCategories

                     .AsQueryable();
                if (pageSize != 0)
                {
                    dokumanKategorileri = dokumanKategorileri
                        .OrderByDescending(p => p.Code);

                }
                return dokumanKategorileri.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            
        }

        public List<Tuple<string, string>> GetTuple()
        {
            

                var dokumanCategory = ShopContext
                  .DokumanCategories
                  .AsQueryable();

                var dokumanCategory2 = dokumanCategory
                     .Select(c => Tuple.Create(c.Code, c.Culture))
                     .ToList();



                return dokumanCategory2;
          
        }
    }
}
