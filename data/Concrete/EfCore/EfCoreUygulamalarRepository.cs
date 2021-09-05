using data.Abstract;
using entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data.Concrete.EfCore
{
    public class EfCoreUygulamalarRepository : EfCoreGenericRepository<Uygulama>, IUygulamalarRepository
    {
        public EfCoreUygulamalarRepository(ShopContext context):base(context)
        {

        }
        private ShopContext ShopContext
        {
            get { return context as ShopContext; }
        }
        public List<Uygulama> GetAllByCulture(string culture)
        {
           
                return ShopContext.Uygulamalar
                    .Where(i => i.Culture == culture).ToList();
          
        }

        public List<Uygulama> GetByPageSize(int page, int pageSize)
        {
           
                var plastikLevhalar = ShopContext
                     .Uygulamalar

                     .AsQueryable();
                if (pageSize != 0)
                {
                    plastikLevhalar = plastikLevhalar
                        .OrderByDescending(p => p.Code);

                }
                return plastikLevhalar.Skip((page - 1) * pageSize).Take(pageSize).ToList();
         
        }

        public Uygulama GetBySeoUrl(string seourl)
        {
           
                return ShopContext.Uygulamalar
                  .Where(i => i.SeoUrl == seourl)
                  .FirstOrDefault();
         
        }

        public List<Tuple<string, string>> GetTuple()
        {
           

                var plastikLevhalar = ShopContext
                  .Uygulamalar
                  .AsQueryable();

                var plastikLevhalar2 = plastikLevhalar
                     .Select(c => Tuple.Create(c.Code, c.Culture))
                     .ToList();



                return plastikLevhalar2;
       
        }
    }
}
