
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fresher_mwg.Models.Detail
{
    public class SaleModel
    {
        public string Title { get; set; }
        public List<SaleInfoModel> ProductSaleInfos { get; set; }
    }
}