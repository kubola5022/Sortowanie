using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    public class Scalanie : Sortowanie_zlozone
    {
      public void Dziel(int[] tab, int lewy, int srodek, int prawy)
        {
            int d1 = srodek - lewy + 1;
            int d2 = prawy - srodek;

            int[] tab1 = new int[d1];
            int[] tab2 = new int[d2];

            // Kopiujemy dane do tablic tymczasowych tab1[] i tab2[]
            for (int u = 0; u < d1; u++)
                tab1[u] = tab[lewy + u];
            for (int m = 0; m < d2; m++)
                tab2[m] = tab[srodek + 1 + m];

            int k = lewy;
            int i = 0;
            int j = 0;

            while (i < d1 && j < d2)
            {
                if (tab1[i] <= tab2[j])
                {
                    tab[k] = tab1[i];
                    i++;
                }
                else
                {
                    tab[k] = tab2[j];
                    j++;
                }
                k++;
            }

            while (i < d1)
            {
                tab[k] = tab1[i];
                i++;
                k++;
            }

            while (j < d2)
            {
                tab[k] = tab2[j];
                j++;
                k++;
            }
        }

        public override void Sortuj(int[] tab, int lewy, int prawy)
        {
            if (lewy < prawy)
            {
                int srodek = lewy + (prawy - lewy) / 2;

                Sortuj(tab, lewy, srodek);
                Sortuj(tab, srodek + 1, prawy);

                Dziel(tab, lewy, srodek, prawy);
            }

        }

    }
}
