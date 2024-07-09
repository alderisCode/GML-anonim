
namespace GML_anonim
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.darkTextBox1 = new DarkUI.Controls.DarkTextBox();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.btnUruchom = new DarkUI.Controls.DarkButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.darkGroupBox1 = new DarkUI.Controls.DarkGroupBox();
            this.lbAnon = new DarkUI.Controls.DarkLabel();
            this.lbLines = new DarkUI.Controls.DarkLabel();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.darkGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(26, 25);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(50, 13);
            this.darkLabel1.TabIndex = 0;
            this.darkLabel1.Text = "Plik GML";
            // 
            // darkTextBox1
            // 
            this.darkTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox1.Location = new System.Drawing.Point(29, 41);
            this.darkTextBox1.Name = "darkTextBox1";
            this.darkTextBox1.ReadOnly = true;
            this.darkTextBox1.Size = new System.Drawing.Size(730, 20);
            this.darkTextBox1.TabIndex = 1;
            // 
            // darkButton1
            // 
            this.darkButton1.Location = new System.Drawing.Point(765, 41);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(75, 20);
            this.darkButton1.TabIndex = 2;
            this.darkButton1.Text = "Otwórz...";
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // btnUruchom
            // 
            this.btnUruchom.Enabled = false;
            this.btnUruchom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUruchom.Location = new System.Drawing.Point(29, 116);
            this.btnUruchom.Name = "btnUruchom";
            this.btnUruchom.Padding = new System.Windows.Forms.Padding(5);
            this.btnUruchom.Size = new System.Drawing.Size(211, 75);
            this.btnUruchom.TabIndex = 3;
            this.btnUruchom.Text = "Anonimizuj";
            this.btnUruchom.Click += new System.EventHandler(this.btnUruchom_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "gml";
            this.openFileDialog1.Filter = "Pliki GML|*.gml|Wszystkie pliki|*.*";
            this.openFileDialog1.Title = "Otwórz plik GML-EGIB do anonimizacji";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // darkGroupBox1
            // 
            this.darkGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox1.Controls.Add(this.lbAnon);
            this.darkGroupBox1.Controls.Add(this.lbLines);
            this.darkGroupBox1.Controls.Add(this.darkLabel3);
            this.darkGroupBox1.Controls.Add(this.darkLabel2);
            this.darkGroupBox1.Location = new System.Drawing.Point(297, 116);
            this.darkGroupBox1.Name = "darkGroupBox1";
            this.darkGroupBox1.Size = new System.Drawing.Size(543, 75);
            this.darkGroupBox1.TabIndex = 4;
            this.darkGroupBox1.TabStop = false;
            this.darkGroupBox1.Visible = false;
            // 
            // lbAnon
            // 
            this.lbAnon.AutoSize = true;
            this.lbAnon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbAnon.Location = new System.Drawing.Point(151, 48);
            this.lbAnon.Name = "lbAnon";
            this.lbAnon.Size = new System.Drawing.Size(10, 13);
            this.lbAnon.TabIndex = 3;
            this.lbAnon.Text = "-";
            // 
            // lbLines
            // 
            this.lbLines.AutoSize = true;
            this.lbLines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbLines.Location = new System.Drawing.Point(151, 24);
            this.lbLines.Name = "lbLines";
            this.lbLines.Size = new System.Drawing.Size(10, 13);
            this.lbLines.TabIndex = 2;
            this.lbLines.Text = "-";
            // 
            // darkLabel3
            // 
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel3.Location = new System.Drawing.Point(27, 48);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(111, 13);
            this.darkLabel3.TabIndex = 1;
            this.darkLabel3.Text = "Zanonimizowane linie:";
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(27, 24);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(95, 13);
            this.darkLabel2.TabIndex = 0;
            this.darkLabel2.Text = "Przetworzone linie:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 226);
            this.Controls.Add(this.darkGroupBox1);
            this.Controls.Add(this.btnUruchom);
            this.Controls.Add(this.darkButton1);
            this.Controls.Add(this.darkTextBox1);
            this.Controls.Add(this.darkLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GML - anonimizacja";
            this.darkGroupBox1.ResumeLayout(false);
            this.darkGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkTextBox darkTextBox1;
        private DarkUI.Controls.DarkButton darkButton1;
        private DarkUI.Controls.DarkButton btnUruchom;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private DarkUI.Controls.DarkGroupBox darkGroupBox1;
        private DarkUI.Controls.DarkLabel lbAnon;
        private DarkUI.Controls.DarkLabel lbLines;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkLabel darkLabel2;
    }
}

