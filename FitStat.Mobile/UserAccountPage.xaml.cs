namespace FitStat.Mobile;

public partial class UserAccountPage : ContentPage
{
    private UserAccountPage _userAccountPage;

    Label label;

    public UserAccountPage()
	{
		InitializeComponent();
		BindingContext = new UserAccountPageViewModel();
        //label = new Label { Text = "Выберите дату" };
        //DatePicker datePicker = new DatePicker
        //{
        //    Format = "d",
        //    MaximumDate = Convert.ToDateTime("01.01.2001"),
        //    MinimumDate = Convert.ToDateTime("31.12.2101")
        //};
        //datePicker.DateSelected += DateSelected;
        //StackLayout stack = new StackLayout { Children = { label, datePicker }, Padding = 20 };
        //Content = stack;

    }

    
}



