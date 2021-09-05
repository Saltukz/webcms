using data.Abstract;
using entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data.Concrete.EfCore
{
    public class EfCoreProjectsRepository : EfCoreGenericRepository<Projects>, IProjectsRepository
    {
        public EfCoreProjectsRepository(ShopContext context):base(context)
        {

        }
        private ShopContext ShopContext
        {
            get { return context as ShopContext; }
        }
        public Projects GetByCode(string pcode)
        {
           
                return ShopContext.Projects
                  .Where(i => i.Code == pcode)
                  .FirstOrDefault();
          
        }
    }
}
