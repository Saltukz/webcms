using business.Abstract;
using data.Abstract;
using entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace business.Concrete
{
    public class NewsManager : INewsService
    {
        private readonly IUnitOfWork _unitOfWork;

        public NewsManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Create(News entity)
        {
            _unitOfWork.News.Create(entity);
            _unitOfWork.Save();
        }

        public void Delete(News entity)
        {
            _unitOfWork.News.Delete(entity);
            _unitOfWork.Save();
        }

        public async Task<List<News>> GetAll()
        {
           return await _unitOfWork.News.GetAll();
        }

        public List<Tuple<string, string>> GetTuple()
        {
            return _unitOfWork.News.GetTuple();
        }

        public async Task<News> GetById(int id)
        {
            return await _unitOfWork.News.GetById(id);
        }

        public List<News> GetByPageSize(int page, int pageSize)
        {
            return _unitOfWork.News.GetByPageSize(page, pageSize);
        }

        public News GetBySeoUrl(string seocode, string culture)
        {
            return _unitOfWork.News.GetBySeoUrl(seocode,culture);
        }

        public void Update(News entity)
        {
            _unitOfWork.News.Update(entity);
            _unitOfWork.Save();
        }
    }
}
