using data.Abstract;
using entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data.Concrete.EfCore
{
    public class EfCoreProjectGaleryRepository : EfCoreGenericRepository<ProjectGalery>, IProjectGaleryRepository
    {

        public EfCoreProjectGaleryRepository(ShopContext context):base(context)
        {

        }
        private ShopContext ShopContext
        {
            get { return context as ShopContext; }
        }
        public List<ProjectGalery> GetGalleryByProject(string pcode, string culture)
        {
            
                var projectGallery = ShopContext
                        .ProjectGaleries
                        .Where(i => i.Culture == culture)
                        .AsQueryable();
                if (!string.IsNullOrEmpty(pcode))
                {
                    projectGallery = projectGallery
                        .Include(i => i.ProjectGaleryRelations)
                        .ThenInclude(i => i.Projects)
                        .Where(i => i.ProjectGaleryRelations.Any(a => a.Projects.Code.ToLower() == pcode.ToLower()));
                }
                return projectGallery.ToList();
          
        }
    }
}
