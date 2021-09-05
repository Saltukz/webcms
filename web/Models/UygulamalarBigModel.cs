using entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web.Models
{
    public class UygulamalarBigModel
    {
        public List<string> Codes { get; set; }

        public List<string> AllCultures { get; set; }


        public string RequestedData { get; set; }
        public IFormFile fileDataSheet { get; set; }
        public IFormFile fileBrosur { get; set; }
        public IFormFile filePdf { get; set; }

        public IFormFile fileSayfaResmi { get; set; }
        public PageInfo PageInfo { get; set; }

        public List<Uygulama> uygulamalarList { get; set; }

        

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

        public string MetaTags { get; set; }


        public string SayfaResmi { get; set; }
    }
}
