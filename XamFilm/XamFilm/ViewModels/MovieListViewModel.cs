using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamFilm.Models;
using XamFilm.Services;
using XamFilm.ViewModels.Base;

namespace XamFilm.ViewModels
{
    public class MovieListViewModel:ViewModelBase
    {
        private IDataService _dataService;
        #region Constructores
        public MovieListViewModel(IDataService DataService)
        {
            _dataService = DataService;
           
        }

        #endregion
        #region Propiedades

        private List<Movie> _movies;
        public List<Movie> Movies
        {
            get => _movies;
            set
            {
                _movies = value;
                OnPropertyChanged();
            }
        }

        #endregion


        #region Funciones
        private async void LoadData()
        {
         IsBusy = true;
         Movies = await _dataService.GetMoviesAsync();
            IsBusy = false;
        }
       #endregion

        }
    }
