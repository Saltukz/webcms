using entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace data.Abstract
{
    public interface IProjectsRepository : IRepository<Projects>
    {
        Projects GetByCode(string pcode);
    }
}
