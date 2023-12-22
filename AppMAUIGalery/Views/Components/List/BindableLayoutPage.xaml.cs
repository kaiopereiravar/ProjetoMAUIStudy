using AppMAUIGalery.Views.Components.List.Models;

namespace AppMAUIGalery.Views.Components.List;

public partial class BindableLayoutPage : ContentPage
{
	public BindableLayoutPage()
	{
		InitializeComponent();

		var layout = VerticalStackLayoutControll;
		var list = MovieList.GetList();

		BindableLayout.SetItemsSource(layout, list);
    }
}