using data.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace data.Concrete.EfCore
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShopContext _context;

        public UnitOfWork(ShopContext context)
        {
            _context = context;
        }
        private EfCoreProductRepository _productRepository;
        private EfCoreCategoryRepository _categoryRepository;
        private EfCoreContactRepository _contactRepository;
        private EfCoreDokumanRepository _dokumanRepository;
        private EfCoreDokumanCategoryRepository _dokumanCategoryRepository;
        private EfCoreKariyerRepository _kariyerRepository;
        private EfCoreNewsRepository _newsRepository;
        private EfCoreUygulamalarRepository _uygulamalarRepository;
        private EfCoreProjectGaleryRepository _projectGaleryRepository;
        private EfCoreProjectsRepository _projectsRepository;

        public IProductRepository Products => _productRepository = _productRepository ?? new EfCoreProductRepository(_context);

        public ICategoryRepository Categories =>_categoryRepository = _categoryRepository ?? new EfCoreCategoryRepository(_context);

        public IContactRepository Contacts => _contactRepository = _contactRepository ?? new EfCoreContactRepository(_context);

        public IDokumanRepository Dokumanlar => _dokumanRepository = _dokumanRepository ?? new EfCoreDokumanRepository(_context);

        public IDokumanCategoryRepository DokumanCategories => _dokumanCategoryRepository = _dokumanCategoryRepository ?? new EfCoreDokumanCategoryRepository(_context);

        public IKariyerRepository Kariyerler => _kariyerRepository = _kariyerRepository ?? new EfCoreKariyerRepository(_context);

        public INewsRepository News => _newsRepository = _newsRepository ?? new EfCoreNewsRepository(_context);

        public IUygulamalarRepository Uygulamalar => _uygulamalarRepository = _uygulamalarRepository ?? new EfCoreUygulamalarRepository(_context);

        public IProjectGaleryRepository ProjectGaleries => _projectGaleryRepository = _projectGaleryRepository ?? new EfCoreProjectGaleryRepository(_context);

        public IProjectsRepository Projects => _projectsRepository = _projectsRepository ?? new EfCoreProjectsRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
