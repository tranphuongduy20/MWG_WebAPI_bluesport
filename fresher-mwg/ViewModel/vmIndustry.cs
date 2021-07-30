using fresher_mwg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fresher_mwg.ViewModel
{
    public class vmIndustry
    {
        public List<BannerModel> Banners { get; set; }
        public List<ProductModel> Products { get; set; }
        public int TotalPagination { get; set; }
        public string TitleIndustry { get; set; }
        public int TotalPorduct { get; set; }
        public List<string> Notes { get; set; }
    }
}