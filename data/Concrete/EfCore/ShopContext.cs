using data.Configurations;
using entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace data.Concrete.EfCore
{
    public class ShopContext:DbContext
    {

        public ShopContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Dokuman> Dokumanlar { get; set; }

        public virtual DbSet<DokumanCategory> DokumanCategories { get; set; }

        public DbSet<Kariyer> Kariyer { get; set; }

        public DbSet<News> News { get; set; }

       

        public virtual DbSet<Uygulama> Uygulamalar { get; set; }

        public virtual DbSet<ProjectGalery> ProjectGaleries { get; set; }

        public DbSet<Projects> Projects { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new ProductConfigurations());
            
            modelBuilder.Entity<DokumanMnMRel>()
                .HasKey(c => new { c.DokumanId, c.DokumanCategoryId });

            modelBuilder.Entity<ProductCategory>()
                .HasKey(c => new { c.CategoryId, c.ProductId });






            modelBuilder.Entity<ProjectGaleryRelation>()
                .HasKey(c => new { c.ProjectId, c.ProjectGalleryId });

         
        }

        
    }
}
