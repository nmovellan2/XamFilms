﻿using System;
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
    public partial class DetailMovieView : ContentPage
    {
        protected Movie movie;
        public DetailMovieView()
        {
            InitializeComponent();
            movie = InicializarPelicula();
            lblTitleMovie.Text = movie.Title;
            imgMovie.Source = movie.Poster;
            lblContenidoSinopsis.Text = movie.Plot;
            lblContenidoReparto.Text = movie.Actors;
            lblCountry.Text = movie.Country;
            lblWriter.Text = movie.Writer;
        }

        //inicializar pelicula de ejemplo
        public static Movie InicializarPelicula()
        {

            Movie movie = new Movie()
            {
                Title = "Back to the Future",
                Year = "1985",
                Rated = "PG",
                Released = "03 Jul 1985",
                Runtime = "116 min",
                Genre = "Adventure, Comedy, Sci-Fi",
                Director = "Robert Zemeckis",
                Writer = "Robert Zemeckis, Bob Gale",
                Actors = "Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover",
                Plot = "Marty McFly, a 17-year-old high school student, is accidentally sent thirty years into the past in a time-traveling DeLorean invented by his close friend, the maverick scientist Doc Brown.",
                Language = "English",
                Country = "USA",
                Awards = "Won 1 Oscar. Another 19 wins & 25 nominations.",
                Website = "http://www.bttfmovie.com/",
                Poster = "https://ia.media-imdb.com/images/M/MV5BZmU0M2Y1OGUtZjIxNi00ZjBkLTg1MjgtOWIyNThiZWIwYjRiXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg",
                Ratings = new List<Rating>()
                    {
                        new Rating() { Source = "Internet Movie Database", Value= "8.5/10" },
                        new Rating() { Source = "Rotten Tomatoes", Value= "96%" },
                        new Rating() { Source = "Metacritic", Value= "86/100" },
                    }
            };

            return movie;
        }    
	}

    

}