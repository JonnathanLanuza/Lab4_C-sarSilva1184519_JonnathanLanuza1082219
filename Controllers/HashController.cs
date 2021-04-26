using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.IO;
using Lab4_CésarSilva1184519_JonnathanLanuza1082219.Models.Data;
using Lab4_CésarSilva1184519_JonnathanLanuza1082219.Models;
using System.Threading;
using Microsoft.AspNetCore.Hosting;

namespace Lab4_CésarSilva1184519_JonnathanLanuza1082219.Controllers
{
    public class HashController : Controller
    {
        //List<Developer> MDeveloperList = new List<Developer>();
        //List<DevData> MDevDataList = new List<DevData>();
        //int[,] array = new int[25, 25];

        // GET: HashController
        public ActionResult Index()
        {
            return View(Singleton.Instance.MDeveloperList);
        }

        [HttpPost]
        public ActionResult Index(string DevName)
        {
            //ViewData["SearchName"] = DevName;
            //Singleton.Instance.MDevDataList.Clear();

            //if (DevName != null)
            //{
            //    for (int i = 0; i < Singleton.Instance.MDevDataList.Count() - 1; i++)
            //    {
            //        if (Singleton.Instance.MDevDataList[i].DevName == DevName)
            //        {
            //            Singleton.Instance.MDevDataList.Add(Singleton.Instance.MDevDataList[i]);
            //        }
            //    }
            //    return View(Singleton.Instance.MDevDataList);
            //}
            return View();
        }

        // GET: HashController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HashController/Create
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
