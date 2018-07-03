using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamFilm.Models;

namespace XamFilm.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailSerieView : ContentPage
	{
        protected Models.Serie serie;
		public DetailSerieView ()
		{
			InitializeComponent ();
            serie = InicializarSerieEjemplo();
            lblTitleSerie.Text = serie.Title;
            imgSerie.Source = serie.Poster;
            lblContenidoCountry.Text = serie.Country;
            lblContenidoReparto.Text = serie.Actors;
            lblContenidoWriter.Text = serie.Writer;
            lblContenidoSinopsis.Text = serie.Plot;
		}
        public static Models.Serie InicializarSerieEjemplo()
        {

            var serie = new Serie()
            {
                Title = "Breaking Bad",
                Year = "2008–2013",
                Rated = "TV-MA",
                Released = "20 Jan 2008",
                Runtime = "49 min",
                Genre = "Crime, Drama, Thriller",
                Director = "N/A",
                Writer = "Vince Gilligan",
                Actors = "Bryan Cranston, Anna Gunn, Aaron Paul, Dean Norris",
                Plot = "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.",
                Language = "English, Spanish",
                Country = "USA",
                Awards = "Won 2 Golden Globes. Another 144 wins & 225 nominations.",
                Poster = "http://ia.media-imdb.com/images/M/MV5BZDNhNzhkNDctOTlmOS00NWNmLWEyODQtNWMxM2UzYmJiNGMyXkEyXkFqcGdeQXVyNTMxMjgxMzA@._V1_SX300.jpg",
                Ratings = new List<Rating>()
                    {
                        new Rating() { Source = "Internet Movie Database", Value= "9.5/10" }
                    }
            };

            return serie;
        }
	}
}