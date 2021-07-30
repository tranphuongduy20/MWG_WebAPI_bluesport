using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fresher_mwg.Models
{
    public class ProductModel
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public string Price { get; set; }
        public string DiscountPrice { get; set; }
        public double PercentSale { get; set; }
        public double PercentProfit { get; set; }
        public string Image { get; set; }
        public List<GroupImageModel> GroupImage { get; set; }
    }
}