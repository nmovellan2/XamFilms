using System;
using System.Collections.Generic;
using System.Text;

namespace XamFilm.Models
{
    public class Episode : Item
    {
        public string SerieId { get; set; }
        public string SeasonNumber { get; set; }
        public string EpisodeNumber { get; set; }

    }
}
