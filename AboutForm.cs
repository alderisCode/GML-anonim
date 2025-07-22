using DarkUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMLPretty
{

    public partial class AboutForm : DarkForm
    {


        string appName = "GML Anonim";
        string version = "1.0.0";
        string author = "(C) 2025 Grzegorz Olszewski\nStarostwo Powiatowe w Opolu";
        string copyright = "Licencja: GNU GPL 3";
        string link = "https://github.com/alderisCode/GML-anonim";
        string description = "Narzędzie do anonimizacji plików GML EGiB.";


        public AboutForm()
        {
            InitializeComponent();

            lbAppName.Text = appName;
            lbVersion.Text = "Wersja: " + version;
            lbAuthor.Text = author;
            lbCopyright.Text = copyright;
            lbLink.Text = link;
            lbAppInfo.Text = description;

        }

        private void lbLink_Click(object sender, EventArgs e)
        {
            // Open the link in the default web browser
            try
            {
                System.Diagnostics.Process.Start(link);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie można otworzyć linku: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Zamknięcie okna
            this.Close();
        }
    }
}
