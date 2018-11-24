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
        [Display(Name = "Player")]
        public string name { get; set; }

        [Display(Name = "Goals")]
        public int goals { get; set; }

        [Display(Name = "Assists")]
        public int assists { get; set; }

        [Display(Name = "Saves")]
        public int saves { get; set; }

        [Display(Name = "Shots")]
        public int shots { get; set; }

        public virtual team team { get; set; }
    }
}

