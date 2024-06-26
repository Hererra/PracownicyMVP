using System;
using System.Collections.Generic;
using System.Text;

using WinFormsApp1.View;
using System.Xml.Serialization;
using System.IO;

namespace WinFormsApp1.Presenter
{
    public class MainPresenter
    {
        private View.IView _view;
        private List<Pracownik> _pracownicy;

        public MainPresenter(View.IView view){
            _view = view;
            _pracownicy = new List<Pracownik>();
            _view.DodajPracownika += _view_DodajPracownika;
            _view.ZapiszPracownikow += _view_ZapiszPracownikow;
            _view.WybierzPracownika += _view_WybierzPracownika;
            _view.UsunPracownikow += _view_UsunPracownikow;
            _view.WczytajPracownikow += _view_WczytajPracownikow;
        }
        private void _view_DodajPracownika()
        {
            DodajPracownika();
        }

        private void _view_WczytajPracownikow()
        {
            WczytajPracownikow();
        }

        private void _view_UsunPracownikow()
        {
            UsunPracownika();
        }

        private void _view_WybierzPracownika()
        {
            WybierzPracownika();
        }

        private void _view_ZapiszPracownikow()
        {
            ZapiszPracownikow();
        }

        

        public void DodajPracownika()
        {
            string imie = _view.Imie;
            string nazwisko = _view.Nazwisko;
            string data = _view.Data.ToString();
            string pensja = _view.Pensja.ToString();
            string stanowisko = _view.Stanowisko;
            string umowa = _view.Umowa;

            Pracownik pracownik = new Pracownik(imie, nazwisko, data, pensja, stanowisko, umowa);
            _pracownicy.Add(pracownik);

            _view.ShowPracownik(pracownik.ToString());
            _view.ClearForm();
            
        }
        public void ZapiszPracownikow()
        {
            try
            {
                using (FileStream fileStream = new FileStream("pracownicy.xml", FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Pracownik>));
                    serializer.Serialize(fileStream, _pracownicy);
                }
            }
            catch (Exception ex)
            {
                _view.ShowErrorMessage($"Błąd podczas zapisywania pracowników: {ex.Message}");
            }
        }
        public void WczytajPracownikow()
        {
            try
            {
                using (FileStream fileStream = new FileStream("pracownicy.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Pracownik>));
                    _pracownicy.Clear();
                    _pracownicy.AddRange((List<Pracownik>)serializer.Deserialize(fileStream));

                    foreach (Pracownik pracownik in _pracownicy)
                    {
                        _view.ShowPracownik(pracownik.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                _view.ShowErrorMessage($"Błąd podczas wczytywania pracowników: {ex.Message}");
            }
        }
        public void WybierzPracownika()
        {   
                


            int index = _view.ListBox;
            if (index >= 0 && index < _pracownicy.Count)
            {
                Pracownik pracownik = _pracownicy[index];
                _view.ClearForm();
                _view.Imie = pracownik.Imie;
                _view.Nazwisko = pracownik.Nazwisko;
                _view.Data = pracownik.Data.ToString();
                _view.Pensja = pracownik.Pensja.ToString();
                _view.Stanowisko = pracownik.Stanowisko;
                if (pracownik.Umowa == "umowa na czas nieokreślony")
                {
                    _view.UstawRadioButtonUmowaNaCzasNieOkreslony();
                }
                else if (pracownik.Umowa == "umowa na czas określony")
                {
                    _view.UstawRadioButtonUmowaNaCzasOkreslony();
                }
                else if (pracownik.Umowa == "umowa zlecenia")
                {
                    _view.UstawRadioButtonUmowaZlecenia();
                }
            }



                //if (index >= -1 && index < _pracownicy.Count)
                //{
                //    Pracownik pracownik = _pracownicy[index];
                //    _view.ClearForm();
                //    _view.Imie = pracownik.Imie;
                //    _view.Nazwisko = pracownik.Nazwisko;
                //    _view.Data = pracownik.Data.ToString();
                //    _view.Pensja = pracownik.Pensja.ToString();
                //    _view.Stanowisko = pracownik.Stanowisko;
                //    //_view.Umowa = pracownik.Umowa;
                //}


            }
            public void UsunPracownika()
        {
            int index = _view.ListBox;
            if (index >= 0 && index < _pracownicy.Count)
            {
                _pracownicy.RemoveAt(index);
                _view.ClearForm();
            }
        }


    }
}
