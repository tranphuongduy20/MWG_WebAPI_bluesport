using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fresher_mwg.Models.Detail
{
    public class PaymentInfoModel
    {
        public string Color { get; set; }
        public int Size { get; set; }
        public List<ProductImageModel> ProductImages { get; set; }
        public List<ProductSizeModel> ProductSizes { get; set; }
        public SaleModel ProductSale { get; internal set; }
    }
}