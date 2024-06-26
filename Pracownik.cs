using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    [Serializable]
    public class Pracownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Data { get; set; }
        public string Pensja { get; set; }
        public string Stanowisko { get; set; }
        public string Umowa { get; set; }

        public Pracownik()
        {
        }
        public Pracownik(string imie, string nazwisko, string data, string pensja, string stanowisko, string umowa)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Data = data;
            Pensja = pensja;
            Stanowisko = stanowisko;
            Umowa = umowa;
        }

        

        public override string ToString()
        {
            return $"{Imie} {Nazwisko} - {Stanowisko} - {Data} - {Pensja} - {Umowa}";
        }

    }
}
