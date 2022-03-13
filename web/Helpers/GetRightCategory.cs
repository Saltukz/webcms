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

        public async Task<int[]> GetRightCategoriesAsync(int[] dize,string culture)
        {
            Console.WriteLine("sa");
            var liste = new List<DokumanCategory>();
            var dokumanlar = await _dokumanService.GetAll();
            var count = dokumanlar.Count(); 
            for (int id = 1; id<count;id++)
            {              
                    if (dize.Contains(id))
                    {
                        var dk = await _dokumanCategoryService.GetById(id);
                        liste.Add(dk);
                    }                                    
            }

            Debug.Print("deneme");
            List<int> liste2 = new List<int>();
            foreach(var category in liste)
            {
                var right = await _dokumanCategoryService.GetAll();
                var rightlast= right.Where(i => i.Code == category.Code && category.Culture == culture)
                    .FirstOrDefault();

                liste2.Append(rightlast.DokumanCategoryId);
            }

            int[] rightIds = liste2.ToArray();
            return rightIds;


        }
    }
}
