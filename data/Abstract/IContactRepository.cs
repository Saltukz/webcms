using entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace data.Abstract
{
    public interface IContactRepository : IRepository<Contact>
    {
        List<Contact> GetByPageSize(int page, int pageSize);
    }
}
