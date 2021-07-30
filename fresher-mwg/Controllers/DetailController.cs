using fresher_mwg.Models.Detail;
using fresher_mwg.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fresher_mwg.Controllers
{
    public class DetailController : Controller
    {
        // GET: Detail
        public ActionResult Index()
        {
            var vm = new vmDetail
            {
                Banners = new List<BannerModel>
                {
                   new BannerModel
                   {
                       Path="/Contents/images/banner_chitiet.png",
                       TextAlt="Test"
                   },
                   new BannerModel
                   {
                       Path="/Contents/images/banner_chitiet.png",
                       TextAlt="Test"
                   },
                   new BannerModel
                   {
                       Path="/Contents/images/banner_chitiet.png",
                       TextAlt="Test"
                   },
                   new BannerModel
                   {
                       Path="/Contents/images/banner_chitiet.png",
                       TextAlt="Test"
                   },
                },
                ProductInfo=new ProductInfoModel
                {
                    Brand="Adidas",
                    Detail= "Originals Swift Run X trainers in green",
                    Status=1,
                    Price= "4.747.000",
                    PriceAfter= "3.797.000",
                    Sale=20,
                    Features= new List<string>
                    {
                        "Xuất sứ Việt Nam",
                        "Chất liệu da"
                    },
                    Commitments= new List<CommitmentModel>() 
                    { 
                        new CommitmentModel
                        {
                            Icon="icon-doitra",
                            Detail="Đổi trả, báo hành 30 ngày"
                        },
                        new CommitmentModel
                        {
                            Icon="icon-mienphigh",
                            Detail="Thanh toán COD + nhiều phương thức"
                        },
                        new CommitmentModel
                        {
                            Icon="icon-cod",
                            Detail="Đổi trả, báo hành 30 ngày"
                        },
                        new CommitmentModel
                        {
                            Icon="icon-phone",
                            Detail="Tổng đài 18001063"
                        },
                    }
                },
                PaymentInfo=new PaymentInfoModel
                {
                    Color="Trắng",
                    Size=42,
                    ProductImages= new List<ProductImageModel>
                    {
                        new ProductImageModel
                        {
                            PathImage="/Contents/images/img_color.png",
                            AltImage="Test",
                        },
                        new ProductImageModel
                        {
                            PathImage="/Contents/images/img_color.png",
                            AltImage="Test",
                        }
                    },
                    ProductSizes = new List<ProductSizeModel>
                    {
                        new ProductSizeModel
                        {
                            Size=40,
                            CheckActive=false
                        },
                        new ProductSizeModel
                        {
                            Size=41,
                            CheckActive=false
                        },
                        new ProductSizeModel
                        {
                            Size=42,
                            CheckActive=true
                        },
                        new ProductSizeModel
                        {
                            Size=43,
                            CheckActive=false
                        },
                        new ProductSizeModel
                        {
                            Size=44,
                            CheckActive=false
                        }
                    },                  
                },
                SaleInfo = new SaleModel
                {
                    Title = "Khuyến mãi trị giá 600.000đ (Đến 12/08)",
                    ProductSaleInfos = new List<SaleInfoModel>()
                        {
                            new SaleInfoModel
                            {
                                Detail="Dầu bôi trơn xe đạp Finish Line (Hết quà hoàn tiền 230.000₫)",
                                Title="Mua online thêm quà:",
                            },
                            new SaleInfoModel
                            {
                                Detail="Nhập mã HPBD17 giảm 3% tối đa 100.000đ khi thanh toán quét QRcode qua App của ngân hàng",
                                Path="#",
                                TitlePath="Xem chi tiết"
                            },
                            new SaleInfoModel
                            {
                                Detail="Giảm 20% cho xe đạp khi mua kèm Điện thoại, Tablet, Laptop, Điện tử, Điện lạnh, Gia dụng, Đồng hồ, Phụ kiện, Máy lọc nước từ 3 triệu trở lên",
                                Path="#",
                                TitlePath="Không kèm khuyễn mãi khác"
                            },
                            new SaleInfoModel
                            {
                                Detail="Dầu bôi trơn xe đạp Finish Line (Hết quà hoàn tiền 230.000₫)",
                                Title="Mua online thêm quà:",
                            },
                            new SaleInfoModel
                            {
                                Detail="Nhập mã HPBD17 giảm 3% tối đa 100.000đ khi thanh toán quét QRcode qua App của ngân hàng",
                                Path="#",
                                TitlePath="Xem chi tiết"
                            },
                        }
                }
            };
            return View(vm);
        }
    }
}