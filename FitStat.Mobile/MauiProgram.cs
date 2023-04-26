using Microsoft.Extensions.DependencyInjection;
using Services;
using Services.Abstractions;

namespace FitStat.Mobile
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });



             builder.Services.AddSingleton<IServiceManager, ServiceManager>();



            /*
              1)  подключить здесь внедрение зависиомстей из библиотеки Services (добавить классы)                      +
              1.1) В MainPageViewModel необходимо использовать IServiceManager и вызывать из него какой-то сервис 14.01.2023

              2)  сделать страничку входа -на ней должно быть поле для ввода логина и пароля                            +
              3)  проверить запуск приложения под мобильным устройством                                                 +    
              4)  привязать обработчик для реакции на нажатие нкопки -обящательно через binding(не через onclick)       +
              5)  разобраться - что такое в визуальном интерфейсе MAUI binding для событий                              +
            */
            return builder.Build();
        }
    }
}







