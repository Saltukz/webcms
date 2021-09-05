using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace entity
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string Code { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Culture { get; set; }

        public string SeoUrl { get; set; }

        public string MetaDescription { get; set; }

        public int Granuls { get; set; }

        public string ImageUrl { get; set; }



        public List<ProductCategory> ProductCategories { get; set; }
    }
}
