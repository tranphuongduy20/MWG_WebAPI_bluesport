using fresher_mwg.Models;
using fresher_mwg.ViewModel;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fresher_mwg.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var vm = new vmHome()
            {
                Banners = ServiceGetBanner(),
                TitleProductsAll = new List<TitleProductModel>()
                {
                    new TitleProductModel {
                        Name = "Tất cả",
                        CheckAction = true
                    },
                    new TitleProductModel {
                        Name = "Xe đạp",
                        CheckAction = false
                    },
                    new TitleProductModel {
                        Name = "Chạy bộ",
                        CheckAction = false
                    },
                    new TitleProductModel {
                        Name = "Dụng cụ",
                        CheckAction = false
                    },
                    new TitleProductModel {
                        Name = "Xe máy",
                        CheckAction = false
                    }
                },
                ProductsAll = new List<ProductModel>()
                {
                    new ProductModel
                    {
                        Brand = "ADIDAS",
                        Name = "Adizero Takumi Sen 7 Tokyo",
                        Detail = "Adizero Takumi Sen 7 Tokyo",
                        Price = "8.205.000đ",
                        DiscountPrice = "6.964.000đ",
                        PercentSale = 20,
                        PercentProfit = 0,
                        Image = "/Contents/images/img01.png",
                        GroupImage = new List<GroupImageModel>()
                        {
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = true
                            },
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = false
                            },
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = false
                            }
                        }
                    },
                    new ProductModel
                    {
                        Brand = "ADIDAS",
                        Name = "Adizero Takumi Sen 7 Tokyo",
                        Detail = "Adizero Takumi Sen 7 Tokyo",
                        Price = "8.205.000đ",
                        DiscountPrice = "6.964.000đ",
                        PercentSale = 20,
                        PercentProfit = 0,
                        Image = "/Contents/images/img01.png",
                        GroupImage = new List<GroupImageModel>()
                        {
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = true
                            },
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = false
                            },
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = false
                            }
                        }
                    },
                    new ProductModel
                    {
                        Brand = "ADIDAS",
                        Name = "Adizero Takumi Sen 7 Tokyo",
                        Detail = "Adizero Takumi Sen 7 Tokyo",
                        Price = "8.205.000đ",
                        DiscountPrice = "6.964.000đ",
                        PercentSale = 20,
                        PercentProfit = 0,
                        Image = "/Contents/images/img01.png",
                        GroupImage = new List<GroupImageModel>()
                        {
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = false
                            },
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = true
                            },
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = false
                            }
                        }
                    },
                },
                TitleProductsMale = new List<TitleProductModel>()
                {
                    new TitleProductModel {
                        Name = "Tất cả",
                        CheckAction = true
                    },
                    new TitleProductModel {
                        Name = "Xe đạp",
                        CheckAction = false
                    },
                    new TitleProductModel {
                        Name = "Chạy bộ",
                        CheckAction = false
                    },
                    new TitleProductModel {
                        Name = "Dụng cụ",
                        CheckAction = false
                    },
                    new TitleProductModel {
                        Name = "Xe máy",
                        CheckAction = false
                    }
                },
                ProductsMale = new List<ProductModel>()
                {
                    new ProductModel
                    {
                        Brand = "ADIDAS",
                        Name = "Adizero Takumi Sen 7 Tokyo",
                        Detail = "Adizero Takumi Sen 7 Tokyo",
                        Price = "8.205.000đ",
                        DiscountPrice = "6.964.000đ",
                        PercentSale = 20,
                        PercentProfit = 0,
                        Image = "/Contents/images/img01.png",
                    },
                    new ProductModel
                    {
                        Brand = "ADIDAS",
                        Name = "Adizero Takumi Sen 7 Tokyo",
                        Detail = "Adizero Takumi Sen 7 Tokyo",
                        Price = "8.205.000đ",
                        DiscountPrice = "6.964.000đ",
                        PercentSale = 20,
                        PercentProfit = 0,
                        Image = "/Contents/images/img01.png",
                    },
                    new ProductModel
                    {
                        Brand = "ADIDAS",
                        Name = "Adizero Takumi Sen 7 Tokyo",
                        Detail = "Adizero Takumi Sen 7 Tokyo",
                        Price = "8.205.000đ",
                        DiscountPrice = "6.964.000đ",
                        PercentSale = 20,
                        PercentProfit = 0,
                        Image = "/Contents/images/img01.png",
                        GroupImage = new List<GroupImageModel>()
                        {
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = true
                            },
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = false
                            },
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = false
                            }
                        }
                    },
                    new ProductModel
                    {
                        Brand = "ADIDAS",
                        Name = "Adizero Takumi Sen 7 Tokyo",
                        Detail = "Adizero Takumi Sen 7 Tokyo",
                        Price = "8.205.000đ",
                        DiscountPrice = "6.964.000đ",
                        PercentSale = 20,
                        PercentProfit = 0,
                        Image = "/Contents/images/img01.png",
                        GroupImage = new List<GroupImageModel>()
                        {
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = false
                            },
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = true
                            },
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = false
                            }
                        }
                    },
                },
                TitleProductsFemale = new List<TitleProductModel>()
                {
                    new TitleProductModel {
                        Name = "Tất cả",
                        CheckAction = true
                    },
                    new TitleProductModel {
                        Name = "Xe đạp",
                        CheckAction = false
                    },
                    new TitleProductModel {
                        Name = "Chạy bộ",
                        CheckAction = false
                    },
                    new TitleProductModel {
                        Name = "Dụng cụ",
                        CheckAction = false
                    },
                    new TitleProductModel {
                        Name = "Xe máy",
                        CheckAction = false
                    }
                },
                ProductsFemale = new List<ProductModel>()
                {
                    new ProductModel
                    {
                        Brand = "ADIDAS",
                        Name = "Adizero Takumi Sen 7 Tokyo",
                        Detail = "Adizero Takumi Sen 7 Tokyo",
                        Price = "8.205.000đ",
                        DiscountPrice = "6.964.000đ",
                        PercentSale = 20,
                        PercentProfit = 0,
                        Image = "/Contents/images/img01.png",
                        GroupImage = new List<GroupImageModel>()
                        {
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = true
                            },
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = false
                            },
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = false
                            }
                        }
                    },
                    new ProductModel
                    {
                        Brand = "ADIDAS",
                        Name = "Adizero Takumi Sen 7 Tokyo",
                        Detail = "Adizero Takumi Sen 7 Tokyo",
                        Price = "8.205.000đ",
                        DiscountPrice = "6.964.000đ",
                        PercentSale = 20,
                        PercentProfit = 0,
                        Image = "/Contents/images/img01.png",
                    },
                    new ProductModel
                    {
                        Brand = "ADIDAS",
                        Name = "Adizero Takumi Sen 7 Tokyo",
                        Detail = "Adizero Takumi Sen 7 Tokyo",
                        Price = "8.205.000đ",
                        DiscountPrice = "6.964.000đ",
                        PercentSale = 20,
                        PercentProfit = 0,
                        Image = "/Contents/images/img01.png",
                        GroupImage = new List<GroupImageModel>()
                        {
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = true
                            },
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = false
                            },
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = false
                            }
                        }
                    },
                    new ProductModel
                    {
                        Brand = "ADIDAS",
                        Name = "Adizero Takumi Sen 7 Tokyo",
                        Detail = "Adizero Takumi Sen 7 Tokyo",
                        Price = "8.205.000đ",
                        DiscountPrice = "6.964.000đ",
                        PercentSale = 20,
                        PercentProfit = 0,
                        Image = "/Contents/images/img01.png",
                        GroupImage = new List<GroupImageModel>()
                        {
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = false
                            },
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = true
                            },
                            new GroupImageModel
                            {
                                Image = "/Contents/images/img-color02.png",
                                CheckActive = false
                            }
                        }
                    },
                },
                PageBrand = new List<PageBrandModel>()
                {
                    new PageBrandModel
                    {
                        BrandModel = new List<BrandModel>()
                        {
                            new BrandModel
                            {
                                image = "/Contents/images/img_thuonghieu01.png",
                                path = "thuong hieu",
                                width = 68,
                                height = 38
                            },
                            new BrandModel
                            {
                                image = "/Contents/images/img_thuonghieu02.png",
                                path = "thuong hieu",
                                width = 62,
                                height = 37
                            },
                            new BrandModel
                            {
                                image = "/Contents/images/img_thuonghieu03.png",
                                path = "thuong hieu",
                                width = 76,
                                height = 28
                            },
                            new BrandModel
                            {
                                image = "/Contents/images/img_thuonghieu04.png",
                                path = "thuong hieu",
                                width = 58,
                                height = 29
                            },
                            new BrandModel
                            {
                                image = "/Contents/images/img_thuonghieu05.png",
                                path = "thuong hieu",
                                width = 65,
                                height = 18
                            },
                            new BrandModel
                            {
                                image = "/Contents/images/img_thuonghieu06.png",
                                path = "thuong hieu",
                                width = 66,
                                height = 44
                            },
                        }
                    },
                    new PageBrandModel
                    {
                        BrandModel = new List<BrandModel>()
                        {
                            new BrandModel
                            {
                                image = "/Contents/images/img_thuonghieu01.png",
                                path = "thuong hieu",
                                width = 68,
                                height = 38
                            },
                            new BrandModel
                            {
                                image = "/Contents/images/img_thuonghieu02.png",
                                path = "thuong hieu",
                                width = 62,
                                height = 37
                            },
                            new BrandModel
                            {
                                image = "/Contents/images/img_thuonghieu03.png",
                                path = "thuong hieu",
                                width = 76,
                                height = 28
                            },
                            new BrandModel
                            {
                                image = "/Contents/images/img_thuonghieu04.png",
                                path = "thuong hieu",
                                width = 58,
                                height = 29
                            },
                            new BrandModel
                            {
                                image = "/Contents/images/img_thuonghieu05.png",
                                path = "thuong hieu",
                                width = 65,
                                height = 18
                            },
                            new BrandModel
                            {
                                image = "/Contents/images/img_thuonghieu06.png",
                                path = "thuong hieu",
                                width = 66,
                                height = 44
                            },
                        }
                    },
                    new PageBrandModel
                    {
                        BrandModel = new List<BrandModel>()
                        {
                            new BrandModel
                            {
                                image = "/Contents/images/img_thuonghieu01.png",
                                path = "thuong hieu",
                                width = 68,
                                height = 38
                            },
                            new BrandModel
                            {
                                image = "/Contents/images/img_thuonghieu02.png",
                                path = "thuong hieu",
                                width = 62,
                                height = 37
                            },
                            new BrandModel
                            {
                                image = "/Contents/images/img_thuonghieu03.png",
                                path = "thuong hieu",
                                width = 76,
                                height = 28
                            },
                            new BrandModel
                            {
                                image = "/Contents/images/img_thuonghieu04.png",
                                path = "thuong hieu",
                                width = 58,
                                height = 29
                            },
                            new BrandModel
                            {
                                image = "/Contents/images/img_thuonghieu05.png",
                                path = "thuong hieu",
                                width = 65,
                                height = 18
                            },
                            new BrandModel
                            {
                                image = "/Contents/images/img_thuonghieu06.png",
                                path = "thuong hieu",
                                width = 66,
                                height = 44
                            },
                        }
                    }
                },
                BannerFooter = new List<BannerModel>()
                {
                    new BannerModel
                    {
                        ImageUrl = "Contents/images/img_trademark.jpeg",
                        Title = "Không gian trẻ trung, hiện đại tư vấn chuyên nghiệp, tận tình",
                        Detail = "Không gian trẻ trung, hiện đại tư vấn chuyên nghiệp, tận tình"
                    },
                    new BannerModel
                    {
                        ImageUrl = "Contents/images/img_trademark.jpeg",
                        Title = "Không gian trẻ trung, hiện đại tư vấn chuyên nghiệp, tận tình",
                        Detail = "Không gian trẻ trung, hiện đại tư vấn chuyên nghiệp, tận tình"
                    },
                    new BannerModel
                    {
                        ImageUrl = "Contents/images/img_trademark.jpeg",
                        Title = "Không gian trẻ trung, hiện đại tư vấn chuyên nghiệp, tận tình",
                        Detail = "Không gian trẻ trung, hiện đại tư vấn chuyên nghiệp, tận tình"
                    }
                },
                Location = new List<LocationModel>()
                {
                    new LocationModel
                    {
                        Path = "#",
                        Name = "Bluesport hàng xanh",
                        Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh TP. Hồ Chí Minh"
                    },
                    new LocationModel
                    {
                        Path = "#",
                        Name = "Bluesport hàng xanh",
                        Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh TP. Hồ Chí Minh"
                    },
                    new LocationModel
                    {
                        Path = "#",
                        Name = "Bluesport hàng xanh",
                        Address = "294 Xô Viết nghệ Tĩnh, P.21, Q.Bình Thạnh TP. Hồ Chí Minh"
                    }
                },
                TotalLocation = 3,
                Commitment = new List<CommitmentModel>()
                {
                    new CommitmentModel
                    {
                        Icon="icon-chinhhang",
                        Name="Chính hãng 100%",
                        Detail="Hơn 100 thương hiệu nổi tiếng",
                    },
                    new CommitmentModel
                    {
                        Icon="icon-mpgiaohang",
                        Name="Miễn phí giao hàng",
                        Detail="Cho đơn hàng trên 500.000đ"
                    },
                    new CommitmentModel
                    {
                        Icon="icon-doi1",
                        Name="1 đổi 1 trong vòng 1 năm",
                        Detail="Tại 200 cửa hàng trên toàn quốc",
                        PathText="Xem chi tiết",
                        PathDetail="#"
                    },
                    new CommitmentModel
                    {
                        TextIcon="0%",
                        Name="Trả góp 0%",
                        Detail="Qua thẻ hoặc duyệt hồ sơ với mọi sản phẩm trên 1.5 triệu",
                    }
                }
            };
            return View("~/Views/Home/Index.cshtml", vm);
        }

        public ActionResult Menu()
        {
            ServiceGetCategory();
            return PartialView("~/Views/Common/_ParitalHeader.cshtml", ServiceGetCategory());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Detail()
        {
            return View();
        }


        public class BannerApiDTO
        {
            public string Image { get; set; }
            public string TitleName { get; set; }
            public string Detail { get; set; }
        }

        // Function
        public List<Models.BannerModel> ServiceGetBanner()
        {
            var client = new RestClient("https://localhost:44314/api/GetBaner");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine();

            var dataJson = response.Content;

            var bannerDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<BannerApiDTO>>(dataJson);

            var model = new List<Models.BannerModel>();

            #region Mapping
            foreach (var item in bannerDto)
            {
                model.Add(new BannerModel()
                {
                    Detail = item.Detail,
                    ImageUrl = item.Image,
                    Title = item.TitleName
                });
            }
            #endregion


            return model;

        }

        public List<CategoryModel> ServiceGetCategory()
        {
            var client = new RestClient("http://10.1.4.123:2060//apicategory/getallcategories?siteID=1&langID=vi-VN");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CategoryModelDTO>>(response.Content).Take(6);
            var result = new List<CategoryModel>();
            foreach (var item in data)
            {
                result.Add(new CategoryModel()
                {
                    CategoryID=item.CategoryID,
                    CategoryName=item.CategoryName
                });
            }
            return result;
        } 
    }
}