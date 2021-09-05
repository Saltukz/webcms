using business.Abstract;
using data.Abstract;
using entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace business.Concrete
{
    public class KariyerManager : IKariyerService
    {
        private readonly IUnitOfWork _unitOfWork;

        public KariyerManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Create(Kariyer entity)
        {
            _unitOfWork.Kariyerler.Create(entity);
            _unitOfWork.Save();
        }

        public void Delete(Kariyer entity)
        {
            _unitOfWork.Kariyerler.Delete(entity);
            _unitOfWork.Save();
        }

        public List<Kariyer> GetAll()
        {
            return _unitOfWork.Kariyerler.GetAll();
        }

        public Kariyer GetById(int id)
        {
            return _unitOfWork.Kariyerler.GetById(id);
        }

        public List<Kariyer> GetByPageSize(int page, int pageSize)
        {
            return _unitOfWork.Kariyerler.GetByPageSize(page, pageSize);
        }

        public void Update(Kariyer entity)
        {
            throw new NotImplementedException();
        }
    }
}
