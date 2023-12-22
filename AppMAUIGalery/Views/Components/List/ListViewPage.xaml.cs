using AppMAUIGalery.Views.Components.List.Models;

namespace AppMAUIGalery.Views.Components.List;

public partial class ListViewPage : ContentPage
{
	public ListViewPage()
	{
		InitializeComponent();

        ListViewControll.ItemsSource = MovieList.GetGroupList(); //busca a lista da classe e insere no listView
    }

    private void ListViewControll_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var movie = ((Movie)e.SelectedItem);

        App.Current.MainPage.DisplayAlert("O Filme selecionado!", $"O filme selecionado é: {movie.Name}", "OK");
    }

    private async void ListViewControll_Refreshing(object sender, EventArgs e)
    {
        ListViewControll.IsRefreshing = true;
        await Task.Delay(3000);
        ListViewControll.ItemsSource = MovieList.GetList();

        ListViewControll.IsRefreshing = false;
    }
}