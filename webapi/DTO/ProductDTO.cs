using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.DTO
{
    public class ProductDTO
    {
        public string Code { get; set; }

        public string Renk { get; set; }

        public int SosisIciAdet { get; set; }

        public int KoliIciAdet { get; set; }

        public string ImageUrl { get; set; }
    }
}
