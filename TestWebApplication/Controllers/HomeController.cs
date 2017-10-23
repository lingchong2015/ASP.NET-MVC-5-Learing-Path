using System.Web.Mvc;

namespace TestWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //[ChildActionOnly]
        public ActionResult ContactPartial()
        {
            ViewBag.Message = "It's partial view.";
            
            return PartialView(new Product() { Name = "Mac Book Pro" });
        }

        public class Product
        {
            public string Name { get; set; }
        }
    }
}