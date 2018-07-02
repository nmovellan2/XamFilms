using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamFilm.Views
{

    public class MainViewMenuItem
    {
        public MainViewMenuItem()
        {
            TargetType = typeof(MainViewDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}