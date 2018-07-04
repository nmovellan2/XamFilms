using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamFilm.Models
{
    public class License: BindableObject
    {
       
        public string Title { get; set; }
        public string LicenseType { get; set; }
        public string URL { get; set; }

        public License(string title, string type, string url)
        {
            Title = title;
            LicenseType = type;
            URL = url;
        }
    }
}


