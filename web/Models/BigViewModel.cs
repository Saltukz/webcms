using entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web.Models
{
    public class BigViewModel
    {
      public UygulamalarModel UygulamalarModel { get; set; }
        public FormModelContact FormModelContact { get; set; }

        public CategoryModel CategoryModel { get; set; }

        public HaberlerModel HaberlerModel { get; set; }

        public HaberDetailModel HaberDetailModel { get; set; }

        public KariyerModel KariyerModel { get; set; }

        public ProjectModel ProjectModel { get; set; }

        public DokumanModel DokumanModel { get; set; }

        public SearchModel SearchModel { get; set; }

        public LayoutModel LayoutModel { get; set; }

        public string returnUrl { get; set; }

      
    }
}
