using AppMAUIGalery.Views.Components.List.Models;

namespace AppMAUIGalery.Views.Components.List;

public partial class DataTemplateSelectorPage : ContentPage
{
	public DataTemplateSelectorPage()
	{
		InitializeComponent();

		CollectionViewControll.ItemsSource = MovieList.GetList();

    }
}