namespace FitStat.Mobile;

public partial class SignInPage : ContentPage
{
	private SignInPageViewModel _signInPageViewModel;
	public SignInPage()
	{
		InitializeComponent();
		BindingContext = new SignInPageViewModel();
	}
}