namespace FitStat.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Routing.RegisterRoute("SignInPage", typeof(SignInPage)); 

            Routing.RegisterRoute("RegistryPage", typeof(RegistryPage));

            Routing.RegisterRoute("DateAndBranchPage", typeof(DateAndBranchPage));

            Routing.RegisterRoute("UserAccountPage", typeof(UserAccountPage));


            //var builder = builder.bild

            MainPage = new AppShell();
        }
    }
}