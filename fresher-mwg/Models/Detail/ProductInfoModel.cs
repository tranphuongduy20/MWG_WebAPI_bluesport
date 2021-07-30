using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fresher_mwg.Models.Detail
{
    public class ProductInfoModel
    {
        public string Brand { get; set; }
        public string Detail { get; set; }
        public int Status { get; set; }
        public string Price { get; set; }
        public string PriceAfter { get; set; }
        public float Sale { get; set; }
        public List<string> Features { get; set; }
        public List<CommitmentModel> Commitments { get; set; }
    }
}