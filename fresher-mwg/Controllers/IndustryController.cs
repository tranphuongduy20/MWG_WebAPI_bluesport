using fresher_mwg.Models;
using fresher_mwg.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fresher_mwg.Controllers
{
    public class IndustryController : Controller
    {
        // GET: Industry
        public ActionResult Index()
        {
            var vm = new vmIndustry()
            {
                Banners = new List<BannerModel>
                {
                    new Models.BannerModel()
                    {
                        ImageUrl = "/Contents/images/banner_nganhhang01.jpeg",
                        Title = "Thể thao nam"
                    },
                    new Models.BannerModel()
                    {
                        ImageUrl = "/Contents/images/banner_nganhhang02.jpeg",
                        Title = "Thể thao nam"
                    },
                    new Models.BannerModel()
                    {
                        ImageUrl = "/Contents/images/banner_nganhhang02.jpeg",
                        Title = "Thể thao nam"
                    }
                },
                Products = new List<ProductModel>()
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
                TotalPagination = 6,
                TitleIndustry="Thể thao nữ",
                TotalPorduct=2300,
                Notes =
                {
                    "Sử dụng nước dưới 35 độ để giặt sản phẩm",
                    "Không sử dụng thuốc tẩy hoặc bột giặt có độ tẩy cao",
                    "Sử dụng túi giặt bảo quản khi dùng với máy giặt",
                    "Tránh phơi dưới ánh nắng trực tiếp để bảo quản màu sắc",
                    "Sử dụng nước dưới 35 độ để giặt sản phẩm",
                    "Không sử dụng thuốc tẩy hoặc bột giặt có độ tẩy cao",
                    "Sử dụng túi giặt bảo quản khi dùng với máy giặt",
                    "Tránh phơi dưới ánh nắng trực tiếp để bảo quản màu sắc"
                }
            };
            return View(vm);
        }
    }
}