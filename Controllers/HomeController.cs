using Car_Delivery_Service_System.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Car_Delivery_Service_System.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if(Session["auth"] == null)
                Session["auth"] = false;

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

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection formCollection)
        {
            String email = formCollection.Get("email");
            String password = formCollection.Get("password");

            DatabaseEntities db = new DatabaseEntities();
            account ac = db.account.Where(a => a.email == email).FirstOrDefault();
            String ac_password = ac.password;

            if (password.Equals(ac_password))
            {
                Session["auth"] = true;
                Session["user_id"] = ac.id;
                Session["user_email"] = ac.email;
                Session["user_password"] = ac.password;
                Session["user_phoneNum"] = ac.phoneNum;
                Session["user_role"] = ac.role;
                Session["user_status"] = ac.status;
            }
            else
            {
                Session["auth"] = false;
            }

            return View("Index");
        }
    }
}