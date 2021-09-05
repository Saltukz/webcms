using data.Abstract;
using entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data.Concrete.EfCore
{
    public class EfCoreContactRepository : EfCoreGenericRepository<Contact>, IContactRepository
    {

        public EfCoreContactRepository(ShopContext context):base(context)
        {

        }
        private ShopContext ShopContext
        {
            get { return context as ShopContext; }
        }
        public List<Contact> GetByPageSize(int page, int pageSize)
        {
           
                var contacts = ShopContext
                     .Contacts

                     .AsQueryable();
                if (pageSize != 0)
                {
                    contacts = contacts
                        .OrderByDescending(p => p.Tarih);

                }
                return contacts.Skip((page - 1) * pageSize).Take(pageSize).ToList();
        
        }
    }
}
