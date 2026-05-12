using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Aplikacja
{
    public abstract class Sortowanie_zlozone
    {
        public int[] tablica;
        public int dlugosc_ciagu;

        public int zakres1;
        public int zakres2;
        public string nazwa;




         public abstract void Sortuj(int[] tab, int lewy , int prawy);
       
        public  void Generuj_losowo(int[] tab)
        {
            Random liczby = new Random();


            for (int i = 0; i < dlugosc_ciagu; i++)
            {
                tab[i] = liczby.Next(zakres1, zakres2);
                tablica[i] = tab[i];


            }
        }

        public void Generuj_malejaco(int[] tab)
        {
            for (int i = 0; i < dlugosc_ciagu; i++)
            {
                tab[i] = zakres2;
                tablica[i] = tab[i];
                zakres2--;

            }
        }
        public void Generuj_rosnaco(int[] tab)
        {
            for (int i = 0; i < dlugosc_ciagu; i++)
            {
                tab[i] = zakres1;
                tablica[i] = tab[i];
                zakres1++;

            }
        }
        public void dodaj_na_wykres(Chart chart, Series xd, int[] tab)
        {
            for (int i = 0; i < dlugosc_ciagu; i++)
            {
                chart.Series["Liczby Ciągu"].Points.AddXY(i, tablica[i]);

            }
        }
    }
}
