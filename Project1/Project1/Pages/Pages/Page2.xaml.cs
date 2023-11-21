namespace Project1.Pages;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private async void Btn2_Clicked(object sender, EventArgs e)
    {
		//await Navigation.PushModalAsync(new Page1());
		await Navigation.PopModalAsync();
    }
}