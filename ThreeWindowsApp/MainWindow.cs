using System;
using System.Windows.Forms;

namespace ThreeWindowsApp
{
    public class MainWindow : Form
    {
        private Button infoButton;
        private Button calculatorButton;

        private Button movieButton;

        public MainWindow()
        {
            Text = "Main window";

            infoButton = new Button();
            infoButton.Text = "Otwórz Informacje";
            infoButton.Location = new System.Drawing.Point(30, 30);
            infoButton.Click += (sender, e) => OpenInfoWindow();

            calculatorButton = new Button();
            calculatorButton.Text = "Otwórz Kalkulator";
            calculatorButton.Location = new System.Drawing.Point(30, 70);
            calculatorButton.Click += (sender, e) => OpenCalculatorWindow();

            movieButton = new Button();
            movieButton.Text = "Open movie";
            movieButton.Location = new System.Drawing.Point(30, 110);
            movieButton.Click += (sender, e) => OpenMovieWindow();

            Controls.Add(infoButton);
            Controls.Add(calculatorButton);
            Controls.Add(movieButton);
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

          private void OpenMovieWindow()
        {
            MovieWindow OpenMovieWindow = new MovieWindow();
            OpenMovieWindow.Show();
        }
    }
}

