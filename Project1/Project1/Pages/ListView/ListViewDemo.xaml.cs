using Project1.Pages.CarouselView.Models;
namespace Project1.Pages.ListView;

public partial class ListViewDemo : ContentPage
{
	public ListViewDemo()
	{
		InitializeComponent();

		var items = new List<CollectionItem>
		{
			new CollectionItem
			{
				Title = "Item 1",
				Description = "This is item 1"
			},
            new CollectionItem
            {
                Title = "Item 2",
                Description = "This is item 2"
            },
            new CollectionItem
            {
                Title = "Item 3",
                Description = "This is item 3"
            },
            new CollectionItem
            {
                Title = "Item 4",
                Description = "This is item 4"
            },
            new CollectionItem
            {
                Title = "Item 5",
                Description = "This is item 5"
            }
        };

        listView.ItemsSource = items;

	}
}