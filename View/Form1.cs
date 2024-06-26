using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.View
{
    public partial class Form1 : Form, IView
    {
        //private Presenter.MainPresenter _presenter;

        public Form1()
        {
            InitializeComponent();
           
        }

        public event Action DodajPracownika;
        public event Action ZapiszPracownikow;
        public event Action WybierzPracownika;
        public event Action UsunPracownikow;
        public event Action WczytajPracownikow;
        public string Imie
        {
            get => ImieTextBox.Text;
            set => ImieTextBox.Text = value;
        }
        public string Nazwisko
        {
            get => NazwiskoTextBox.Text;
            set => NazwiskoTextBox.Text = value;
        }
        public string Data
        {
            get => DataUrodzeniaDataTimePicker.Text.ToString();
            set => DataUrodzeniaDataTimePicker.Text = value;
        }
        public string Pensja
        {
            get => PensjaNumericUpDown.Text.ToString();
            set => PensjaNumericUpDown.Text = value;
        }
        public string Stanowisko
        {
            get => StanowiskoComboBox.SelectedItem?.ToString();
            set => StanowiskoComboBox.SelectedItem = value;
        }
        public string Umowa

        { get => GetSelectedRadioButtonText();  
                
        }
        public int ListBox
        {
            get => ListaPracownikowListBox.SelectedIndex;
        }
        public void UstawRadioButtonUmowaNaCzasNieOkreslony()
        {
            UmowaNaCzasNieokreslonyRadioButton.Checked = true;
        }
        public void UstawRadioButtonUmowaNaCzasOkreslony()
        {
            UmowaNaCzasOkreslonyRadioButton.Checked = true;
        }
        public void UstawRadioButtonUmowaZlecenia()
        {
            UmowaZleceniaRadioButton.Checked = true;
        }







        //public void ShowPracownik(string pracownik)
        //{
        //    ListaPracownikowListBox.Items.Add(pracownik);
        //}

        public void ShowPracownik(string pracownik)
        {
            ListaPracownikowListBox.Items.Add(pracownik);
        }


        private void Combobox_loading(object sender, EventArgs e)
        {
            StanowiskoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
            DodajPracownika?.Invoke();
           // _presenter.DodajPracownika();
        }

        private void ZapiszButton_Click(object sender, EventArgs e)
        {
            ZapiszPracownikow?.Invoke();
           // _presenter.ZapiszPracownikow();
        }

        private void WczytajButton_Click(object sender, EventArgs e)
        {
            WczytajPracownikow?.Invoke();
           // _presenter.WczytajPracownikow();
        }

        private void ListaPracownikowListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            WybierzPracownika?.Invoke();
            // _presenter.WybierzPracownika();
        }


        private string GetSelectedRadioButtonText()
        {
           
            if (UmowaNaCzasNieokreslonyRadioButton.Checked) 
            {
                
                return "umowa na czas nieokreślony";
            }
            else if (UmowaNaCzasOkreslonyRadioButton.Checked) 
            {
                return "umowa na czas określony";
            }
            else if (UmowaZleceniaRadioButton.Checked) 
            {
                
                return "umowa zlecenia";
            }
            else
            {
                return "Error!";
            }
            
        }

        public void ClearForm()
        {
            ImieTextBox.Clear();
            NazwiskoTextBox.Clear();
            DataUrodzeniaDataTimePicker.Value = DateTime.Now;
            PensjaNumericUpDown.Value = 0;
            StanowiskoComboBox.SelectedIndex = -1;
            UmowaNaCzasNieokreslonyRadioButton.Checked = false;
            UmowaNaCzasOkreslonyRadioButton.Checked = false;
            UmowaZleceniaRadioButton.Checked = false;
        }

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
    }
}
