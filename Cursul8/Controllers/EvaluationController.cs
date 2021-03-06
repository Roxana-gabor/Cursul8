﻿using Cursul8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cursul8.Controllers
{
    public class EvaluationController : Controller
    {
        public static List<ProjectEvaluation> ListOfProjects = new List<ProjectEvaluation>
        {
           new ProjectEvaluation() {id=1 , name="MVC", city="Cluj", country="Romania", rating=9 },
           new ProjectEvaluation() {id=2, name = "MVC2", city = "<script> alert('xss');</script>", country = "Romania", rating = 5 },
           new ProjectEvaluation() {id=3, name="MVC3", city="Suceava", country="Romania", rating=10 }
          };
        

        // GET: Evaluation
        public ActionResult Index()
        {
           return View(ListOfProjects);

        }

        // GET: Evaluation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Evaluation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Evaluation/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Evaluation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Evaluation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        var evaluation = ListOfProjects.Single(e => e.id == id);
        if(TryUpdateModel(evaluation))
        {
            return RedirectToAction("Index");
        }
        return View(evaluation);
        }

        // GET: Evaluation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Evaluation/Delete/5
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
