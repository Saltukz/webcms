using entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace business.Abstract
{
    public interface IProjectsService
    {

        Projects GetById(int id);

        List<Projects> GetAll();

        void Create(Projects entity);

        void Update(Projects entity);

        void Delete(Projects entity);
        Projects GetByCode(string pcode);
    }
}
