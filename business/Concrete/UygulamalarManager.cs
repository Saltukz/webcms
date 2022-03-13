using business.Abstract;
using data.Abstract;
using entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace business.Concrete
{
    public class UygulamalarManager : IUygulamalarService
    {

        private readonly IUnitOfWork _unitOfWork;

        public UygulamalarManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Create(Uygulama entity)
        {
            _unitOfWork.Uygulamalar.Create(entity);
            _unitOfWork.Save();
        }

        public void Delete(Uygulama entity)
        {
            _unitOfWork.Uygulamalar.Delete(entity);
            _unitOfWork.Save();
        }

     
        public async Task<List<Uygulama>> GetAll()
        {
            return await _unitOfWork.Uygulamalar.GetAll();
        }

       

        public async Task<Uygulama> GetById(int id)
        {
            return await _unitOfWork.Uygulamalar.GetById(id);
        }

        public List<Uygulama> GetByPageSize(int page, int pageSize)
        {
            return _unitOfWork.Uygulamalar.GetByPageSize(page, pageSize);
        }

        public List<Tuple<string, string>> GetTuple()
        {
            return _unitOfWork.Uygulamalar.GetTuple();
        }

        public void Update(Uygulama entity)
        {
            _unitOfWork.Uygulamalar.Update(entity);
            _unitOfWork.Save();
        }

        List<Uygulama> IUygulamalarService.GetAllByCulture(string culture)
        {
            return _unitOfWork.Uygulamalar.GetAllByCulture(culture);
        }

        Uygulama IUygulamalarService.GetBySeoUrl(string seourl)
        {
            return _unitOfWork.Uygulamalar.GetBySeoUrl(seourl);
        }
    }
}
