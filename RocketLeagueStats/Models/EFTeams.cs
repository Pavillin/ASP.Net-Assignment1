using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RocketLeagueStats.Models
{
    public class EFTeams : ITeamsMock
    {
        //db connection moved here from teams controller
        private RocketLeagueStatsModel db = new RocketLeagueStatsModel();
        public IQueryable<team> teams { get { return db.teams; } }

        public void Delete(team team)
        {
            db.teams.Remove(team);
            db.SaveChanges();
        }

        public team Save(team team)
        {
            if (team.teamid == 0)
            {
                db.teams.Add(team);
            }
            else
            {
                db.Entry(team).State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            return team;
        }
    }
}