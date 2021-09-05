using data.Abstract;
using entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data.Concrete.EfCore
{
    public class EfCoreKariyerRepository : EfCoreGenericRepository<Kariyer>, IKariyerRepository
    {

        public EfCoreKariyerRepository(ShopContext context):base(context)
        {

        }
        private ShopContext ShopContext
        {
            get { return context as ShopContext; }
        }
        public List<Kariyer> GetByPageSize(int page, int pageSize)
        {
            
                var basvurular = ShopContext
                     .Kariyer
                     
                     .AsQueryable();
                if (pageSize != 0)
                {
                    basvurular = basvurular
                        .OrderByDescending(p => p.BasvuruTarihi);
                        
                }
                return basvurular.Skip((page - 1) * pageSize).Take(pageSize).ToList();
          
        }
    }
}
