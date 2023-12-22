namespace AppFlyoutPage;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private void OnButtonClickedPage1(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Page1());
        //ele vai ate a pagina atual, faz a conversão para o tipo de pagina flyout, pega o detail(que esta contido la na minha pagina) e busca a Page1()
        //basicamente, ele vai de local a local para achar a FloyoutPage, depois vai ate o detail dela, e pega uma pagina criada por mim
    }

    private void OnButtonClickedPage2(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Page2());
    }

    private void OnButtonClickedPage3(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Page3());
    }
}