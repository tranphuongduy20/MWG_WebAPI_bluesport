using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fresher_mwg.Controllers
{
    public class APIController : Controller
    {


        public class BannerApiModel
        {
            public string Image { get; set; }
            public string TitleName { get; set; }
            public string Detail { get; set; }
        }


        // GET: API
        public ActionResult GetBaner()
        {
            return Json( new List<BannerApiModel>()
                {
                    new BannerApiModel()
                    {
                        Image = "/Contents/images/banner.jpeg",
                        TitleName="Thời trang nam"
                    },
                    new BannerApiModel()
                    {
                        Image = "/Contents/images/banner.jpeg",
                        TitleName="Thời trang nam"
                    },
                    new BannerApiModel()
                    {
                        Image = "/Contents/images/banner.jpeg",
                        TitleName="Thời trang nam"
                    }
                },
                
                JsonRequestBehavior.AllowGet);
        }
    }



}