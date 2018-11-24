using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RocketLeagueStats.Models;

namespace RocketLeagueStats.Controllers
{
    public class teamsController : Controller
    {
        //private RocketLeagueStatsModel db = new RocketLeagueStatsModel();
        private ITeamsMock db;

        public teamsController()
        {
            //if nothing passed to constructor, connect to the db (this is the default)
            this.db = new EFTeams();
        }

        public teamsController(ITeamsMock teamsMock)
        {
            //if we pass a mock object to the constructor, we are unit testing so no db
            this.db = teamsMock;
        }

        // GET: teams
        public ActionResult Index()
        {
            var teams = db.teams.ToList();
            return View("Index", teams);
        }

        // GET: teams/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return View("Error");
            }
            team team = db.teams.SingleOrDefault(t => t.teamid == id);
            if (team == null)
            {
                return View("Error");
            }
            return View("Details", team);
        }

        // GET: teams/Create
        [Authorize]
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: teams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "teamid,name,region,wins,losses")] team team)
        {
            if (ModelState.IsValid)
            {
                db.Save(team);
                return RedirectToAction("Index");
            }

            return View("Create", team);
        }

        // GET: teams/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View("Error");
            }
            team team = db.teams.SingleOrDefault(t => t.teamid == id);
            if (team == null)
            {
                return View("Error");
            }
            return View("Edit", team);
        }

        // POST: teams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "teamid,name,region,wins,losses")] team team)
        {
            if (ModelState.IsValid)
            {
                db.Save(team);
                return RedirectToAction("Index");
            }
            return View("Edit", team);
        }

        //// GET: teams/Delete/5
        //[Authorize]
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    team team = db.teams.Find(id);
        //    if (team == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(team);
        //}

        //// POST: teams/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    team team = db.teams.Find(id);
        //    db.teams.Remove(team);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
