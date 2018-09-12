using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FInal.BIL;
using FInal.Gateway;
using FInal.Models;

namespace FInal.Controllers
{
    public class SaveCourseController : Controller
    {
      DepartmentManage aManage = new DepartmentManage();
        //
        // GET: /SaveCourse/
      [HttpGet]
        public ActionResult Index()
        {
           List<Department> departments= aManage.ViewAllDepartment();
           return View(departments);
        }
      [HttpPost]
      public ActionResult Index(SaveCourse data)
      {
        ViewBag.Message = aManage.SaveCourse(data);
        return View();
      }
	}
}