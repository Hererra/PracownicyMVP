
using System;

namespace WinFormsApp1.View
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListaPracownikowListBox = new System.Windows.Forms.ListBox();
            this.DanePracownikaGroupBox = new System.Windows.Forms.GroupBox();
            this.DodajButton = new System.Windows.Forms.Button();
            this.UmowaZleceniaRadioButton = new System.Windows.Forms.RadioButton();
            this.UmowaNaCzasOkreslonyRadioButton = new System.Windows.Forms.RadioButton();
            this.UmowaNaCzasNieokreslonyRadioButton = new System.Windows.Forms.RadioButton();
            this.RodzajUmowyLabel = new System.Windows.Forms.Label();
            this.StanowiskoComboBox = new System.Windows.Forms.ComboBox();
            this.StanowiskoLabel = new System.Windows.Forms.Label();
            this.PensjaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DataUrodzeniaDataTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.ImieTextBox = new System.Windows.Forms.TextBox();
            this.PensjaLabel = new System.Windows.Forms.Label();
            this.DataUrodzeniaLabel = new System.Windows.Forms.Label();
            this.NazwiskoLabel = new System.Windows.Forms.Label();
            this.ImieLabel = new System.Windows.Forms.Label();
            this.ZapiszButton = new System.Windows.Forms.Button();
            this.WczytajButton = new System.Windows.Forms.Button();
            this.DanePracownikaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PensjaNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaPracownikowListBox
            // 
            this.ListaPracownikowListBox.FormattingEnabled = true;
            this.ListaPracownikowListBox.HorizontalScrollbar = true;
            this.ListaPracownikowListBox.ItemHeight = 20;
            this.ListaPracownikowListBox.Location = new System.Drawing.Point(434, 13);
            this.ListaPracownikowListBox.Name = "ListaPracownikowListBox";
            this.ListaPracownikowListBox.ScrollAlwaysVisible = true;
            this.ListaPracownikowListBox.Size = new System.Drawing.Size(700, 524);
            this.ListaPracownikowListBox.TabIndex = 0;
            this.ListaPracownikowListBox.SelectedIndexChanged += new System.EventHandler(this.ListaPracownikowListBox_SelectedIndexChanged);
            // 
            // DanePracownikaGroupBox
            // 
            this.DanePracownikaGroupBox.Controls.Add(this.DodajButton);
            this.DanePracownikaGroupBox.Controls.Add(this.UmowaZleceniaRadioButton);
            this.DanePracownikaGroupBox.Controls.Add(this.UmowaNaCzasOkreslonyRadioButton);
            this.DanePracownikaGroupBox.Controls.Add(this.UmowaNaCzasNieokreslonyRadioButton);
            this.DanePracownikaGroupBox.Controls.Add(this.RodzajUmowyLabel);
            this.DanePracownikaGroupBox.Controls.Add(this.StanowiskoComboBox);
            this.DanePracownikaGroupBox.Controls.Add(this.StanowiskoLabel);
            this.DanePracownikaGroupBox.Controls.Add(this.PensjaNumericUpDown);
            this.DanePracownikaGroupBox.Controls.Add(this.DataUrodzeniaDataTimePicker);
            this.DanePracownikaGroupBox.Controls.Add(this.NazwiskoTextBox);
            this.DanePracownikaGroupBox.Controls.Add(this.ImieTextBox);
            this.DanePracownikaGroupBox.Controls.Add(this.PensjaLabel);
            this.DanePracownikaGroupBox.Controls.Add(this.DataUrodzeniaLabel);
            this.DanePracownikaGroupBox.Controls.Add(this.NazwiskoLabel);
            this.DanePracownikaGroupBox.Controls.Add(this.ImieLabel);
            this.DanePracownikaGroupBox.Location = new System.Drawing.Point(14, 13);
            this.DanePracownikaGroupBox.Name = "DanePracownikaGroupBox";
            this.DanePracownikaGroupBox.Size = new System.Drawing.Size(409, 482);
            this.DanePracownikaGroupBox.TabIndex = 1;
            this.DanePracownikaGroupBox.TabStop = false;
            this.DanePracownikaGroupBox.Text = "Dane Pracownika";
            // 
            // DodajButton
            // 
            this.DodajButton.Location = new System.Drawing.Point(6, 433);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(397, 29);
            this.DodajButton.TabIndex = 2;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // UmowaZleceniaRadioButton
            // 
            this.UmowaZleceniaRadioButton.AutoSize = true;
            this.UmowaZleceniaRadioButton.Location = new System.Drawing.Point(140, 391);
            this.UmowaZleceniaRadioButton.Name = "UmowaZleceniaRadioButton";
            this.UmowaZleceniaRadioButton.Size = new System.Drawing.Size(137, 24);
            this.UmowaZleceniaRadioButton.TabIndex = 13;
            this.UmowaZleceniaRadioButton.TabStop = true;
            this.UmowaZleceniaRadioButton.Text = "umowa zlecenia";
            this.UmowaZleceniaRadioButton.UseVisualStyleBackColor = true;
            // 
            // UmowaNaCzasOkreslonyRadioButton
            // 
            this.UmowaNaCzasOkreslonyRadioButton.AutoSize = true;
            this.UmowaNaCzasOkreslonyRadioButton.Location = new System.Drawing.Point(140, 346);
            this.UmowaNaCzasOkreslonyRadioButton.Name = "UmowaNaCzasOkreslonyRadioButton";
            this.UmowaNaCzasOkreslonyRadioButton.Size = new System.Drawing.Size(198, 24);
            this.UmowaNaCzasOkreslonyRadioButton.TabIndex = 12;
            this.UmowaNaCzasOkreslonyRadioButton.TabStop = true;
            this.UmowaNaCzasOkreslonyRadioButton.Text = "umowa na czas określony";
            this.UmowaNaCzasOkreslonyRadioButton.UseVisualStyleBackColor = true;
            // 
            // UmowaNaCzasNieokreslonyRadioButton
            // 
            this.UmowaNaCzasNieokreslonyRadioButton.AutoSize = true;
            this.UmowaNaCzasNieokreslonyRadioButton.Location = new System.Drawing.Point(140, 299);
            this.UmowaNaCzasNieokreslonyRadioButton.Name = "UmowaNaCzasNieokreslonyRadioButton";
            this.UmowaNaCzasNieokreslonyRadioButton.Size = new System.Drawing.Size(218, 24);
            this.UmowaNaCzasNieokreslonyRadioButton.TabIndex = 11;
            this.UmowaNaCzasNieokreslonyRadioButton.TabStop = true;
            this.UmowaNaCzasNieokreslonyRadioButton.Text = "umowa na czas nieokreślony";
            this.UmowaNaCzasNieokreslonyRadioButton.UseVisualStyleBackColor = true;
            // 
            // RodzajUmowyLabel
            // 
            this.RodzajUmowyLabel.AutoSize = true;
            this.RodzajUmowyLabel.Location = new System.Drawing.Point(6, 299);
            this.RodzajUmowyLabel.Name = "RodzajUmowyLabel";
            this.RodzajUmowyLabel.Size = new System.Drawing.Size(110, 20);
            this.RodzajUmowyLabel.TabIndex = 10;
            this.RodzajUmowyLabel.Text = "Rodzaj umowy:";
            // 
            // StanowiskoComboBox
            // 
            this.StanowiskoComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Tester",
            "Projektant",
            "Inżynier",
            "Młodszy Programista",
            "Starszy Programista"});
            this.StanowiskoComboBox.FormattingEnabled = true;
            this.StanowiskoComboBox.Items.AddRange(new object[] {
            "Tester",
            "Projektant",
            "Inżynier",
            "Młodszy Programista",
            "Starszy Programista"});
            this.StanowiskoComboBox.Location = new System.Drawing.Point(140, 240);
            this.StanowiskoComboBox.Name = "StanowiskoComboBox";
            this.StanowiskoComboBox.Size = new System.Drawing.Size(263, 28);
            this.StanowiskoComboBox.TabIndex = 9;
            // 
            // StanowiskoLabel
            // 
            this.StanowiskoLabel.AutoSize = true;
            this.StanowiskoLabel.Location = new System.Drawing.Point(6, 240);
            this.StanowiskoLabel.Name = "StanowiskoLabel";
            this.StanowiskoLabel.Size = new System.Drawing.Size(87, 20);
            this.StanowiskoLabel.TabIndex = 8;
            this.StanowiskoLabel.Text = "Stanowisko:";
            // 
            // PensjaNumericUpDown
            // 
            this.PensjaNumericUpDown.Location = new System.Drawing.Point(140, 191);
            this.PensjaNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PensjaNumericUpDown.Name = "PensjaNumericUpDown";
            this.PensjaNumericUpDown.Size = new System.Drawing.Size(263, 27);
            this.PensjaNumericUpDown.TabIndex = 7;
            // 
            // DataUrodzeniaDataTimePicker
            // 
            this.DataUrodzeniaDataTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataUrodzeniaDataTimePicker.Location = new System.Drawing.Point(140, 146);
            this.DataUrodzeniaDataTimePicker.Name = "DataUrodzeniaDataTimePicker";
            this.DataUrodzeniaDataTimePicker.Size = new System.Drawing.Size(263, 27);
            this.DataUrodzeniaDataTimePicker.TabIndex = 6;
            // 
            // NazwiskoTextBox
            // 
            this.NazwiskoTextBox.Location = new System.Drawing.Point(140, 95);
            this.NazwiskoTextBox.Name = "NazwiskoTextBox";
            this.NazwiskoTextBox.Size = new System.Drawing.Size(263, 27);
            this.NazwiskoTextBox.TabIndex = 5;
            // 
            // ImieTextBox
            // 
            this.ImieTextBox.Location = new System.Drawing.Point(140, 43);
            this.ImieTextBox.Name = "ImieTextBox";
            this.ImieTextBox.Size = new System.Drawing.Size(263, 27);
            this.ImieTextBox.TabIndex = 4;
            // 
            // PensjaLabel
            // 
            this.PensjaLabel.AutoSize = true;
            this.PensjaLabel.Location = new System.Drawing.Point(6, 191);
            this.PensjaLabel.Name = "PensjaLabel";
            this.PensjaLabel.Size = new System.Drawing.Size(53, 20);
            this.PensjaLabel.TabIndex = 3;
            this.PensjaLabel.Text = "Pensja:";
            // 
            // DataUrodzeniaLabel
            // 
            this.DataUrodzeniaLabel.AutoSize = true;
            this.DataUrodzeniaLabel.Location = new System.Drawing.Point(6, 146);
            this.DataUrodzeniaLabel.Name = "DataUrodzeniaLabel";
            this.DataUrodzeniaLabel.Size = new System.Drawing.Size(116, 20);
            this.DataUrodzeniaLabel.TabIndex = 2;
            this.DataUrodzeniaLabel.Text = "Data Urodzenia:";
            // 
            // NazwiskoLabel
            // 
            this.NazwiskoLabel.AutoSize = true;
            this.NazwiskoLabel.Location = new System.Drawing.Point(6, 98);
            this.NazwiskoLabel.Name = "NazwiskoLabel";
            this.NazwiskoLabel.Size = new System.Drawing.Size(75, 20);
            this.NazwiskoLabel.TabIndex = 1;
            this.NazwiskoLabel.Text = "Nazwisko:";
            // 
            // ImieLabel
            // 
            this.ImieLabel.AutoSize = true;
            this.ImieLabel.Location = new System.Drawing.Point(6, 46);
            this.ImieLabel.Name = "ImieLabel";
            this.ImieLabel.Size = new System.Drawing.Size(41, 20);
            this.ImieLabel.TabIndex = 0;
            this.ImieLabel.Text = "Imię:";
            // 
            // ZapiszButton
            // 
            this.ZapiszButton.Location = new System.Drawing.Point(20, 508);
            this.ZapiszButton.Name = "ZapiszButton";
            this.ZapiszButton.Size = new System.Drawing.Size(191, 29);
            this.ZapiszButton.TabIndex = 2;
            this.ZapiszButton.Text = "Zapisz";
            this.ZapiszButton.UseVisualStyleBackColor = true;
            this.ZapiszButton.Click += new System.EventHandler(this.ZapiszButton_Click);
            // 
            // WczytajButton
            // 
            this.WczytajButton.Location = new System.Drawing.Point(228, 508);
            this.WczytajButton.Name = "WczytajButton";
            this.WczytajButton.Size = new System.Drawing.Size(189, 29);
            this.WczytajButton.TabIndex = 3;
            this.WczytajButton.Text = "Wczytaj";
            this.WczytajButton.UseVisualStyleBackColor = true;
            this.WczytajButton.Click += new System.EventHandler(this.WczytajButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 568);
            this.Controls.Add(this.WczytajButton);
            this.Controls.Add(this.ZapiszButton);
            this.Controls.Add(this.DanePracownikaGroupBox);
            this.Controls.Add(this.ListaPracownikowListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DanePracownikaGroupBox.ResumeLayout(false);
            this.DanePracownikaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PensjaNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListaPracownikowListBox;
        private System.Windows.Forms.GroupBox DanePracownikaGroupBox;
        private System.Windows.Forms.DateTimePicker DataUrodzeniaDataTimePicker;
        private System.Windows.Forms.TextBox NazwiskoTextBox;
        private System.Windows.Forms.TextBox ImieTextBox;
        private System.Windows.Forms.Label PensjaLabel;
        private System.Windows.Forms.Label DataUrodzeniaLabel;
        private System.Windows.Forms.Label NazwiskoLabel;
        private System.Windows.Forms.Label ImieLabel;
        private System.Windows.Forms.ComboBox StanowiskoComboBox;
        private System.Windows.Forms.Label StanowiskoLabel;
        private System.Windows.Forms.NumericUpDown PensjaNumericUpDown;
        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.RadioButton UmowaZleceniaRadioButton;
        private System.Windows.Forms.RadioButton UmowaNaCzasOkreslonyRadioButton;
        private System.Windows.Forms.RadioButton UmowaNaCzasNieokreslonyRadioButton;
        private System.Windows.Forms.Label RodzajUmowyLabel;
        private System.Windows.Forms.Button ZapiszButton;
        private System.Windows.Forms.Button WczytajButton;
  

    }
}

