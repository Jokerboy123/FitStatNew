using System.Threading;
using System.Net;
using System.Windows.Input;
using Domain.Entities;
using Contracts.Models.Entities;


namespace FitStat.Mobile 
{
    public partial class RegistryPage : ContentPage
    {
       
        public RegistryPage()
        {
            InitializeComponent();
            BindingContext = new RegistryPageViewModel();


            
            //UserDto registerUserDto = new UserDto();
            //registerUserDto.UserName = "example";



            ((RegistryPageViewModel)BindingContext).FirstName = "examle";


        }

    }

}