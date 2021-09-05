using business.Abstract;
using entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace web.Helpers
{
    public class GetRightCategory
    {
        public IDokumanCategoryService _dokumanCategoryService;
        public IDokumanService _dokumanService;
        public GetRightCategory(IDokumanCategoryService dokumanCategoryService,
            IDokumanService dokumanService)
        {
            _dokumanCategoryService = dokumanCategoryService;
            _dokumanService = dokumanService;
        }

        public int[] GetRightCategories(int[] dize,string culture)
        {
            Console.WriteLine("sa");
            var liste = new List<DokumanCategory>();
            for(int id = 1; id<_dokumanService.GetAll().Count;id++)
            {              
                    if (dize.Contains(id))
                    {
                        var dk = _dokumanCategoryService.GetById(id);
                        liste.Add(dk);
                    }                                    
            }

            Debug.Print("deneme");
            List<int> liste2 = new List<int>();
            foreach(var category in liste)
            {
               var right = _dokumanCategoryService.GetAll()
                    .Where(i => i.Code == category.Code && category.Culture == culture)
                    .FirstOrDefault();

                liste2.Append(right.DokumanCategoryId);
            }

            int[] rightIds = liste2.ToArray();
            return rightIds;


        }
    }
}
