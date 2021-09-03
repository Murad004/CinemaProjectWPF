using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using WPFProject.Command;
using WPFProject.Models;
using WPFProject.Command;
using System.Windows;

namespace WPFProject.ViewModel
{
    public class AdminAddMovieViewModel:BaseViewModel
    {
        public RelayCommand BackBtn { get; set; }
        public RelayCommand SearchBtn { get; set; }
        public RelayCommand AddMovieBtn { get; set; }
        private Film film;

        public Film Film
        {
            get { return film; }
            set { film = value; OnPropertyChanged(); }
        }
        public string ImagePath { get; set; }
        public string Minute { get; set; }
        public string Description { get; set; }
        public dynamic Data { get; set; }
        public dynamic SingleData { get; set; }

        HttpClient http = new HttpClient();

        public AdminAddMovieViewModel()
        {
            BackBtn = new RelayCommand((e) =>
              {
                  Helper.Helper.MainWindow.SecondGrid.Children.Remove(Helper.Helper.AdminAddMovieUC);
              });
            SearchBtn = new RelayCommand( async (e) =>
              {
                  Helper.Helper.Film = new Film();
                  try
                  {
                      Film = new Film();

                      HttpResponseMessage response = new HttpResponseMessage();
                      response =
                                            http.GetAsync($@"http://www.omdbapi.com/?apikey=ddee1dae&s={Helper.Helper.AdminAddMovieUC.SearchTxtBox.Text}&plot=full").Result;
                      var str = response.Content.ReadAsStringAsync().Result;
                      Data = JsonConvert.DeserializeObject(str);
                      response =
                                                http.GetAsync($@"http://www.omdbapi.com/?apikey=ddee1dae&t={Data.Search[0].Title}&plot=full").Result;
                      str = response.Content.ReadAsStringAsync().Result;
                      SingleData = JsonConvert.DeserializeObject(str);

                      

                      ImagePath = SingleData.Poster;
                      Minute = SingleData.Runtime;
                      Description = SingleData.Genre;



                      Helper.Helper.AdminAddMovieUC.AddMovieImage.Source = new BitmapImage(new Uri(
                      ImagePath, UriKind.RelativeOrAbsolute));
                      Helper.Helper.AdminAddMovieUC.FilmNameTxtBox.Text = SingleData.Title;
                      Helper.Helper.Film.Name = SingleData.Title;
                      Helper.Helper.Film.ImagePath = SingleData.Poster;
                      Helper.Helper.Film.Description = SingleData.Genre;
                      Helper.Helper.Film.Time = SingleData.RunTime;





                  }
                  catch (Exception ex)
                  {



                  }
              });
            AddMovieBtn = new RelayCommand((e) =>
              {
                  Helper.Helper.AdminMovieListUC.AdminFilmsLstBx.Items.Add(Helper.Helper.AdminAddMovieUC.FilmNameTxtBox.Text);
                  Helper.Helper.UserFilmMenuUC.UserFilmListBox.Items.Add(Helper.Helper.AdminAddMovieUC.FilmNameTxtBox.Text);
                  MessageBox.Show("Film listine elave olundu", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
              });
        }
    }
}
