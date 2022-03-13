using entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace business.Abstract
{
    public interface IContactService
    {
        Task<Contact> GetById(int id);

        Task<List<Contact>> GetAll();

        void Create(Contact entity);

        void Update(Contact entity);

        void Delete(Contact entity);
        List<Contact> GetByPageSize(int page, int pageSize);
    }
}
