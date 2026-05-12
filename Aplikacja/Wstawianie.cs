using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Aplikacja
{
    public  class Wstawianie : Sortowanie_elementarne
    {
        public override void Sortuj(int[] tab)
        {
            int przechowalnia;
            for (int i = 0; i < dlugosc_ciagu -1; i++) 
            {
                for (int j = 0; j < dlugosc_ciagu -1; j++)
                {
                    if (tab[j + 1] < tab[j])
                    {
                        przechowalnia = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = przechowalnia;
                    }
                }
            }
        }
      
    }
}
