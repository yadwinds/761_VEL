using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;


namespace GetSkills.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Add Session ID and Guid, Set up allowed response time
            System.Web.HttpContext.Current.Session.Add("SessionID", Guid.NewGuid().ToString());
            System.Web.HttpContext.Current.Session.Timeout = 5;

            string[] data = null;
            string path = Server.MapPath("~/App_Data/count.txt");       
            System.Web.HttpContext.Current.Application.Lock();      //Block the application to get the sync data
            if (System.IO.File.Exists(path))        //If count.txt exists, read the data.
            {
                data = System.IO.File.ReadAllLines(path);
            }
            else                                    //If count.txt doesn't exists, create the file and set up to start count from 0.
            {
                System.IO.File.Create(Server.MapPath("~/App_Data/count.txt")).Dispose();
                data = new string[1] { "0" };
            }
            
            System.Web.HttpContext.Current.Application["count"] = Convert.ToInt32(data[0]) + 1; //Get currently online visitors amount and then add 1
            string count = System.Web.HttpContext.Current.Application["count"].ToString();
        
            System.IO.File.WriteAllText(path, count);           //Write data into file
            System.Web.HttpContext.Current.Application.UnLock();       //Unlock Application session

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

        public ActionResult TeamProfile()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }
    }
}