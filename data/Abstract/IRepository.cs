using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace data.Abstract
{
    public interface IRepository<T>
    {

        Task<T> GetById(int id);

        Task<List<T>> GetAll();

        

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
