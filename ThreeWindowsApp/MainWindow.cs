using System;
using System.Windows.Forms;

namespace ThreeWindowsApp
{
    public class MainWindow : Form
    {
        private Button infoButton;
        private Button calculatorButton;

        public MainWindow()
        {
            Text = "Główne Okno";

            infoButton = new Button();
            infoButton.Text = "Otwórz Informacje";
            infoButton.Location = new System.Drawing.Point(30, 30);
            infoButton.Click += (sender, e) => OpenInfoWindow();

            calculatorButton = new Button();
            calculatorButton.Text = "Otwórz Kalkulator";
            calculatorButton.Location = new System.Drawing.Point(30, 70);
            calculatorButton.Click += (sender, e) => OpenCalculatorWindow();

            Controls.Add(infoButton);
            Controls.Add(calculatorButton);
        }

        private void OpenInfoWindow()
        {
            InfoWindow infoWindow = new InfoWindow();
            infoWindow.Show();
        }

        private void OpenCalculatorWindow()
        {
            CalculatorWindow calculatorWindow = new CalculatorWindow();
            calculatorWindow.Show();
        }
    }
}
