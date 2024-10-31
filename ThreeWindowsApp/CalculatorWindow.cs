using System;
using System.Windows.Forms;

public partial class CalculatorWindow : Form
{
    public CalculatorWindow()
    {
        InitializeComponent();
        InitializeComboBox(); 
    }

    private void InitializeComboBox()
    {
      
        operationComboBox.Items.Add("Dodawanie");
        operationComboBox.Items.Add("Odejmowanie");
        operationComboBox.Items.Add("Mnożenie");
        operationComboBox.Items.Add("Dzielenie");
        operationComboBox.SelectedIndex = 0; 
    }

    private async void Calculate(object sender, EventArgs e)
    {
        
        if (int.TryParse(input1.Text, out int liczba1) && int.TryParse(input2.Text, out int liczba2))
        {
            int wynik = 0;
            string operacja = operationComboBox.SelectedItem.ToString();

            switch (operacja)
            {
                case "Dodawanie":
                    wynik = liczba1 + liczba2;
                    break;
                case "Odejmowanie":
                    wynik = liczba1 - liczba2;
                    break;
                case "Mnożenie":
                    wynik = liczba1 * liczba2;
                    break;
                case "Dzielenie":
                    if (liczba2 != 0)
                    {
                        wynik = liczba1 / liczba2;
                    }
                    else
                    {
                        MessageBox.Show("Nie można dzielić przez zero!", "Błąd");
                        return; 
                    }
                    break;
                default:
                    MessageBox.Show("Wybierz poprawną operację!", "Błąd");
                    return; 
            }

        
            resultLabel.Text = "Wynik: " + wynik;

        
            MessageBox.Show("Obliczenia zakończone. Okno zostanie zamknięte za 5 sekund.", "Kalkulator");

            

           
            this.Close();
        }
        else
        {
            resultLabel.Text = "Błędne dane wejściowe.";
        }
    }
}

    
