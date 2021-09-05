using business.Abstract;
using data.Abstract;
using entity;
using System;
using System.Collections.Generic;
using System.Text;

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

        public List<Contact> GetAll()
        {
            return _unitofWork.Contacts.GetAll();
        }

        public Contact GetById(int id)
        {
            throw new NotImplementedException();
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
