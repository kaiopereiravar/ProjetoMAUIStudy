using AppMAUIGalery.Repositories;

namespace AppMAUIGalery.Views;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();

		var categories = new CategoryRepository().GetCategories();// chamando essa classe dentro da CategoryRepository
        foreach (var category in categories)
		{

            var lblCategory = new Label();
            lblCategory.Text = category.Name;
			lblCategory.FontFamily = "OpenSansSemibold";//para atribuir a fonte no front
			lblCategory.Margin = new Thickness(0, 20, 0, 0);

            MenuContainer.Children.Add(lblCategory);

            foreach (var component in category.Components)
			{
				var tap = new TapGestureRecognizer(); //essa instancia aciona o movimento de tap(quando clicar) ou de qualquer outro gesto
				tap.CommandParameter = component.Page;// Representa que eu posso abrir uma pagina
				tap.Tapped += onTapComponent; //para quando eu clicar em algum elemento, ele acionar essa função

				var lblComponenteTitle = new Label();
				lblComponenteTitle.FontFamily = "OpenSansSemibold";
				lblComponenteTitle.Margin = new Thickness(20, 30, 0, 0); //para ser colocado margin e padding, precisamos instanciar essa classe
				lblComponenteTitle.Text = component.Title;
                lblComponenteTitle.GestureRecognizers.Add(tap);//adionando o movimento de tap nessa label

                var lblComponenteDescription = new Label();
				lblComponenteDescription.Text = component.Description;
                lblComponenteDescription.Margin = new Thickness(20, 10, 0, 0);
				lblComponenteDescription.GestureRecognizers.Add(tap);

                MenuContainer.Children.Add(lblComponenteTitle);
				MenuContainer.Children.Add(lblComponenteDescription);
            }
        }
    }

	private void onTapComponent(object sender, EventArgs e)
	{
		var label = (Label)sender; //sender representa o elemento que foi clicado
        var tap = (TapGestureRecognizer)label.GestureRecognizers[0];
		var page = (Type)tap.CommandParameter;

		((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage((Page)Activator.CreateInstance(page));//quando for clicado, alem de ir para a pagina, na NavigationPage irá aparecer o nome da pagina
		((FlyoutPage)App.Current.MainPage).IsPresented = false;// para ele esconder o menu
	}

    private void OnTapInicio(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new AppMAUIGalery.Views.MainPage());//quando for clicado, alem de ir para a pagina, na NavigationPage irá aparecer o nome da pagina
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;// para ele esconder o menu
    }
}

