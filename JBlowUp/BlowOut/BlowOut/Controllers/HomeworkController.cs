using BlowOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class HomeworkController : Controller
    {   // instantiates a new list
        
        public static List<Homework> HomeworkList = new List<Homework>();
        // GET: Homework
        public ActionResult ShowHomework()
        {
            return View(HomeworkList);
        }

        [HttpGet]
        public ActionResult AddHomework()
        {
            ViewBag.Classs = ClasssController.ClasssList;
            return View();
        }

        [HttpPost]
        public ActionResult AddHomework(Homework myHomework)
        {
            if (ModelState.IsValid)
            {
                myHomework.Homework_Code = HomeworkList.Count() + 1;
                HomeworkList.Add(myHomework);
                return RedirectToAction("ShowHomework");

            }

            else
            {
                return View(myHomework);
            }
        }

        public ActionResult EditHomework(int tCode)
        {
            ViewBag.Classs = ClasssController.ClasssList;
            Homework oHomework = HomeworkList.Find(x => x.Homework_Code == tCode);
            return View(oHomework);
        }

        [HttpPost]
        //we receive object from the form, we search list (using a pointer)
        //if we found it, we change attributes we want to change and send control elsewhere
        public ActionResult EditHomework(Homework myModel)
        {
            var obj = HomeworkList.FirstOrDefault(x =>
            x.Homework_Code == myModel.Homework_Code);

            if (obj != null)
            {
                obj.Homework_Code = myModel.Homework_Code;
                obj.Homework_Desc = myModel.Homework_Desc;
                obj.Class_Code = myModel.Class_Code;
                obj.DueDate = myModel.DueDate;
            }
            return View("ShowHomework", HomeworkList);
        }

    }

}

