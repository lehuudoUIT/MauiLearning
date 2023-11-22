using Project1.Pages.CarouselView;

namespace Project1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void CarouselBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CarouselIndicatorDemo());
        }
    }

}
