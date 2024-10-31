using System;
using System.Windows.Forms;

namespace ThreeWindowsApp
{
    public class MovieWindow : Form {

         public MovieWindow()
        {
            Text = "Movie Window";
            Label MovieLabel = new Label();
            MovieLabel.Text = "Favorite Movie:\nHarry Potter\nBreaking Bad\nDexter ";
            MovieLabel.AutoSize = true;
            MovieLabel.Location = new System.Drawing.Point(50, 50);

            Controls.Add(MovieLabel);
        }
    }
}
