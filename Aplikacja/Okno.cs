using System;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplikacja
{
    public partial class Okno : Form
    {

        public Babelkowe zmienna;
        public Szybkie szybkie;
        public Wstawianie wstawianie;
        public Scalanie scalanie;
        public Wybor wybor;
        public Okno()
        {
            InitializeComponent();




        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            zmienna = new Babelkowe();
            szybkie = new Szybkie();
            wstawianie = new Wstawianie();
            scalanie = new Scalanie();
            wybor = new Wybor();

            if (int.TryParse(textBox1.Text, out int value)
                && int.TryParse(textBox2.Text, out int value2)
                && int.TryParse(textBox3.Text, out int value3))
            {
                //Babelkowe
                zmienna.dlugosc_ciagu = value3;
                zmienna.zakres1 = value;
                zmienna.zakres2 = value2;
                //Szbykie
                szybkie.dlugosc_ciagu = value3;
                szybkie.zakres1 = value;
                szybkie.zakres2 = value2;
                //Wstawianie
                wstawianie.dlugosc_ciagu = value3;
                wstawianie.zakres1 = value;
                wstawianie.zakres2 = value2;
                //scalanie
                scalanie.dlugosc_ciagu = value3;
                scalanie.zakres1 = value;
                scalanie.zakres2 = value2;
                //wybor
                wybor.dlugosc_ciagu = value3;
                wybor.zakres1 = value;
                wybor.zakres2 = value2;
            }
            else
            {
                Console.WriteLine("Sprobuj innej zmiennej!!!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            zmienna.tablica = new int[zmienna.dlugosc_ciagu];
            szybkie.tablica = new int[szybkie.dlugosc_ciagu];
            wstawianie.tablica = new int[wstawianie.dlugosc_ciagu];
            scalanie.tablica = new int[scalanie.dlugosc_ciagu];
            wybor.tablica = new int[wybor.dlugosc_ciagu];

            // BABELKOWE
            if (checkBox1.Checked == true)
            {
                if (checkBox7.Checked == true)
                {
                    zmienna.Generuj_losowo(zmienna.tablica);
                    chart1.Series.Clear();
                    chart1.Series.Add("Liczby Ciągu");
                    zmienna.dodaj_na_wykres(chart1, chart1.Series["Liczby Ciągu"], zmienna.tablica);


                }

                if (checkBox8.Checked == true)
                {
                    zmienna.Generuj_malejaco(zmienna.tablica);

                    chart1.Series.Clear();

                    chart1.Series.Add("Liczby Ciągu");
                    zmienna.dodaj_na_wykres(chart1, chart1.Series["Liczby Ciągu"], zmienna.tablica);
                }

                if (checkBox6.Checked == true)
                {
                    zmienna.Generuj_rosnaco(zmienna.tablica);

                    chart1.Series.Clear();

                    chart1.Series.Add("Liczby Ciągu");
                    zmienna.dodaj_na_wykres(chart1, chart1.Series["Liczby Ciągu"], zmienna.tablica);
                }
            }
            // SZYBKIE
            if (checkBox4.Checked == true)
            {
                if (checkBox7.Checked == true)
                {
                    szybkie.Generuj_losowo(szybkie.tablica);
                    chart1.Series.Clear();
                    chart1.Series.Add("Liczby Ciągu");
                    szybkie.dodaj_na_wykres(chart1, chart1.Series["Liczby Ciągu"], szybkie.tablica);

                }
                if (checkBox8.Checked == true)
                {
                    szybkie.Generuj_malejaco(szybkie.tablica);

                    chart1.Series.Clear();
                    chart1.Series.Add("Liczby Ciągu");
                    szybkie.dodaj_na_wykres(chart1, chart1.Series["Liczby Ciągu"], szybkie.tablica);
                }
                if (checkBox6.Checked == true)
                {
                    szybkie.Generuj_rosnaco(szybkie.tablica);
                    chart1.Series.Clear();
                    chart1.Series.Add("Liczby Ciągu");
                    szybkie.dodaj_na_wykres(chart1, chart1.Series["Liczby Ciągu"], szybkie.tablica);
                }
            }
            // wstawianie 
            if (checkBox5.Checked == true)
            {
                if (checkBox7.Checked == true)
                {
                    wstawianie.Generuj_losowo(wstawianie.tablica);
                    chart1.Series.Clear();
                    chart1.Series.Add("Liczby Ciągu");
                    wstawianie.dodaj_na_wykres(chart1, chart1.Series["Liczby Ciągu"], wstawianie.tablica);
                }
                if (checkBox8.Checked == true)
                {
                    wstawianie.Generuj_malejaco(wstawianie.tablica);
                    chart1.Series.Clear();
                    chart1.Series.Add("Liczby Ciągu");
                    wstawianie.dodaj_na_wykres(chart1, chart1.Series["Liczby Ciągu"], wstawianie.tablica);
                }
                if (checkBox6.Checked == true)
                {
                    wstawianie.Generuj_rosnaco(wstawianie.tablica);
                    chart1.Series.Clear();
                    chart1.Series.Add("Liczby Ciągu");
                    wstawianie.dodaj_na_wykres(chart1, chart1.Series["Liczby Ciągu"], wstawianie.tablica);
                }
            }       //wstawianie koniec

            // scalanie 
            if (checkBox2.Checked == true)
            {
                if (checkBox7.Checked == true)
                {
                    scalanie.Generuj_losowo(scalanie.tablica);
                    chart1.Series.Clear();
                    chart1.Series.Add("Liczby Ciągu");
                    scalanie.dodaj_na_wykres(chart1, chart1.Series["Liczby Ciągu"], scalanie.tablica);
                }
                if (checkBox8.Checked == true)
                {
                    scalanie.Generuj_malejaco(scalanie.tablica);
                    chart1.Series.Clear();
                    chart1.Series.Add("Liczby Ciągu");
                    scalanie.dodaj_na_wykres(chart1, chart1.Series["Liczby Ciągu"], scalanie.tablica);
                }
                if (checkBox6.Checked == true)
                {
                    scalanie.Generuj_rosnaco(scalanie.tablica);
                    chart1.Series.Clear();
                    chart1.Series.Add("Liczby Ciągu");
                    scalanie.dodaj_na_wykres(chart1, chart1.Series["Liczby Ciągu"], scalanie.tablica);
                }
            }          // sclanie koniec
                       //wybor
            if (checkBox3.Checked == true)
            {
                if (checkBox7.Checked == true)
                {
                    wybor.Generuj_losowo(wybor.tablica);
                    chart1.Series.Clear();
                    chart1.Series.Add("Liczby Ciągu");
                    wybor.dodaj_na_wykres(chart1, chart1.Series["Liczby Ciągu"], wybor.tablica);
                }
                if (checkBox8.Checked == true)
                {
                    wybor.Generuj_malejaco(wybor.tablica);
                    chart1.Series.Clear();
                    chart1.Series.Add("Liczby Ciągu");
                    wybor.dodaj_na_wykres(chart1, chart1.Series["Liczby Ciągu"], wybor.tablica);
                }
                if (checkBox6.Checked == true)
                {
                    wybor.Generuj_rosnaco(wybor.tablica);
                    chart1.Series.Clear();
                    chart1.Series.Add("Liczby Ciągu");
                    wybor.dodaj_na_wykres(chart1, chart1.Series["Liczby Ciągu"], wybor.tablica);
                } //wybor koniec
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Stopwatch stoper = new Stopwatch();
            dataGridView1.Columns.Add("Kolumna", "Algorytm");
            dataGridView1.Columns.Add("Kolumna2", "Elementy");
            dataGridView1.Columns.Add("Kolumna3", "Czas");
            // BABELKOWE
            if (checkBox1.Checked == true &&(checkBox7.Checked == true || checkBox8.Checked == true ||
                checkBox6.Checked == true))
            {
                stoper.Start();
                zmienna.Sortuj(zmienna.tablica);
                stoper.Stop();
                chart1.Series.Clear();
                chart1.Series.Add("Liczby Ciągu");
                zmienna.dodaj_na_wykres(chart1, chart1.Series["Liczby Ciągu"], zmienna.tablica);
                textBox4.Text = stoper.ElapsedMilliseconds.ToString() + "ms";
               
                if (checkBox7.Checked == true)
                {
                    dataGridView1.Rows.Add("Losowy", zmienna.dlugosc_ciagu.ToString(), stoper.ElapsedMilliseconds.ToString() + "ms");                
                }if(checkBox8.Checked == true) 
                {
                    dataGridView1.Rows.Add("Malejacy", zmienna.dlugosc_ciagu.ToString(), stoper.ElapsedMilliseconds.ToString() + "ms");
                }if(checkBox6.Checked == true) 
                {
                    dataGridView1.Rows.Add("Rosnacy", zmienna.dlugosc_ciagu.ToString(), stoper.ElapsedMilliseconds.ToString() + "ms");
                }
                Console.WriteLine($"Czas sortowania dla {zmienna.nazwa}: {stoper.ElapsedMilliseconds} ms");
            }
                //Babelkowe KONIEC
            //SZYBKIE
            if (checkBox4.Checked == true &&
                (checkBox7.Checked == true || checkBox8.Checked == true ||
                checkBox6.Checked==true))
               {
                stoper.Start();
                szybkie.Sortuj(szybkie.tablica, 0, szybkie.dlugosc_ciagu - 1);

                stoper.Stop();
                chart1.Series.Clear();
                chart1.Series.Add("Liczby Ciągu");
                szybkie.dodaj_na_wykres(chart1, chart1.Series["Liczby Ciągu"], szybkie.tablica);
                textBox4.Text = stoper.ElapsedMilliseconds.ToString() + "ms";
                dataGridView1.Rows.Add("Szybkie");
               
                if (checkBox7.Checked == true)
                {
                    dataGridView1.Rows.Add("Losowy", szybkie.dlugosc_ciagu.ToString(), stoper.ElapsedMilliseconds.ToString() + "ms");
                }
                if (checkBox8.Checked == true)
                {
                    dataGridView1.Rows.Add("Malejacy", szybkie.dlugosc_ciagu.ToString(), stoper.ElapsedMilliseconds.ToString() + "ms");
                }
                if (checkBox6.Checked == true)
                {
                    dataGridView1.Rows.Add("Rosnacy", szybkie.dlugosc_ciagu.ToString(), stoper.ElapsedMilliseconds.ToString() + "ms");
                }
                Console.WriteLine($"Czas sortowania dla {szybkie.nazwa}: {stoper.ElapsedMilliseconds} ms");

            } //SZYBKIE STOP
                    
                       //wybor
                     if(checkBox3.Checked == true &&(checkBox7.Checked == true || checkBox8.Checked == true ||
                checkBox6.Checked == true)) 
                   {
                stoper.Start();
                wybor.Sortuj(wybor.tablica);
                stoper.Stop();
                chart1.Series.Clear();
                chart1.Series.Add("Liczby Ciągu");
                wybor.dodaj_na_wykres(chart1, chart1.Series["Liczby Ciągu"], wybor.tablica);
                textBox4.Text = stoper.ElapsedMilliseconds.ToString() + "ms";
                dataGridView1.Rows.Add("Wybor");
                if (checkBox7.Checked == true)
                {
                    dataGridView1.Rows.Add("Losowy", wybor.dlugosc_ciagu.ToString(), stoper.ElapsedMilliseconds.ToString() + "ms");
                }
                if (checkBox8.Checked == true)
                {
                    dataGridView1.Rows.Add("Malejacy", wybor.dlugosc_ciagu.ToString(), stoper.ElapsedMilliseconds.ToString() + "ms");
                }
                if (checkBox6.Checked == true)
                {
                    dataGridView1.Rows.Add("Rosnacy", wybor.dlugosc_ciagu.ToString(), stoper.ElapsedMilliseconds.ToString() + "ms");
                }
                Console.WriteLine($"Czas sortowania dla {wybor.nazwa}: {stoper.ElapsedMilliseconds} ms");

            } // wybor koniec
                        
                

                //WSTAWIANIE
                if(checkBox5.Checked == true && (checkBox7.Checked == true || checkBox8.Checked == true
                      || checkBox6.Checked == true))
                {
                stoper.Start();
                wstawianie.Sortuj(wstawianie.tablica);
                stoper.Stop();
                chart1.Series.Clear();
                chart1.Series.Add("Liczby Ciągu");
                wstawianie.dodaj_na_wykres(chart1, chart1.Series["Liczby Ciągu"], wstawianie.tablica);
                textBox4.Text = stoper.ElapsedMilliseconds.ToString() + "ms";
                dataGridView1.Rows.Add("Wstawianie");
                if (checkBox7.Checked == true)
                {
                    dataGridView1.Rows.Add("Losowy", wstawianie.dlugosc_ciagu.ToString(), stoper.ElapsedMilliseconds.ToString() + "ms");
                }
                if (checkBox8.Checked == true)
                {
                    dataGridView1.Rows.Add("Malejacy", wstawianie.dlugosc_ciagu.ToString(), stoper.ElapsedMilliseconds.ToString() + "ms");
                }
                if (checkBox6.Checked == true)
                {
                    dataGridView1.Rows.Add("Rosnacy", wstawianie.dlugosc_ciagu.ToString(), stoper.ElapsedMilliseconds.ToString() + "ms");
                }
                Console.WriteLine($"Czas sortowania dla {wstawianie.nazwa}: {stoper.ElapsedMilliseconds} ms");


            }//wstawianie stop
                  
                //scalanie
                if(checkBox2.Checked == true && (checkBox7.Checked == true || checkBox8.Checked == true
                      || checkBox6.Checked == true)) 
                {
                stoper.Start();
                scalanie.Sortuj(scalanie.tablica, 0, scalanie.dlugosc_ciagu - 1);
                stoper.Stop();
                chart1.Series.Clear();
                chart1.Series.Add("Liczby Ciągu");
                scalanie.dodaj_na_wykres(chart1, chart1.Series["Liczby Ciągu"], scalanie.tablica);
                textBox4.Text = stoper.ElapsedMilliseconds.ToString() + "ms";
                dataGridView1.Rows.Add("Scalanie");
                if (checkBox7.Checked == true)
                {
                    dataGridView1.Rows.Add("Losowy", scalanie.dlugosc_ciagu.ToString(), stoper.ElapsedMilliseconds.ToString() + "ms");
                }
                if (checkBox8.Checked == true)
                {
                    dataGridView1.Rows.Add("Malejacy", scalanie.dlugosc_ciagu.ToString(), stoper.ElapsedMilliseconds.ToString() + "ms");
                }
                if (checkBox6.Checked == true)
                {
                    dataGridView1.Rows.Add("Rosnacy", scalanie.dlugosc_ciagu.ToString(), stoper.ElapsedMilliseconds.ToString() + "ms");
                }
                Console.WriteLine($"Czas sortowania dla {scalanie.nazwa}: {stoper.ElapsedMilliseconds} ms");

            }
                     // scalanie koniec
            }

          }

        
    }
    



