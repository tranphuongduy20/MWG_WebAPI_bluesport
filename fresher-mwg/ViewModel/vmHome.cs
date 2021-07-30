using fresher_mwg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fresher_mwg.ViewModel
{
    public class vmHome
    {
        public List<BannerModel> Banners { get; set; }
        public List<TitleProductModel> TitleProductsAll { get; set; }
        public List<ProductModel> ProductsAll { get; set; }
        public List<TitleProductModel> TitleProductsMale { get; set; }
        public List<ProductModel> ProductsMale { get; set; }
        public List<TitleProductModel> TitleProductsFemale { get; set; }
        public List<ProductModel> ProductsFemale { get; set; }
        public List<PageBrandModel> PageBrand { get; internal set; }
        public List<BannerModel> BannerFooter { get; internal set; }
        public List<LocationModel> Location { get; internal set; }
        public int TotalLocation { get; set; }
        public List<CommitmentModel> Commitment { get; internal set; }
    }
}