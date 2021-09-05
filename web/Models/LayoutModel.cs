using entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web.Models
{
    public class LayoutModel
    {
        public List<Category> categories { get; set; }


        public List<Uygulama> uygulamalar { get; set; }


        public List<Projects> projects { get; set; }

        public List<ProjectGalery> projectGaleries { get; set; }


       public string searchString { get; set; }

    }


}
