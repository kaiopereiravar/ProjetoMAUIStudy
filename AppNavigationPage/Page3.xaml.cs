namespace AppNavigationPage;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}
	public void ButtonVoltar(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
}