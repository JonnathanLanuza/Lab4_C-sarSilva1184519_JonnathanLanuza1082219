using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.IO;
using Lab4_CésarSilva1184519_JonnathanLanuza1082219.Models.Data;
using System.Threading;
using Microsoft.AspNetCore.Hosting;

namespace Lab4_CésarSilva1184519_JonnathanLanuza1082219.Controllers
{
    public class HashController : Controller
    {
        List<string> MDeveloperList = new List<string>();
        List<string> MDevDataList = new List<string>();
        int[,] array = new int[25, 25];
        //int x = 0;
        //int y = 0;

        // GET: HashController
        public ActionResult Index()
        {
            return View(Singleton.Instance.MDeveloperList);
        }

        public ActionResult CreateDev()
        {
            return View();
        }

        public ActionResult CreateDevTask()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Title)
        {
            ViewData["SearchName"] = Title;
            Singleton.Instance.MDeveloperList.Clear();

            if (Title != null)
            {
                for (int i = 0; i < Singleton.Instance.MDeveloperList.Count() - 1; i++)
                {
                    if (Singleton.Instance.MDeveloperList[i].Title == Title)
                    {
                        Singleton.Instance.MDeveloperList.Add(Singleton.Instance.MDeveloperList[i]);
                    }
                }
                return View(Singleton.Instance.MDeveloperList);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(IFormCollection collection)
        {
            try
            {
                var newdev = new Models.Developer
                {
                    Title = collection["Title"],
                    Description = collection["Description"],
                    Proyect = collection["Proyect"],
                    Priority = Convert.ToInt32(collection["Priority"]),
                    DueDate = collection["DueDate"]
                };
                MDeveloperList.Add(newdev.ToString());
                Singleton.Instance.MDeveloperList.Add(newdev);
                return RedirectToAction(nameof(Index));
                //for (int i = x; i < 25; i++)
                //{
                //    for (int j = y; j < 25; j++)
                //    {
                //        int[x, y] = Title;
                //    }
                //}
            }
            catch
            {
                return View();
            }
            //x = x + 1;
            //y = y + 1;
        }

        // GET: HashController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HashController/CreateDev
        public ActionResult Create()
        {
            return View();
        }

        // POST: HashController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HashController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HashController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HashController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HashController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
