namespace Project1.Pages.NavPages;

public partial class NavPage2 : ContentPage
{
	public NavPage2()
	{
		InitializeComponent();
	}

    private async void Btn1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavPage3());
    }

    private async void Btn2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}