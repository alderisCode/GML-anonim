using DarkUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GML_anonim
{
    public partial class Form1 : DarkForm
    {

        long LinesCount = 0;
        long AnonymCount = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                btnUruchom.Enabled = true;
                darkTextBox1.Text = openFileDialog1.FileName;
                darkGroupBox1.Visible = false;
            }
        }



        private void btnUruchom_Click(object sender, EventArgs e)
        {
            LinesCount = 0;
            AnonymCount = 0;
            darkGroupBox1.Visible = true;

            AnalizujPlik(openFileDialog1.FileName);
        }


        void AnalizujPlik(string path)
        {
            string path_dest;
            string newFileName = Path.GetFileNameWithoutExtension(path) + "_anonim";
            string dir = Path.GetDirectoryName(path);
            string ext = Path.GetExtension(path);
            path_dest = Path.Combine(dir, newFileName + ext);
            darkGroupBox1.Text = "Zapis do: " + newFileName + ext;
            //timer1.Enabled = true;         
            Application.DoEvents();

            bool multiLine = false;
            string multiLineText = "";

            using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (BufferedStream bs = new BufferedStream(fs))
            using (StreamReader sr = new StreamReader(bs))
            using (var writer = new StreamWriter(path_dest))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    LinesCount++;

                    if (multiLine)
                    {
                        line = multiLineText + line;
                    }


                    if (line.Contains("<egb:numerKW>") ||
                        line.Contains("<egb:numerElektronicznejKW>") ||
                        line.Contains("<egb:pierwszeImie>") ||
                        line.Contains("<egb:drugieImie>") ||
                        line.Contains("<egb:pierwszyCzlonNazwiska>") ||
                        line.Contains("<egb:drugiCzlonNazwiska>") ||
                        line.Contains("<egb:pesel>") ||
                        line.Contains("<egb:imieMatki>") ||
                        line.Contains("<egb:imieOjca>") ||
                        line.Contains("<egb:oznDokumentuStwierdzajacegoTozsamosc>") ||
                        line.Contains("<egb:kraj>") ||
                        line.Contains("<egb:miejscowosc>") ||
                        line.Contains("<egb:nazwaMiejscowosci>") ||
                        line.Contains("<egb:idMiejscowosci>") ||
                        line.Contains("<egb:terytMiejscowosci>") ||
                        line.Contains("<egb:ulica>") ||
                        line.Contains("egb:nazwaUlicy") ||
                        line.Contains("<egb:idNazwyUlicy>") ||
                        line.Contains("<egb:terytUlicy>") ||
                        line.Contains("<egb:numerPorzadkowy>") ||
                        line.Contains("<egb:nrLokalu>") ||
                        line.Contains("<egb:plec>") ||
                        line.Contains("<egb:opisZmiany>") ||
                        line.Contains("<egb:dodatkoweInformacje>") ||
                        line.Contains("<egb:dokumentWlasnosci>") || 
                        line.Contains("<egb:opisDokumentu>")
                        )
                    {
                        //DEBUG
                        //if (line.Length > 200)
                        //{
                        //    int a = 0; // Debug breakpoint
                        //}

                        // jeśli linia jest kompletna
                        if (line.Contains("</egb:"))
                        {
                            // jeśli to była multilinia, to kończymy jej składanie
                            if (multiLine)
                            {
                                multiLine = false;
                                multiLineText = "";
                            }

                        }
                        else
                        {
                            // początek multilinii
                            multiLine = true;
                            multiLineText = line;
                            continue;
                        }

                        line = SetXMLValue(line, "*****");


                        AnonymCount++;
                    }

                    writer.WriteLine(line);
                                        
                    if ((double)LinesCount / 1000 == Math.Round((double)LinesCount / 1000))
                    {
                        lbLines.Text = Liczba(LinesCount);
                        lbAnon.Text = Liczba(AnonymCount);
                        Application.DoEvents();
                    } 
                }

            }
            timer1.Enabled = false;
            darkGroupBox1.Text = newFileName + ext + " - Zakończono.";
            btnUruchom.Enabled = false;
            lbLines.Text = Liczba(LinesCount);
            lbAnon.Text = Liczba(AnonymCount);
            DarkMessageBox.ShowInformation("Anonimizacja zakończona", "Koniec", DarkDialogButton.Ok);
        }

        // Łączenie tekstu wieloliniowego w jeden ciąg bez znaków nowego wiersza
        string UsunZnakiNowegoWiersza(string tekst)
        {
            return tekst.Replace("\r", "").Replace("\n", "");
        }

        string SetXMLValue(string lineTxt, string Value)
        {
            if (LinesCount == 12015310) 
            { 
                var a = 1;                                                      // DEBUG
            }                      

            try
            {
                UsunZnakiNowegoWiersza(lineTxt);
                int pos1 = lineTxt.IndexOf('>');                        
                int pos2 = lineTxt.IndexOf('<', pos1);                          // szukamy pierwszego znaku '<' po znaku '>'

                var txt1 = lineTxt.Substring(0, pos1+1);
                var txt2 = lineTxt.Substring(pos2, lineTxt.Length-pos2);
                txt2 = String.Concat(txt1, Value, txt2);
                return txt2;  //wartość zmieniona
            }
            catch (Exception e)
            {
                DarkMessageBox.ShowWarning(e.Message + "\n\nLinia: " + Liczba(LinesCount) + "\n" + lineTxt, "Błąd podmiany wartości XML", DarkDialogButton.Ok);
            }
            return lineTxt;  //wartość niezmieniona
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbLines.Text = Liczba(LinesCount);
            lbAnon.Text = Liczba(AnonymCount);
            //Application.DoEvents();

        }

        private string Liczba(long num)
        {
            var S = num.ToString();
            var T = "";
            var L = S.Length;
            var counter = 0;
            for (int i = L; i>0; i--)
            {
                counter++;
                if (counter%3==0.0)       // reszta z dzielenia przez 3 (modulo)
                {
                    T = " " + S[i-1] + T;
                }
                else
                {
                    T = S[i - 1] + T;
                }
            }
            return T;
        }
    }

}
