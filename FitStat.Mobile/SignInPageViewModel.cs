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
        private int _login;
        private int _password;
        public event PropertyChangedEventHandler? PropertyChanged;

        public int Login
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

        public int Password
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
        // наподобие с private BranchWebAPIService _branchWebAPIService; подключить какой-то нужный сервис

        public SignInPageViewModel()
        {
            PostCommand = new Command(async () => await Post());
            //чем-то заменить _branchWebAPIService = new BranchWebAPIService(new SettingsInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData))));
        }
        public async Task Post()
        {
            /*
            var ParsedLogin = Login.ToString();
            var model = await _branchWebAPIService.GetTrainingForBranchAndDay(Pars, Guid.Parse(string.IsNullOrEmpty(BranchCode) ? Guid.Empty.ToString() : BranchCode));

            if (model != null && model.Entity != null)
                await Application.Current.MainPage.DisplayAlert("Проба метода...", string.Join(";\n", model.Entity), "OK");

            #region checking for null Удалить при исправлении и раскомментировать 2 строки выше
            if (model == null)
                await Application.Current.MainPage.DisplayAlert("!!!!!.", "model == null", "OK");
            else if (model != null)
            {
                if (model.Entity == null)
                    await Application.Current.MainPage.DisplayAlert("!!!!!.", "model.Entity == null; model.result: " + model.Result ?? "null", "OK");
            }
            else if (model == null)
                await Application.Current.MainPage.DisplayAlert("!!!!!.", "model == null", "OK");
            #endregion
            */
        }




    }
}
