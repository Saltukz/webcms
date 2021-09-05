using entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web.Models
{
    public class DokumanModel
    {
        

        public int DokumanCategoryId { get; set; }
        public string Name { get; set; }

        public string Code { get; set; }

        public string Culture { get; set; }

        public string DokumanUrl { get; set; }

        public int DokumanId { get; set; }

        public string RequestedData { get; set; }

        public DokumanCategory dokumanCategory { get; set; }
        public List<DokumanCategory> dokumanCategories { get; set; }

        public int[] DokumanCategoryIds { get; set; }

        public List<Dokuman> dokumanlar { get; set; }

        public List<string> Codes { get; set; }

        public List<string> AllCultures { get; set; }
        public PageInfo PageInfo { get; set; }


        public IFormFile file { get; set; }


        public List<Tuple<int, List<int>>> relation { get; set; }
    }
}
