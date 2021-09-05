using entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web.Models
{
    public class ProjectModel
    {

        public string firstOne { get; set; }
        public IEnumerable<int> projeList;

        public Projects project { get; set; }
        public List<ProjectGalery> projectGaleries { get; set; }

        public List<string> menuList { get; set; }

        
    }
}
