namespace FitStat.Mobile;

public partial class DateAndBranchPage : ContentPage
{
    //public ICommand PostCommand { get; set; }
    private DateAndBranchPageViewModel _dateAndBranchPageViewModel;
    public DateAndBranchPage()
	{
		InitializeComponent();
        BindingContext = new DateAndBranchPageViewModel();
        //PostCommand = new Command(async () => await Post());
        //_dateAndBranchPageViewModel = new DateAndBranchPageViewModel();
        ////Application.Current.MainPage.DisplayAlert("", Code, UserDate, "OK");
    }
    //public async Task Post() {
    //    DateTime.TryParse(Date.Text, out DateTime dateTime);
    //    Guid.TryParse(BranchCode.Text, out Guid branchCode);
    //    _dateAndBranchPageViewModel.Post(dateTime, branchCode);
    //}

}