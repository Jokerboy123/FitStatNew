using System.Threading;
using static System.Net.Mime.MediaTypeNames;
using System.Net;
using System.Windows.Input;
using Contracts.Models.Entities;
    // Рабочий проект
namespace FitStat.Mobile
{
    public partial class MainPage : ContentPage
    {
        // Задание 7.02.2023
        /*********************/
        // сделать еще один сервис по аналогии с UserService, назвать его WebSiteApiConsumeService 
        // взять у Гены код, который выполняет запросы к сайту по HTTP
        // встроить этот код в WebSiteApiConsumeService
        //в мобильном приложении сделать страницу, при заходе на которую будет два текстовых поля - дата и branchcode, кнопка для отправки запроса
        //по нажатию на кнопку - отправляем запрос к веб-методу сервиса сайта - как в примере в постмане, передаем туда дату и branchcode
        // веб апи (web api) в asp core, http client .net core (metanit , документация microsoft)
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
      
    }
}
