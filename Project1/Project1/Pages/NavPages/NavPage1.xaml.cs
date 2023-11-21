namespace Project1.Pages.NavPages;

public partial class NavPage1 : ContentPage
{
	public NavPage1()
	{
		InitializeComponent();
	}

    private async void Btn1_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new NavPage2());
    }
}