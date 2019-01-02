using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonsterApp.Models;

namespace MonsterApp.Controllers
{
    public class MonsterController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Monster
        public ActionResult Index()
        {
            
            return View(db.Monsters.ToList());
        }

        // GET: Monster/Details/5
        public ActionResult Details(int id)
        {
            Monster monster = db.Monsters.Find(id);
            return View(monster);
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
            var monsterEdit = db.Monsters.Where(c => c.Id == id).First();
            return View(monsterEdit);
        }

        // POST: Monster/Edit/5
        [HttpPost]
        public ActionResult Edit(Monster monster)
        {
            try
            {
                var monsterToChange = db.Monsters.Where(m => m.Id == monster.Id).First();
                monsterToChange.Name = monster.Name;
                monsterToChange.Type = monster.Type;
                monsterToChange.Gender = monster.Gender;
                monsterToChange.Description = monster.Description;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Monster/Delete/5
        public ActionResult Delete(int? id)
        {
            Monster monster = db.Monsters.Find(id);
            if (monster == null)
                return HttpNotFound();
            return View(monster);
        }

        // POST: Monster/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteMonster(int id)
        {
            try
            {
                Monster monster = db.Monsters.Find(id);
                db.Monsters.Remove(monster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
