namespace Project1.SomeBasicControl;

public partial class BasicControl : ContentPage
{
	public BasicControl()
	{
		InitializeComponent();
	}

    private void activityChangeBtn_Clicked(object sender, EventArgs e)
    {
		loading.IsRunning = !loading.IsRunning;
    }
}