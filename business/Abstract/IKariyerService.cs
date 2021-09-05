using entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace business.Abstract
{
    public interface IKariyerService
    {
        Kariyer GetById(int id);

        List<Kariyer> GetAll();

        void Create(Kariyer entity);

        void Update(Kariyer entity);

        void Delete(Kariyer entity);
        List<Kariyer> GetByPageSize(int page, int pageSize);
    }
}
