namespace AppMAUIGalery.Views.Components.Mains;

public partial class ButtonPage : ContentPage
{
	public ButtonPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        LblLog.Text += $"\n Clicado: {DateTime.Now}";
    }

    private void Button_Pressed(object sender, EventArgs e)
    {
        LblLog.Text += $"\n Pressionado: {DateTime.Now}";
    }

    private void Button_Released(object sender, EventArgs e)
    {
        LblLog.Text += $"\n Liberado: {DateTime.Now} \n";
    }
}