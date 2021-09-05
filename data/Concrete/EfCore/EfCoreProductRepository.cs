using data.Abstract;
using entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product>, IProductRepository
    {

        public EfCoreProductRepository(ShopContext context):base(context)
        {

        }

        private ShopContext ShopContext
        {
            get { return context as ShopContext; }
        }
        public void CreateRaw(Product entity, int[] thermoformCategoryIds)
        {
           
                context.Set<Product>().Add(entity);
                entity.ProductCategories = thermoformCategoryIds.Select(catid => new ProductCategory()
                {
                   
                   ThermoformProduct = entity,
                    ProductId = entity.ProductId,
                    CategoryId = catid,
                    ThermoformCategory = ShopContext.Categories.Where(i=>i.CategoryId == catid).FirstOrDefault()
                    
                }).ToList();

                context.SaveChanges();
           
        }

        public void DeleteWithRelation(Product entity)
        {
            

                var cmd = "delete from ProductCategory where ProductId=@p0 or ProductProductId=@p1 ";
            ShopContext.Database.ExecuteSqlRaw(cmd, entity.ProductId,entity.ProductId);

            ShopContext.Remove(entity);

            ShopContext.SaveChanges();
            
        }

        public Product GetByCodeandCulture(int code, string culture)
        {
            throw new NotImplementedException();
        }

        public Product GetByIdWithCategories(int id)
        {
           
                return ShopContext.Products
                    .Where(i => i.ProductId == id)
                    .Include(i => i.ProductCategories)
                    .ThenInclude(i => i.ThermoformCategory)
                    .FirstOrDefault();
         
        }

        public List<Product> GetByPageSize(int page, int pageSize)
        {
          
                var thermoformProducts = ShopContext
                     .Products

                     .AsQueryable();
                if (pageSize != 0)
                {
                    thermoformProducts = thermoformProducts
                        .OrderByDescending(p => p.Code);

                }
                return thermoformProducts.Skip((page - 1) * pageSize).Take(pageSize).ToList();
          
        }

        public List<Product> GetProductsbyCategory(string seo)
        {
           
                var thermoformProducts = ShopContext
                     .Products

                     .AsQueryable();
                if (!string.IsNullOrEmpty(seo))
                {
                    thermoformProducts = thermoformProducts
                        .Include(i => i.ProductCategories)
                        .ThenInclude(i => i.ThermoformCategory)
                        .Where(i => i.ProductCategories.Any(a => a.ThermoformCategory.SeoUrl.ToLower() == seo.ToLower()));
                }
                return thermoformProducts.ToList();
          
        }

        public List<Tuple<int, List<int>>> GetRelationTable()
        {
          
                var thermoformProducts = ShopContext
                  .Products
                  .AsQueryable();

                var dokumanlar2 = thermoformProducts
                    .Include(a => a.ProductCategories)
                     .Select(c => Tuple.Create(c.ProductId, c.ProductCategories.Select(a => a.CategoryId).ToList()))
                     .ToList();




                return dokumanlar2;

          
        }

        public void Update(Product entity, int[] thermoformCategoryIds)
        {
          
                var product = ShopContext.Products                  
                    .FirstOrDefault(i => i.ProductId == entity.ProductId);            

                

                if (product != null)
                {
                    
                    product.Code = entity.Code;
                    product.Culture = entity.Culture;
                    product.Renk = entity.Renk;
                    product.UstGenislik = entity.UstGenislik;
                    product.UstCap = entity.UstCap;
                    product.AltCap = entity.AltCap;
                    product.TbCap = entity.TbCap;
                    product.Yukseklik = entity.Yukseklik;
                    product.Hacim = entity.Hacim;
                    product.TamHacim = entity.TamHacim;
                    product.Baski = entity.Baski;
                    product.SosisIciAdet = entity.SosisIciAdet;
                    product.KoliIciAdet = entity.KoliIciAdet;
                    product.ImageUrl = entity.ImageUrl;

                    var cmd = "delete from ThermoformProductCategory where ProductId=@p0";
                ShopContext.Database.ExecuteSqlRaw(cmd, product.ProductId);    
                
                    
                    product.ProductCategories = thermoformCategoryIds.Select(catid =>  new ProductCategory()
                    {
                        ProductId = product.ProductId,                       
                        CategoryId = catid,
                        ThermoformCategory = ShopContext.Categories.Where(i => i.CategoryId == catid).FirstOrDefault()
                    }).ToList();

                ShopContext.Entry(product).State = EntityState.Modified;
                ShopContext.SaveChanges();                   
                }
               
       
        }
    }
}
