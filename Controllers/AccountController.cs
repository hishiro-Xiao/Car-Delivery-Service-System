using Car_Delivery_Service_System.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Car_Delivery_Service_System.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        // GET: Account/Details/5
        public ActionResult Details(int id)
        {
            DatabaseEntities db = new DatabaseEntities();
            account ac = db.account.Find(id);
            return View("Details", ac);
        }

        // GET: Account/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
        [HttpPost]  
        public ActionResult Create(FormCollection formCollection)
        {
            try
            {
                DatabaseEntities db = new DatabaseEntities();

                int id = db.account.Count() + 1;
                String email = formCollection.Get("email");
                String password = formCollection.Get("password");
                String address = formCollection.Get("address");
                String phoneNum = formCollection.Get("phoneNum");
                int role = int.Parse(formCollection.Get("role"));
                Boolean status = Boolean.Parse(formCollection.Get("status"));

                account ac = new account();
                ac.id = id;
                ac.email = email;                
                ac.password = password;
                ac.address = address;
                ac.phoneNum = phoneNum;
                ac.role = role;
                ac.status = status;

                db.account.Add(ac);
                db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // GET: Account/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Account/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Account/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Account/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
