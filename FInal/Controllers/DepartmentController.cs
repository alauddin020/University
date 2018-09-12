using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FInal.BIL;
using FInal.Models;

namespace FInal.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentManage aDepartmentManage = new DepartmentManage();
        //
        // GET: /Department/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Department data)
        {
            ViewBag.Message = aDepartmentManage.SaveDepartment(data);
            return View();
        }
        public ActionResult ViewDepartment()
        {
            ViewBag.Message = aDepartmentManage.ViewAllDepartment();
            return View();
        }
	}
}