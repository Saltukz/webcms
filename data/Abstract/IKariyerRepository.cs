using entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace data.Abstract
{
    public interface IKariyerRepository : IRepository<Kariyer>
    {
        List<Kariyer> GetByPageSize(int page, int pageSize);
    }
}
