
partial class CalculatorWindow
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox input1;
    private System.Windows.Forms.TextBox input2;
    private System.Windows.Forms.ComboBox operationComboBox;
    private System.Windows.Forms.Button calculateButton;
    private System.Windows.Forms.Label resultLabel;

    private void InitializeComponent()
    {
        this.input1 = new System.Windows.Forms.TextBox();
        this.input2 = new System.Windows.Forms.TextBox();
        this.operationComboBox = new System.Windows.Forms.ComboBox();
        this.calculateButton = new System.Windows.Forms.Button();
        this.resultLabel = new System.Windows.Forms.Label();

        // (Inicjalizowanie kontrolki input1)
        this.input1.Location = new System.Drawing.Point(12, 12);
        this.input1.Name = "input1";
        this.input1.Size = new System.Drawing.Size(100, 20);
        
        // (Inicjalizowanie kontrolki input2)
        this.input2.Location = new System.Drawing.Point(12, 38);
        this.input2.Name = "input2";
        this.input2.Size = new System.Drawing.Size(100, 20);
        
        // (Inicjalizowanie kontrolki operationComboBox)
        this.operationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.operationComboBox.Location = new System.Drawing.Point(12, 64);
        this.operationComboBox.Name = "operationComboBox";
        this.operationComboBox.Size = new System.Drawing.Size(121, 21);
        
        // (Inicjalizowanie kontrolki calculateButton)
        this.calculateButton.Location = new System.Drawing.Point(12, 91);
        this.calculateButton.Name = "calculateButton";
        this.calculateButton.Size = new System.Drawing.Size(75, 23);
        this.calculateButton.Text = "Oblicz";
        this.calculateButton.Click += new System.EventHandler(this.Calculate);

        // (Inicjalizowanie kontrolki resultLabel)
        this.resultLabel.Location = new System.Drawing.Point(12, 117);
        this.resultLabel.Name = "resultLabel";
        this.resultLabel.Size = new System.Drawing.Size(200, 23);

        // (Dodawanie kontrolki do formularza)
        this.Controls.Add(this.input1);
        this.Controls.Add(this.input2);
        this.Controls.Add(this.operationComboBox);
        this.Controls.Add(this.calculateButton);
        this.Controls.Add(this.resultLabel);

        // (Inne ustawienia formularza)
        this.Text = "Kalkulator";
        this.ClientSize = new System.Drawing.Size(284, 161);
    }
}



