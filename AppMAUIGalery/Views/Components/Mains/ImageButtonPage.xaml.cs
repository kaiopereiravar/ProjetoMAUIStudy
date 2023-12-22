namespace AppMAUIGalery.Views.Components.Mains;

public partial class ImageButtonPage : ContentPage
{
	bool btnState = false;
	public ImageButtonPage()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		btnState = !btnState;

		var powerOff = "poweroff.png";
		var powerOn = "poweron.png";

		var button = (ImageButton)sender; //ele esta pegando o botao que esta dentro da minha pagina(originalizada como sender)

		button.Source = (btnState == false) ? ImageSource.FromFile(powerOn) : ImageSource.FromFile(powerOff);
    }
}