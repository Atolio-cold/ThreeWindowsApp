using System;
using System.Windows.Forms;

namespace ThreeWindowsApp
{
    public class CalculatorWindow : Form
    {
        private TextBox input1;
        private TextBox input2;
        private TextBox input3;
        private Button calculateButton;
        private Label resultLabel;

        public CalculatorWindow()
        {
            Text = "Okno Kalkulatora";

            Label label1 = new Label() { Text = "Pierwsza liczba:", Location = new System.Drawing.Point(30, 30) };
            input1 = new TextBox() { Location = new System.Drawing.Point(150, 30) };

            Label label2 = new Label() { Text = "Druga liczba:", Location = new System.Drawing.Point(30, 70) };
            input2 = new TextBox() { Location = new System.Drawing.Point(150, 70) };

            Label label3 = new Label() { Text = "Trzecia liczba:", Location = new System.Drawing.Point(30, 120) };
            input3 = new TextBox() { Location = new System.Drawing.Point(150, 110) };

            calculateButton = new Button() { Text = "Oblicz sumę", Location = new System.Drawing.Point(30, 180) };
            calculateButton.Click += CalculateSum;

            resultLabel = new Label() { Location = new System.Drawing.Point(30, 150), AutoSize = true };

            Controls.Add(label1);
            Controls.Add(input1);
            Controls.Add(label2);
            Controls.Add(input2);
            Controls.Add(label3);
            Controls.Add(input3);
            Controls.Add(calculateButton);
            Controls.Add(resultLabel);
        }

       private void CalculateSum(object sender, EventArgs e)
{
    if (int.TryParse(input1.Text, out int liczba1) && int.TryParse(input2.Text, out int liczba2))
    {
        int suma = liczba1 + liczba2;
        resultLabel.Text = "Suma liczb to: " + suma;
    
        MessageBox.Show("Obliczenia zakończone. Okno zostanie zamknięte.", "Kalkulator");

        this.Close();
    }
    else
    {
        resultLabel.Text = "Błędne dane wejściowe.";
    }
}

        }
    }

