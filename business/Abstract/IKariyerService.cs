using entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace business.Abstract
{
    public interface IKariyerService
    {
        Task<Kariyer> GetById(int id);

        Task<List<Kariyer>> GetAll();

        void Create(Kariyer entity);

        void Update(Kariyer entity);

        void Delete(Kariyer entity);
        List<Kariyer> GetByPageSize(int page, int pageSize);
    }
}
