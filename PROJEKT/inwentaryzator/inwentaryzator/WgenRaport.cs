using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace inwentaryzator
{
    public partial class WgenRaport : Form
    {
        public WgenRaport()
        {
            InitializeComponent();
            load_cbox();
        }

        //
        //Przycisk wyloguj
        //
        private void but_wyloguj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        //Wczytanie listy opcji dla combox
        //
        private void load_cbox()
        {
            combox_raport.Items.Add("Wszystkie produkty");
            combox_raport.Items.Add("Brakujące produkty");
            combox_raport.Items.Add("Spis pracowników");
        }
        //
        //Przycisk eksportu do XML
        //
        private void but_eksportXML_Click(object sender, EventArgs e)
        {
            switch(combox_raport.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Wybierze rodzaj raportu");
                    break;
                case 0:
                    rap_wszystkich_produktow();
                    break;
                case 1:
                    
                    break;
                case 2:
                    rap_wszystkich_pracownikow();
                    break;
            }
                

            
        }
        //
        //metoda do tworzenia i zapisywania raportu wszystkich produktów
        //
        private void rap_wszystkich_produktow()
        {
            try
            {
            //Plik z produktami
            XDocument xml = XDocument.Load(@".\inwentaryzator\\data\\baza.xml");

            //Utworzenie i wczytanie do listy produktów
            List<cProdukt> lista_produktow = (
                from produkt in xml.Root.Elements("PRODUKT")
                select new cProdukt(
                    produkt.Attribute("EAN13").Value,
                    produkt.Element("NAZWA").Value,
                    produkt.Element("OPIS").Value,
                    int.Parse(produkt.Element("ILOSC").Value),
                    float.Parse(produkt.Element("CENA").Value)
                    )
                ).ToList<cProdukt>();

              //Zczytanie produktów z listy do pliku xml
                XDocument raport_xml = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XComment("RAPORT: SPIS WSZYSTKICH PRODUKTÓW"),
                    new XElement("PRODUKTY",
                        from produkt in lista_produktow
                        orderby produkt.EAN13
                            select new XElement("PRODUKT",
                                new XAttribute("EAN13", produkt.EAN13),
                                new XElement("NAZWA", produkt.Nazwa),
                                new XElement("OPIS", produkt.Opis),
                                new XElement("ILOSC", produkt.Ilosc),
                                new XElement("CENA",produkt.Cena)
                                )
                        )
                    );

                //Wybranie miejsca zapisania
                string nazwa;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = @"C:\";              //początkowa ścieżka zapisu
                saveFileDialog1.AddExtension = true;                    //automatyczne dodawanie rozszerzenia
                saveFileDialog1.Title = "Eksportowanie raportu XML";    //Tytuł okna zapisu
                //saveFileDialog1.CheckFileExists = true;
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.DefaultExt = "xml";
                saveFileDialog1.Filter = "eXtensible Markup Language (*.xml)|*.xml";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    nazwa = saveFileDialog1.FileName;
                    raport_xml.Save(nazwa);
                }
            }
            catch
            {
                MessageBox.Show("Błąd wczytywania plików");
            }
        }
        //
        //metoda do tworzenia i zapisywania do pliku xml wszystkich pracowników
        //
        private void rap_wszystkich_pracownikow()
        {
            try
            {
                //Plik z pracownikami
                XDocument xml = XDocument.Load(@".\inwentaryzator\\data\\uzytkownicy.xml");

                //Utworzenie i wczytanie do listy pracowników
                List<cPracownik> lista_pracownikow = (
                    from pracownik in xml.Root.Elements("UZYTKOWNIK")
                    select new cPracownik(
                        pracownik.Element("IMIE").Value,
                        pracownik.Element("NAZWISKO").Value,
                        pracownik.Attribute("LOGIN").Value,
                        pracownik.Element("HASLO").Value,
                        pracownik.Element("UPRAWNIENIA").Value,
                        pracownik.Element("INFORMACJE").Value
                        )
                    ).ToList<cPracownik>();

                //Zczytanie pracowników z listy do pliku xml
                XDocument raport_xml = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XComment("RAPORT: SPIS WSZYSTKICH PRACOWNIKOW"),
                    new XElement("UZYTKOWNICY",
                        from pracownik in lista_pracownikow
                        orderby pracownik.login
                        select new XElement("UZYTKOWNIK",
                            new XAttribute("LOGIN", pracownik.login),
                            new XElement("HASLO", pracownik.haslo),
                            new XElement("IMIE", pracownik.imie),
                            new XElement("NAZWISKO", pracownik.nazwisko),
                            new XElement("UPRAWNIENIA", pracownik.uprawnienia),
                            new XElement("INFORMACJE", pracownik.informacje)
                            )
                        )
                    );

                //Wybranie miejsca zapisania
                string nazwa;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = @"C:\";              //początkowa ścieżka zapisu
                saveFileDialog1.AddExtension = true;                    //automatyczne dodawanie rozszerzenia
                saveFileDialog1.Title = "Eksportowanie raportu XML";    //Tytuł okna zapisu
                //saveFileDialog1.CheckFileExists = true;
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.DefaultExt = "xml";
                saveFileDialog1.Filter = "eXtensible Markup Language (*.xml)|*.xml";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    nazwa = saveFileDialog1.FileName;
                    raport_xml.Save(nazwa);
                }
            }
            catch
            {
                MessageBox.Show("Błąd wczytywania plików");
            }
        }
    }
}
