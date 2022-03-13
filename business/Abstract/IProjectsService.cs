using entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace business.Abstract
{
    public interface IProjectsService
    {

        Task<Projects> GetById(int id);

        Task<List<Projects>> GetAll();

        void Create(Projects entity);

        void Update(Projects entity);

        void Delete(Projects entity);
        Projects GetByCode(string pcode);
    }
}
