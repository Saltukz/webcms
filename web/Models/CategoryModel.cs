using entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace web.Models
{
    public class CategoryModel
    {
        public List<Category> categories { get; set; }
        public Category category { get; set; }
        public List<Product> products { get; set; }

        public PageInfo PageInfo { get; set; }

        public string RequestedData { get; set; }

        public List<string> Codes { get; set; }

        public List<string> AllCultures { get; set; }



        public int CategoryId { get; set; }

        public string Code { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Culture { get; set; }

        public string SeoUrl { get; set; }

        public string MetaDescription { get; set; }

        public string MetaTags { get; set; }

        public int Granuls { get; set; }

        public string ImageUrl { get; set; }

        public IFormFile file { get; set; }


    }
}
