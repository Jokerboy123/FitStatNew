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

    private void Button_Clicked(object sender, EventArgs e)
    {
       //DisplayAlert("Информация о посещении:", "Последняя посещенная группа: \"Aэробика\"\n" +
       //    "Дата и время посещения: \n11.03.2023\n13:00\nФИО Тренера" +
       //    ":\nЗалессный Игорь Владимирович", "", "Закрыть");

        DisplayAlert("Отметка о занятии:", "Группа: \"Aэробика\"\n" +
           "Дата посещения: \n10.03.2023\nВремя посещения: 13:00\nФИО Тренера" +
           ":\nЗалессный Игорь Владимирович", "", "Закрыть");
    }

    private void Button1_Clicked(object sender, EventArgs e)
    {
        //DisplayAlert("Информация о посещении:", "Последняя посещенная группа: \"Aэробика\"\n" +
        //    "Дата и время посещения: \n11.03.2023\n13:00\nФИО Тренера" +
        //    ":\nЗалессный Игорь Владимирович", "", "Закрыть");

        DisplayAlert("Отметка о занятии:", "Группа: \"Aэробика\"\n" +
           "Дата посещения: \n10.03.2023\nВремя посещения: 13:00\nФИО Тренера" +
           ":\nЗалессный Игорь Владимирович", "", "Закрыть");
    }

    //public async Task Post() {
    //    DateTime.TryParse(Date.Text, out DateTime dateTime);
    //    Guid.TryParse(BranchCode.Text, out Guid branchCode);
    //    _dateAndBranchPageViewModel.Post(dateTime, branchCode);
    //}

}