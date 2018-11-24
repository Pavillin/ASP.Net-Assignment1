using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketLeagueStats.Models
{
    public interface ITeamsMock
    {
        IQueryable<team> teams { get; }

        team Save(team team);
        void Delete(team team);
    }
}
