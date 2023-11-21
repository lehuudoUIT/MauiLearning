namespace Project1.Pages;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}
    private async void Btn1_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new Page2());
    }
}