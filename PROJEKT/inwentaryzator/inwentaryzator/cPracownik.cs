using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inwentaryzator
{
    public class cPracownik
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string login { get; set; }
        public string haslo { get; set; }
        public string uprawnienia { get; set; }
        public string informacje { get; set; }

        public cPracownik(string _imie, string _nazwisko, string _login, string _haslo, string _uprawnienia, string _informacje)
        {
            imie = _imie;
            nazwisko = _nazwisko;
            login = _login;
            haslo = _haslo;
            uprawnienia = _uprawnienia;
            informacje = _informacje;
        }
    }
}
