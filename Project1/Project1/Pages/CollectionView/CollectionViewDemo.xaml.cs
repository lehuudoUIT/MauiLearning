using Project1.Models;

namespace Project1.Pages.CollectionView;

public partial class CollectionViewDemo : ContentPage
{
	public CollectionViewDemo()
	{
		InitializeComponent();
        collectionView.ItemsSource = GetCountries();
	}

	private List<Country> GetCountries()
	{
		return new List<Country>
		{
			new Country
			{
				CountryName = "Viet Nam",
				IsoCode = "704",
				FlagURL = "https://cdn.britannica.com/41/4041-004-D051B135/Flag-Vietnam.jpg"
            },
            new Country
            {
                CountryName = "America",
                IsoCode = "xxx",
                FlagURL = "https://cdn.britannica.com/33/4833-050-F6E415FE/Flag-United-States-of-America.jpg"
            },
             new Country
            {
                CountryName = "Viet Nam",
                IsoCode = "",
                FlagURL = ""
            },
            new Country
            {
                CountryName = "Viet Nam",
                IsoCode = "",
                FlagURL = ""
            },
            new Country
            {
                CountryName = "Viet Nam",
                IsoCode = "",
                FlagURL = ""
            },
            new Country
            {
                CountryName = "Viet Nam",
                IsoCode = "",
                FlagURL = ""
            },
            new Country
            {
                CountryName = "Viet Nam",
                IsoCode = "",
                FlagURL = ""
            },
            new Country
            {
                CountryName = "Viet Nam",
                IsoCode = "",
                FlagURL = ""
            },
            new Country
            {
                CountryName = "Viet Nam",
                IsoCode = "",
                FlagURL = ""
            },
            new Country
            {
                CountryName = "Viet Nam",
                IsoCode = "",
                FlagURL = ""
            }
        };
	}

}