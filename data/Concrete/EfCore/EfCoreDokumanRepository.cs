using data.Abstract;
using entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data.Concrete.EfCore
{
    public class EfCoreDokumanRepository : EfCoreGenericRepository<Dokuman>, IDokumanRepository
    {

        public EfCoreDokumanRepository(ShopContext context):base(context)
        {

        }

        private ShopContext ShopContext
        {
            get { return context as ShopContext; }
        }
       

        public void CreateRaw(Dokuman entity, int[] dokumanCategoryIds)
        {

            ShopContext.Set<Dokuman>().Add(entity);
                entity.DokumanMnMRels = dokumanCategoryIds.Select(catid => new DokumanMnMRel()
                {
                    DokumanId = entity.DokumanId,
                    DokumanCategoryId = catid
                }).ToList();

            ShopContext.SaveChanges();
           
        }

        public List<Dokuman> GetAllWithCategories()
        {
           
                var documents = ShopContext.Dokumanlar.AsQueryable();

                var dokumanlar = documents
                    .Include(i => i.DokumanMnMRels)
                    .ThenInclude(i => i.DokumanCategory)
                    .FirstOrDefault();
                    

                return documents.ToList();
           
        }

        public List<Dokuman> GetByPageSize(int page, int pageSize)
        {
        
                var dokumanlar = ShopContext
                     .Dokumanlar

                     .AsQueryable();
                if (pageSize != 0)
                {
                    dokumanlar = dokumanlar
                        .OrderByDescending(p => p.Code);

                }
                return dokumanlar.Skip((page - 1) * pageSize).Take(pageSize).ToList();
         
        }

        public List<Tuple<int, List<int>>> GetRelationTable()
        {
            
                var dokumanlar = ShopContext
                  .Dokumanlar
                  .AsQueryable();

                var dokumanlar2 = dokumanlar
                    .Include(a => a.DokumanMnMRels)
                     .Select(c => Tuple.Create(c.DokumanId, c.DokumanMnMRels.Select(a => a.DokumanCategoryId).ToList()))
                     .ToList();




                return dokumanlar2;

          
        }

        public List<Dokuman> GetSearchResult(string searchString)
        {
          
                var documents = ShopContext
                    .Dokumanlar
                    .Where(i => i.Name.ToLower().Contains(searchString.ToLower()) || i.Code.ToLower().Contains(searchString.ToLower()))
                    .AsQueryable();

                return documents.ToList();
          
        }

        public List<Tuple<string, string>> GetTuple()
        {
            
                var dokumen = ShopContext
                  .Dokumanlar
                  .AsQueryable();

                var dokumanCategory2 = dokumen
                     .Select(c => Tuple.Create(c.Code, c.Culture))
                     .ToList();



                return dokumanCategory2;
          
        }
    }
}
