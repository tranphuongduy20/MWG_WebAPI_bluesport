using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fresher_mwg_demo.ViewModels
{
    public class vmHome
    {
        public vmHome()
        {
            lsBanber = new List<Models.BannerModel>();
        }
        public List<fresher_mwg_demo.Models.BannerModel> lsBanber { get; set; }

        public List<int> lsStore { get; set; }
    }
}