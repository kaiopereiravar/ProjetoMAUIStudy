using AppMAUIGalery.Views.Components.List.Models;

namespace AppMAUIGalery.Views.Components.List;

public partial class CarrouselViewPage : ContentPage
{
	public CarrouselViewPage()
	{
		InitializeComponent();
		CarouselViewControl.ItemsSource = MovieList.GetList();

    }
}