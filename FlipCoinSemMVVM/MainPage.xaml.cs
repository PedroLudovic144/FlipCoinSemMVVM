using System;
using Microsoft.Maui.Controls;

namespace FlipCoinSemMVVM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnFlipCoinClicked(object sender, EventArgs e)
        {
            if (PickerChoice.SelectedIndex == -1)
            {
                DisplayAlert("Erro", "Por favor, selecione Cara ou Coroa", "OK");
                return;
            }

            string userChoice = PickerChoice.SelectedItem.ToString();
            string[] choices = { "Cara", "Coroa" };
            Random random = new Random();
            string coinFlipResult = choices[random.Next(choices.Length)];

            if (userChoice == coinFlipResult)
            {
                ResultLabel.Text = "Você acertou! Deu " + coinFlipResult;
            }
            else
            {
                ResultLabel.Text = "Você errou! Deu " + coinFlipResult;
            }

            // Definir a imagem correspondente
            if (coinFlipResult == "Cara")
            {
                ResultImage.Source = "cara.png";
            }
            else
            {
                ResultImage.Source = "coroa.png";
            }
            ResultImage.IsVisible = true;
        }
    }
}
