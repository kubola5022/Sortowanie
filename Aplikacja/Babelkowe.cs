using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Aplikacja
{
    public class Babelkowe : Sortowanie_elementarne 
    {
        public override void Sortuj(int[] tablica)
        {

            int przechowalnia;
            for (int i = 0; i < dlugosc_ciagu - 1; i++)
            {
                for (int j = 0; j < dlugosc_ciagu - 1; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        przechowalnia = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = przechowalnia;
                    }
                }
            }
        }
        

        
    }
}
