namespace AppNavigationPage;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

    private void ButtonProsseguir(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Page2());
    }
    private void ButtonVoltar(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}

//Navigation.PopAsync() = Para voltar para a tela anterior
//Navigation.NavigationStack[3] = Eu posso selecionar para qual pagina eu quero que ele v� desde que essa pagina seja existente
//Navigation.PopToRootAsync() = Volta para a tela inicial