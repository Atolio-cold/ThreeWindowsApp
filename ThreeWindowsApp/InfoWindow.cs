using System;
using System.Windows.Forms;

namespace ThreeWindowsApp
{
    public class InfoWindow : Form
    {
        public InfoWindow()
        {
            Text = "Okno Informacji";
            Label infoLabel = new Label();
            infoLabel.Text = "Imię: Jan\nWiek: 30\nMiasto: Warszawa\nHobby: Siatkówka\nUlubiony kolor: Zielony";
            infoLabel.AutoSize = true;
            infoLabel.Location = new System.Drawing.Point(50, 50);

            Controls.Add(infoLabel);
        }
    }
}
