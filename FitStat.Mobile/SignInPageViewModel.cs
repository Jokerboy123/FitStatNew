using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Contracts.Models;
using Services;
using Services.Abstractions;
using Services.WebAPIConsume;
using System.Globalization;
using Services.IWebAPIConsume;

namespace FitStat.Mobile
{
    public class SignInPageViewModel
    {
        private string _login;
        private string _password;
        public event PropertyChangedEventHandler? PropertyChanged;

        public string Login
        {
            get => _login;
            set
            {
                if (_login != value)
                {
                    _login = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged();
                }
            }
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public ICommand PostCommand { get; set; }
        private UserWebAPIService _userWebAPIService;

        public SignInPageViewModel()
        {
            PostCommand = new Command(async () => await Post());
            _userWebAPIService = new UserWebAPIService(new SettingsInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData))));
        }
        public async Task Post() {
            var model = await _userWebAPIService.LoginUser(Login, Password);

            if (model != null && model.Entity != null)

             //   await Application.Current.MainPage.DisplayAlert("Вход... ", "Добро пожаловать, " + model.Entity.FirstName, "OK");

            await Shell.Current.GoToAsync("DateAndBranchPage");




        }
    }
}
