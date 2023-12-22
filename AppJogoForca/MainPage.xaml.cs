using AppJogoForca.Libraries.Text;
using AppJogoForca.Models;
using AppJogoForca.Repositories;
//using HomeKit;

namespace AppJogoForca
{
    public partial class MainPage : ContentPage
    {
        private Word _word;
        private int _errors;

        public MainPage()
        {
            InitializeComponent();
            ResetScreen();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            button.IsEnabled = false;
            String letter = button.Text;// sender representa a tela, Button é o botão da tela, .text é o texto do botão

            var positions = _word.Text.GetPositions(letter);

            if (positions.Count == 0)
            {
                ErrorHandle(button);

                await IsGameOver();

                return;
            }

            ReplaceLetter(letter, positions);
            button.Style = App.Current.Resources.MergedDictionaries.ElementAt(1)["Success"] as Style;

            HasWinner();
        }

        

        private void ReplaceLetter(string letter, List<int> positions)
        {
            foreach (var position in positions)
            {
                LblText.Text = LblText.Text.Remove(position, 1).Insert(position, letter);
            }
        }

        private async Task HasWinner()
        {
            if (!LblText.Text.Contains("_"))
            {
                await DisplayAlert("Parabens!", "Você ganhou o jogo", "Novo jogo");
                ResetScreen();
            }
        }

        #region Verify if fail

        private void ErrorHandle(Button button)
        {
            _errors++;
            ImgMain.Source = ImageSource.FromFile($"forca{_errors + 1}.png");
            button.Style = App.Current.Resources.MergedDictionaries.ElementAt(1)["Fail"] as Style;//para ele pegar o estilo do botton
        }

        private async Task IsGameOver()
        {
            if (_errors == 6)
            {
                await DisplayAlert("Perdeu", "Você foi enforcado", "Novo jogo");
                ResetScreen();
            }
        }
        
        #endregion

        #region Reset Screen - Back Screen to Initial State 
        private void ResetScreen()
        {
            ResetVirtualKeyboard();
            ResetErros();
            RenerateNewWord();
        }

        private void RenerateNewWord()
        {
            var repository = new WordRepositories();
            _word = repository.GetRamdomWord();

            LblTips.Text = _word.Tips;
            LblText.Text = new string('_', _word.Text.Length);
        }

        private void ResetErros()
        {
            _errors = 0;
            ImgMain.Source = ImageSource.FromFile("forca1.png");
        } 

        private void ResetVirtualKeyboard()
        {
            ResetVirtualLines((HorizontalStackLayout)KeyboardContainer.Children[0]);
            ResetVirtualLines((HorizontalStackLayout)KeyboardContainer.Children[1]);
            ResetVirtualLines((HorizontalStackLayout)KeyboardContainer.Children[2]);
        }

        private void ResetVirtualLines(HorizontalStackLayout horizontal)
        {
            foreach(Button button in horizontal.Children)
            {
                button.IsEnabled = true;
                button.Style = null;//aqui ele só esta tirando o estilo colocado anteriormente
            }
        }
        #endregion

        private void OnButtonClickResetGame(object sender, EventArgs e)
        {
            ResetScreen();
        }
    }
}