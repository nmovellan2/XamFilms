using System;
using System.Collections.Generic;
using System.Text;

namespace XamFilm.Models
{
    public class Serie : Item
    {
        public string TotalSeasons { get; set; }

        public List<Season> Seasons { get; set; }
    }
}
