namespace FitStat.Mobile;

public class UserAccountPageViewModel : ContentPage
{
	public UserAccountPageViewModel(SignInPageViewModel sipMV)

	{
        string name = sipMV.Login.ToString();
        BindingContext = name;


    }
}