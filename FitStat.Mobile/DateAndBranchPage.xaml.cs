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
       //DisplayAlert("���������� � ���������:", "��������� ���������� ������: \"A�������\"\n" +
       //    "���� � ����� ���������: \n11.03.2023\n13:00\n��� �������" +
       //    ":\n��������� ����� ������������", "", "�������");

        DisplayAlert("������� � �������:", "������: \"A�������\"\n" +
           "���� ���������: \n10.03.2023\n����� ���������: 13:00\n��� �������" +
           ":\n��������� ����� ������������", "", "�������");
    }

    private void Button1_Clicked(object sender, EventArgs e)
    {
        //DisplayAlert("���������� � ���������:", "��������� ���������� ������: \"A�������\"\n" +
        //    "���� � ����� ���������: \n11.03.2023\n13:00\n��� �������" +
        //    ":\n��������� ����� ������������", "", "�������");

        DisplayAlert("������� � �������:", "������: \"A�������\"\n" +
           "���� ���������: \n10.03.2023\n����� ���������: 13:00\n��� �������" +
           ":\n��������� ����� ������������", "", "�������");
    }

    //public async Task Post() {
    //    DateTime.TryParse(Date.Text, out DateTime dateTime);
    //    Guid.TryParse(BranchCode.Text, out Guid branchCode);
    //    _dateAndBranchPageViewModel.Post(dateTime, branchCode);
    //}

}