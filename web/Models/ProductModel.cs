using entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web.Models
{
    public class ProductModel
    {
        public List<Category> categories { get; set; }


        public List<int> Selectedcategories { get; set; }

        public PageInfo PageInfo { get; set; }

        public List<Product> Products { get; set; }

        public List<Tuple<int, List<int>>> relation { get; set; }



        public int ProductId { get; set; }

        public string Culture { get; set; }

        public string Code { get; set; }

        public string Renk { get; set; }

        public int UstGenislik { get; set; }

        public int UstCap { get; set; }

        public int AltCap { get; set; }

        public int TbCap { get; set; }

        public int Yukseklik { get; set; }

        public int Hacim { get; set; }

        public int TamHacim { get; set; }

        public int Baski { get; set; }

        public int SosisIciAdet { get; set; }

        public int KoliIciAdet { get; set; }

        public string ImageUrl { get; set; }


        [DataType(DataType.Upload)]
        public IFormFile file { get; set; }


        public int[] CategoryIds { get; set; }

    }
}
