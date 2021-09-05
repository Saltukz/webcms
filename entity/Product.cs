using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace entity
{
    public class Product
    {
        [Key]
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

       



        public List<ProductCategory> ProductCategories { get; set; }


    }
}
