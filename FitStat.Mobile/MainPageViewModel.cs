using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Services;
using Services.Abstractions;

namespace FitStat.Mobile
{
    public class MainPageViewModel
    {
        public ICommand SignInCommand { get; set; }
        public ICommand UnRegistryCommand { get; set; }
        public ICommand RegistryCommand { get; set; }
        public ICommand DateAndBranchCommand { get; set; }
        public IServiceManager serviceManager { get; set; }

        public MainPageViewModel()
        {
            SignInCommand = new Command(async () => await SignIn());

            UnRegistryCommand = new Command(async () => await UnRegistry());

            DateAndBranchCommand = new Command(async () => await DateAndBranch());

            RegistryCommand = new Command(async () => await Registry());

        }

        public async Task DateAndBranch() => await Shell.Current.GoToAsync("DateAndBranchPage");
        public async Task Registry()      => await Shell.Current.GoToAsync("RegistryPage");
        public async Task UnRegistry()    => await Application.Current.MainPage.DisplayAlert("Информация о посещении:", "Последняя посещенная группа: \"Aэробика\"", "", "Закрыть");
        public async Task SignIn()        => await Shell.Current.GoToAsync("SignInPage");

        //public async Task SignIn()
        //{
            //if (false) 
        //       {
        //          await serviceManager._userService.GetCurrentUser();
        //       }
        //}


    }
}
