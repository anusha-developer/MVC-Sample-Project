using ProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample

        static List<RegistractionModel> Registractions = new List<RegistractionModel>();
        public ActionResult Index()
        {
            return View(Registractions);
        }
        //  GET:  Sample/Details/1
        public ActionResult Details(RegistractionModel Registractions)
        {
            return View(Registractions);
        }
        public ActionResult Create()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(RegistractionModel reg)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", reg);
            }
            Registractions.Add(reg);
            return RedirectToAction("Index");
        }
        //GET: Edit
           /* public ActionResult Edit(Int32 ProjectId)
        {
            var register = objContext.TblCompanyTask.Where(x => x.id == ProjectId).FirstOrDefault();
            if (register != null)
            {
                TempData["ProjectId"] = ProjectId;
                TempData.Keep();
                return View(register);
            }
            return View();
        }
        //GET: Delete/1
        public ActionResult Delete(int ProjectId)
        {
            if (ProjectId > 0)
            {
                var ProjectId = objContext.TblCompanyTask.Where(x => x.id == ProjectId).FirstOrDefault();
                if (ProjectId != null)
                {
                    objContext.Entry(ProjectId).State = EntityState.Deleted;
                    objContext.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }*/


    }
} 