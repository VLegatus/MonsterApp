using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonsterApp.Models;
using MonsterApp.Models;

namespace MonsterApp.Controllers
{
    public class MonsterController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Monster
        public ActionResult Index()
        {
            //MonsterList monsterList = new MonsterList() {
            //     new Monster(){
            var name = db.Monsters.Where(c => c.Id == 1).First().Name;
            var type = db.Monsters.Where(c => c.Id == 1).First().Type;
            var gender = db.Monsters.Where(c => c.Id == 1).First().Gender;
            var description = db.Monsters.Where(c => c.Id == 1).First().Description;


            //     }
            //}
            return View();
        }

        // GET: Monster/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Monster/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Monster/Create

        [HttpPost]
        public ActionResult Create(Monster monster)
        {
            try
            {
                db.Monsters.Add(monster);
                db.SaveChanges();
                return View();
                //return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: Monster/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Monster/Edit/5
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

        // GET: Monster/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Monster/Delete/5
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
