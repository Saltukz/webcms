using business.Abstract;
using data.Abstract;
using entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace business.Concrete
{
    public class ContactManager : IContactService
    {
        private IUnitOfWork _unitofWork ;

        public ContactManager(IUnitOfWork unitOfWork)
        {
            _unitofWork = unitOfWork;
        }
        public void Create(Contact entity)
        {
            _unitofWork.Contacts.Create(entity);
            _unitofWork.Save();
        }

        public void Delete(Contact entity)
        {
            _unitofWork.Contacts.Delete(entity);
            _unitofWork.Save();
        }

        public async Task<List<Contact>> GetAll()
        {
            return await _unitofWork.Contacts.GetAll();
        }

        public async Task<Contact> GetById(int id)
        {
            return await _unitofWork.Contacts.GetById(id);
        }

        public List<Contact> GetByPageSize(int page, int pageSize)
        {
            return _unitofWork.Contacts.GetByPageSize(page, pageSize);
        }

        public void Update(Contact entity)
        {
            throw new NotImplementedException();
        }
    }
}
