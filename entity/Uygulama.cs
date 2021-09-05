using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace entity
{
    public class Uygulama
    {
        [Key]
        public int Id { get; set; }

        public string Code { get; set; }

        public string Culture { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string SeoUrl { get; set; }

        public string PdfUrl { get; set; }

        public string DataSheet { get; set; }

        public string Brosur { get; set; }

        public string MetaDescription { get; set; }

        public string SayfaResmi { get; set; }

     

   
    }
}
