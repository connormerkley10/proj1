using BlowOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ClasssController : Controller
    {
        public static List<Classs> ClasssList = new List<Classs>();
        // GET: Classs
        public ActionResult Index()
        {
            return View();
        }
     

        // GET: Teachers
        public ActionResult ShowClasses()
        {
            return View(ClasssList);
        }

        [HttpGet]
        public ActionResult AddClasses()
        {
            return View(); 
        }

        [HttpPost]
        public ActionResult AddClasses(Classs myClass)
        {
            if (ModelState.IsValid)
            {
                myClass.Class_Code = ClasssList.Count() + 1;
                ClasssList.Add(myClass);
                return RedirectToAction("Index", "Home");

            }
            else
            {
                return View(myClass);
            }
        }

        [HttpGet]
        public ActionResult EditClasses(int tCode)
        {
            Classs oClass = ClasssList.Find(x => x.Class_Code == tCode);
            return View(oClass);
        }

        [HttpPost]
        //we receive object from the form, we search list (using a pointer)
        //if we found it, we change attributes we want to change and send control elsewhere
        public ActionResult EditClasses(Classs myModel)
        {
            var obj = ClasssList.FirstOrDefault(x =>
            x.Class_Code == myModel.Class_Code);

            if (obj != null)
            {
                obj.Class_Title = myModel.Class_Title;
                obj.Class_Description = myModel.Class_Description;
            }
            return View("ShowClasses", ClasssList);
        }

    }
}