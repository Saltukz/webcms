using business.Abstract;
using data.Abstract;
using entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace business.Concrete
{
    public class DokumanManager : IDokumanService
    {

        private readonly IUnitOfWork _unitOfWork;

        public DokumanManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Create(Dokuman entity)
        {
            _unitOfWork.Dokumanlar.Create(entity);
        }

      

        public void CreateRaw(Dokuman entity, int[] dokumanCategoryIds)
        {
            _unitOfWork.Dokumanlar.CreateRaw(entity, dokumanCategoryIds);
            _unitOfWork.Save();
        }

        public void Delete(Dokuman entity)
        {
            _unitOfWork.Dokumanlar.Delete(entity);
            _unitOfWork.Save();
        }

        public List<Dokuman> GetAll()
        {
           return _unitOfWork.Dokumanlar.GetAll();
        }

        public List<Dokuman> GetAllWithCategories()
        {
            return _unitOfWork.Dokumanlar.GetAllWithCategories();
        }

        public Dokuman GetById(int id)
        {
            return _unitOfWork.Dokumanlar.GetById(id);
        }

        public List<Dokuman> GetByPageSize(int page, int pageSize)
        {
            return _unitOfWork.Dokumanlar.GetByPageSize(page, pageSize);
        }

        public List<Tuple<int, List<int>>> GetRelationTable()
        {
            return _unitOfWork.Dokumanlar.GetRelationTable();
        }

        public List<Dokuman> GetSearchResult(string searchString)
        {
            return _unitOfWork.Dokumanlar.GetSearchResult(searchString);
        }

        public List<Tuple<string, string>> GetTuple()
        {
            return _unitOfWork.Dokumanlar.GetTuple();
        }

        public void Update(Dokuman entity)
        {
            _unitOfWork.Dokumanlar.Update(entity);
            _unitOfWork.Save();
        }
    }
}
