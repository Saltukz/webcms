using entity;
using web.Helpers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web.Models
{



    public class HaberlerModel
    {

        public int NewsId { get; set; }

        public string Code { get; set; }

        public string Culture { get; set; }

        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public string SeoUrl { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ImageUrl { get; set; }

        public string MetaDescription { get; set; }

        public string MetaTags { get; set; }

        public List<News> News { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile file { get; set; }


        public List<string> AllCultures { get; set; }

        public PageInfo PageInfo { get; set; }

        public List<string> Codes { get; set; }

       public string RequestedNew { get; set; }
    }

  
}
