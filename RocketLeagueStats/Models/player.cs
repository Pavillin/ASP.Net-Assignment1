namespace RocketLeagueStats.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class player
    {
        public int playerid { get; set; }

        public int? teamid { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public int goals { get; set; }

        public int assists { get; set; }

        public int saves { get; set; }

        public int shots { get; set; }

        public virtual team team { get; set; }
    }
}
