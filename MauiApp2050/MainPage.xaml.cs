using System;
using Microsoft.Maui.Controls;

namespace MauiApp2050
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRollDiceClicked(object sender, EventArgs e)
        {
            int result = RollDice();
            ResultLabel.Text = $"You rolled a {result}";
        }

        private int RollDice()
        {
            Random random = new Random();
            int sides = GetNumberOfSides();
            return random.Next(1, sides + 1);
        }

        private int GetNumberOfSides()
        {
            if (RbK4.IsChecked) return 4;
            if (RbK6.IsChecked) return 6;
            if (RbK10.IsChecked) return 10;
            if (RbK12.IsChecked) return 12;
            return 6;
        }
    }
}
