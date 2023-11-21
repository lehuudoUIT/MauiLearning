
using Project1.Layouts;
using AbsoluteLayout = Project1.Layouts.AbsoluteLayout;

namespace Project1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //var navigationPage = new NavigationPage(new NavPage1());

            //styling for navigation page

            //navigationPage.BarBackgroundColor = Colors.Red;
            //navigationPage.BarTextColor = Colors.Black;


            //MainPage = navigationPage;

            //Flyout nav

            MainPage = new AbsoluteLayout();
        }
    }
}
