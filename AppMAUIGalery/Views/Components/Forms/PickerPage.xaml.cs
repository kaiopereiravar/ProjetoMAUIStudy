namespace AppMAUIGalery.Views.Components.Forms;

public partial class PickerPage : ContentPage
{
	public PickerPage()
	{
		InitializeComponent();
	}

    private void picker_SelectedIndexChanged(object sender, EventArgs e)
    {
		var component = ((Picker)sender);
		String BrandName = (String)component.SelectedItem;

		/*component.SelectedItem = 4;
		component.SelectedItem = component.ItemsSource[0];*/

        LblName.Text = BrandName;

    }
}