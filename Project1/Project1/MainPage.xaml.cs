using Project1.Pages.CarouselView;
using Project1.Pages.CollectionView;
using Project1.Pages.ListView;

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

        private async void ListViewBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ListViewDemo());
        }

        private async void CollectionViewBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CollectionViewDemo());
        }
    }

}
