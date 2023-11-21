namespace Project1.Pages.NavPages;

public partial class NavPage3 : ContentPage
{
	public NavPage3()
	{
		InitializeComponent();
	}

    private async void Btn1_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}