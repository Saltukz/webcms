using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace data.Abstract
{
    public interface IUnitOfWork: IDisposable
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }

        IContactRepository Contacts { get; }

        IDokumanRepository Dokumanlar { get; }

        IDokumanCategoryRepository DokumanCategories { get; }

        IKariyerRepository Kariyerler { get; }
        INewsRepository News { get; }
        IUygulamalarRepository Uygulamalar { get; }
        IProjectGaleryRepository ProjectGaleries { get; }

        IProjectsRepository Projects { get; }

        void Save();

        Task<int> SaveAsync();


    }
}
