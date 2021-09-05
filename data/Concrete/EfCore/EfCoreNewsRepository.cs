using data.Abstract;
using entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data.Concrete.EfCore
{
    public class EfCoreNewsRepository : EfCoreGenericRepository<News>, INewsRepository
    {
        public EfCoreNewsRepository(ShopContext context):base(context)
        {

        }
        private ShopContext ShopContext
        {
            get { return context as ShopContext; }
        }
        public List<Tuple<string, string>> GetTuple()
        {
            

                var haberler = ShopContext
                  .News
                  .AsQueryable();
              
                   var haberler2 = haberler
                        .Select(c => Tuple.Create(c.Code, c.Culture))
                        .ToList();



                return haberler2;
           
        }

        public List<News> GetByPageSize(int page, int pageSize)
        {
            
                var haberler = ShopContext
                     .News

                     .AsQueryable();
                if (pageSize != 0)
                {
                    haberler = haberler
                        .OrderByDescending(p => p.CreatedDate);

                }
                return haberler.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            
        }

        public News GetBySeoUrl(string seocode,string culture)
        {
            
                return ShopContext.News
                  .Where(i => i.SeoUrl == seocode && i.Culture == culture)
                  .FirstOrDefault();
           
        }
    }
}
