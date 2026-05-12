using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
   public class Wybor : Sortowanie_elementarne
    {
        protected internal int min;

        public override void Sortuj(int[] tab)
        {
            for (int i = 0; i < dlugosc_ciagu -1; i++)
            {
                int min = i;

                for (int j = i + 1; j < dlugosc_ciagu; j++)
                {
                    if (tab[j] < tab[min])
                    {
                        min = j;
                    }
                }

                int temp = tab[i];
                tab[i] = tab[min];
                tab[min] = temp;
            }
        }
    }
}
