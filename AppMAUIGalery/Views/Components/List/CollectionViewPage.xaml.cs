using AppMAUIGalery.Views.Components.List.Models;
using System.Collections.ObjectModel;
using System.Text;

namespace AppMAUIGalery.Views.Components.List;

public partial class CollectionViewPage : ContentPage
{
    ObservableCollection<Movie> movies = new ObservableCollection<Movie>();
    int countMovies = 0;
	public CollectionViewPage()
	{
		InitializeComponent();

        AddTenMovies();
        //CollectionViewControll.ItemsSource = movies;

        //CollectionViewControll.ItemsSource = MovieList.GetList(); 

        CollectionViewControll.ItemsSource = MovieList.GetGroupList();

    }

    private async void RefreshView_Refreshing(object sender, EventArgs e)
    {
        ((RefreshView)sender).IsRefreshing = true;

        await Task.Delay(3000);
        CollectionViewControll.ItemsSource = MovieList.GetList();

        ((RefreshView)sender).IsRefreshing = false;
    }

    private void CollectionViewControll_RemainingItemsThresholdReached(object sender, EventArgs e)
    {
        AddTenMovies();
    }

    private void AddTenMovies()
    {
        for(int i = 0; i < 20; i++)
        {
            Movie movie = new Movie()
            {
                Id = countMovies++,
                Name = $"Movie {countMovies}",
                Description = $"Description {countMovies}",
                LaunchYear = 2022,
                Duration = new TimeSpan(2, 0, 0),
            };

           movies.Add(movie);
        }
    }

    private void CollectionViewControll_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

        StringBuilder sb = new StringBuilder();
        foreach(Movie movie in e.CurrentSelection)
        {
            sb.Append(movie.Name + " - ");
        }

        LblSelectedMovies.Text = sb.ToString();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var group = (List<GroupMovie>)CollectionViewControll.ItemsSource;
        var item = group[2][0];

        CollectionViewControll.ScrollTo(7, position: ScrollToPosition.Start);
        //CollectionViewControll.ScrollTo(7, position: ScrollToPosition.Start);
    }

    private void CollectionViewControll_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {
        LblScrollStatus.Text = $"Posicionamento: {e.VerticalOffset} - Espaçamento: {e.VerticalDelta}";
    }
}