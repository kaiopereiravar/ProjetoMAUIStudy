using AppMAUIGalery.Views.Components.List.Models;

namespace AppMAUIGalery.Views.Components.List;

public partial class PickerListPage : ContentPage
{
	public PickerListPage()
	{
		InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        MovieList.GetList();
        PickerControl.ItemsSource = MovieList.GetList();

        //((Movie)PickerControl.SelectedItem).Name - fazendo dessa forma eu consigo acessar qualquer item da classe atraves do picker
    }
}