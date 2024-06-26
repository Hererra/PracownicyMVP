using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.View
{
    //public class View
    //{
    public interface IView {
        string Imie { get; set; }
        string Nazwisko { get; set; }
        string Data { get; set; }
        string Pensja { get; set; }
        string Stanowisko { get; set; }
        string Umowa { get; }
        int ListBox { get; }
        event Action DodajPracownika;
        event Action ZapiszPracownikow;
        event Action WybierzPracownika;
        event Action WczytajPracownikow;
        event Action UsunPracownikow;
        void ShowPracownik(string pracownik);
        void ClearForm();
        void ShowErrorMessage(string message);
        void UstawRadioButtonUmowaNaCzasNieOkreslony();
        void UstawRadioButtonUmowaNaCzasOkreslony();
        void UstawRadioButtonUmowaZlecenia();
    }

    //}
}
