using fresher_mwg.Models.Detail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fresher_mwg.ViewModel
{
    public class vmDetail
    {
        public List<BannerModel> Banners { get; set; }
        public ProductInfoModel ProductInfo { get; set; }
        public PaymentInfoModel PaymentInfo { get; set; }
        public SaleModel SaleInfo { get; set; }
    }
}