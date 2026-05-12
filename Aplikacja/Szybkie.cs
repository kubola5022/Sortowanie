using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Aplikacja
{
    public class Szybkie : Sortowanie_zlozone
    {
        // START SORT
        public override void Sortuj(int[] tab, int lewy, int prawy)
        {
            if (lewy < prawy)
            {
                int pivotIndex = Podziel(tab, lewy, prawy);
                Sortuj(tab, lewy, pivotIndex - 1);
                Sortuj(tab, pivotIndex + 1, prawy);
            }
        }

        private int Podziel(int[] tab, int lewy, int prawy)
        {
            int pivot = tab[prawy];
            int i = lewy - 1;

            for (int j = lewy; j < prawy; j++)
            {
                if (tab[j] <= pivot)
                {
                    i++;
                    Zamien(tab, i, j);
                }
            }

            Zamien(tab, i + 1, prawy);
            return i + 1;
        }

        private void Zamien(int[] tab, int a, int b)
        {
            int temp = tab[a];
            tab[a] = tab[b];
            tab[b] = temp;
        }

        

    
    }     

}

