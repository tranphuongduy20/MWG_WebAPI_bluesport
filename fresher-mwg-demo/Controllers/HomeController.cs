using fresher_mwg_demo.ViewModels;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fresher_mwg_demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var vm = new vmHome
            {
                lsBanber = GetBanners()
            };
            return View("~/Views/Home/Index1.cshtml", vm);
        }

        private List<fresher_mwg_demo.Models.BannerModel> GetBanners()
        {
            // to do call api 

            var data = new List<fresher_mwg_demo.Models.BannerModel>();


            #region Get Data DTO => API
            var client = new RestClient("http://172.16.2.198:2060/apibanner/getbannerbysite?siteID=2&categoryID=0&placeID=1535");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ModelsDTO.BannerDTO>>(response.Content);
            #endregion

            #region Mapping Data DTO => Model 

            foreach (var item in dataDto)
            {
                data.Add(new Models.BannerModel()
                {
                    ImageUrl = item.DmxContent,
                    Name = item.Description,
                    idxyz = item.BannerID
                });
            }

            #endregion

            #region Data
            return data;
            #endregion


            //return new List<fresher_mwg_demo.Models.BannerModel>()
            //{
            //    new fresher_mwg_demo.Models.BannerModel()
            //    {
            //        ImageUrl = "./images/banner.jpeg",
            //        Name = "Thể thao nam"
            //    },
            //    new fresher_mwg_demo.Models.BannerModel()
            //    {
            //        ImageUrl = "./images/banner.jpeg",
            //        Name = "Thể thao nu"
            //    },
            //    new fresher_mwg_demo.Models.BannerModel()
            //    {
            //        ImageUrl = "./images/banner.jpeg",
            //        Name = "Thể thao nu"
            //    },
            //};
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("~/Views/Home/Index1.cshtml");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

}