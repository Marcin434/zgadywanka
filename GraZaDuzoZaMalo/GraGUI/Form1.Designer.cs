namespace GraGUI
{
    partial class Form1
    {
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosuj = new System.Windows.Forms.GroupBox();
            this.buttonLosuj = new System.Windows.Forms.Button();
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.textBoxOd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHistoria = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonPrzerwij = new System.Windows.Forms.Button();
            this.groupBoxGra = new System.Windows.Forms.GroupBox();
            this.labelOdpowiedz = new System.Windows.Forms.Label();
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.textBoxPropozycja = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxKoniec = new System.Windows.Forms.GroupBox();
            this.labelOdgadnieta = new System.Windows.Forms.Label();
            this.labelLiczbaRuchowD = new System.Windows.Forms.Label();
            this.labelWylosowanaD = new System.Windows.Forms.Label();
            this.labelWylosowana = new System.Windows.Forms.Label();
            this.labelLiczbaRuchow = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.groupBoxLosuj.SuspendLayout();
            this.groupBoxGra.SuspendLayout();
            this.groupBoxKoniec.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(13, 12);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(75, 23);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBoxLosuj
            // 
            this.groupBoxLosuj.Controls.Add(this.buttonLosuj);
            this.groupBoxLosuj.Controls.Add(this.textBoxDo);
            this.groupBoxLosuj.Controls.Add(this.textBoxOd);
            this.groupBoxLosuj.Controls.Add(this.label2);
            this.groupBoxLosuj.Controls.Add(this.label1);
            this.groupBoxLosuj.Location = new System.Drawing.Point(13, 55);
            this.groupBoxLosuj.Name = "groupBoxLosuj";
            this.groupBoxLosuj.Size = new System.Drawing.Size(279, 112);
            this.groupBoxLosuj.TabIndex = 1;
            this.groupBoxLosuj.TabStop = false;
            this.groupBoxLosuj.Text = "Losowanie";
            this.groupBoxLosuj.Visible = false;
            // 
            // buttonLosuj
            // 
            this.buttonLosuj.Location = new System.Drawing.Point(185, 55);
            this.buttonLosuj.Name = "buttonLosuj";
            this.buttonLosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonLosuj.TabIndex = 4;
            this.buttonLosuj.Text = "Wylosuj";
            this.buttonLosuj.UseVisualStyleBackColor = true;
            this.buttonLosuj.Click += new System.EventHandler(this.buttonLosuj_Click);
            // 
            // textBoxDo
            // 
            this.textBoxDo.Location = new System.Drawing.Point(68, 73);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(100, 20);
            this.textBoxDo.TabIndex = 3;
            // 
            // textBoxOd
            // 
            this.textBoxOd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxOd.Location = new System.Drawing.Point(68, 28);
            this.textBoxOd.Name = "textBoxOd";
            this.textBoxOd.Size = new System.Drawing.Size(100, 20);
            this.textBoxOd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "zakres do:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "zakres od:";
            // 
            // buttonHistoria
            // 
            this.buttonHistoria.Enabled = false;
            this.buttonHistoria.Location = new System.Drawing.Point(12, 438);
            this.buttonHistoria.Name = "buttonHistoria";
            this.buttonHistoria.Size = new System.Drawing.Size(75, 23);
            this.buttonHistoria.TabIndex = 3;
            this.buttonHistoria.Text = "Historia gry";
            this.buttonHistoria.UseVisualStyleBackColor = true;
            this.buttonHistoria.Click += new System.EventHandler(this.ButtonHistoria_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(217, 438);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonInfo.TabIndex = 4;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.ButtonInfo_Click);
            // 
            // buttonPrzerwij
            // 
            this.buttonPrzerwij.Enabled = false;
            this.buttonPrzerwij.Location = new System.Drawing.Point(217, 12);
            this.buttonPrzerwij.Name = "buttonPrzerwij";
            this.buttonPrzerwij.Size = new System.Drawing.Size(75, 23);
            this.buttonPrzerwij.TabIndex = 5;
            this.buttonPrzerwij.Text = "Przerwij";
            this.buttonPrzerwij.UseVisualStyleBackColor = true;
            this.buttonPrzerwij.Click += new System.EventHandler(this.ButtonPrzerwij_Click);
            // 
            // groupBoxGra
            // 
            this.groupBoxGra.Controls.Add(this.labelTimer);
            this.groupBoxGra.Controls.Add(this.labelOdpowiedz);
            this.groupBoxGra.Controls.Add(this.buttonSprawdz);
            this.groupBoxGra.Controls.Add(this.textBoxPropozycja);
            this.groupBoxGra.Controls.Add(this.label3);
            this.groupBoxGra.Location = new System.Drawing.Point(13, 173);
            this.groupBoxGra.Name = "groupBoxGra";
            this.groupBoxGra.Size = new System.Drawing.Size(279, 148);
            this.groupBoxGra.TabIndex = 6;
            this.groupBoxGra.TabStop = false;
            this.groupBoxGra.Text = "Gra";
            this.groupBoxGra.Visible = false;
            // 
            // labelOdpowiedz
            // 
            this.labelOdpowiedz.AutoSize = true;
            this.labelOdpowiedz.Location = new System.Drawing.Point(19, 103);
            this.labelOdpowiedz.Name = "labelOdpowiedz";
            this.labelOdpowiedz.Size = new System.Drawing.Size(60, 13);
            this.labelOdpowiedz.TabIndex = 5;
            this.labelOdpowiedz.Text = "OdpowiedŸ";
            // 
            // buttonSprawdz
            // 
            this.buttonSprawdz.Location = new System.Drawing.Point(185, 52);
            this.buttonSprawdz.Name = "buttonSprawdz";
            this.buttonSprawdz.Size = new System.Drawing.Size(75, 23);
            this.buttonSprawdz.TabIndex = 4;
            this.buttonSprawdz.Text = "SprawdŸ";
            this.buttonSprawdz.UseVisualStyleBackColor = true;
            this.buttonSprawdz.Click += new System.EventHandler(this.ButtonSprawdz_Click);
            // 
            // textBoxPropozycja
            // 
            this.textBoxPropozycja.Location = new System.Drawing.Point(22, 55);
            this.textBoxPropozycja.Name = "textBoxPropozycja";
            this.textBoxPropozycja.Size = new System.Drawing.Size(100, 20);
            this.textBoxPropozycja.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Liczba wylosowana. Odgadnij j¹!";
            // 
            // groupBoxKoniec
            // 
            this.groupBoxKoniec.Controls.Add(this.labelOdgadnieta);
            this.groupBoxKoniec.Controls.Add(this.labelLiczbaRuchowD);
            this.groupBoxKoniec.Controls.Add(this.labelWylosowanaD);
            this.groupBoxKoniec.Controls.Add(this.labelWylosowana);
            this.groupBoxKoniec.Controls.Add(this.labelLiczbaRuchow);
            this.groupBoxKoniec.Location = new System.Drawing.Point(13, 327);
            this.groupBoxKoniec.Name = "groupBoxKoniec";
            this.groupBoxKoniec.Size = new System.Drawing.Size(279, 105);
            this.groupBoxKoniec.TabIndex = 8;
            this.groupBoxKoniec.TabStop = false;
            this.groupBoxKoniec.Text = "Koniec";
            this.groupBoxKoniec.Visible = false;
            // 
            // labelOdgadnieta
            // 
            this.labelOdgadnieta.AutoSize = true;
            this.labelOdgadnieta.ForeColor = System.Drawing.Color.Lime;
            this.labelOdgadnieta.Location = new System.Drawing.Point(182, 40);
            this.labelOdgadnieta.Name = "labelOdgadnieta";
            this.labelOdgadnieta.Size = new System.Drawing.Size(62, 13);
            this.labelOdgadnieta.TabIndex = 10;
            this.labelOdgadnieta.Text = "Odgadniêta";
            // 
            // labelLiczbaRuchowD
            // 
            this.labelLiczbaRuchowD.AutoSize = true;
            this.labelLiczbaRuchowD.Location = new System.Drawing.Point(104, 27);
            this.labelLiczbaRuchowD.Name = "labelLiczbaRuchowD";
            this.labelLiczbaRuchowD.Size = new System.Drawing.Size(13, 13);
            this.labelLiczbaRuchowD.TabIndex = 9;
            this.labelLiczbaRuchowD.Text = "0";
            // 
            // labelWylosowanaD
            // 
            this.labelWylosowanaD.AutoSize = true;
            this.labelWylosowanaD.Location = new System.Drawing.Point(104, 40);
            this.labelWylosowanaD.Name = "labelWylosowanaD";
            this.labelWylosowanaD.Size = new System.Drawing.Size(13, 13);
            this.labelWylosowanaD.TabIndex = 8;
            this.labelWylosowanaD.Text = "0";
            // 
            // labelWylosowana
            // 
            this.labelWylosowana.AutoSize = true;
            this.labelWylosowana.Location = new System.Drawing.Point(19, 40);
            this.labelWylosowana.Name = "labelWylosowana";
            this.labelWylosowana.Size = new System.Drawing.Size(71, 13);
            this.labelWylosowana.TabIndex = 7;
            this.labelWylosowana.Text = "Wylosowana:";
            // 
            // labelLiczbaRuchow
            // 
            this.labelLiczbaRuchow.AutoSize = true;
            this.labelLiczbaRuchow.Location = new System.Drawing.Point(19, 27);
            this.labelLiczbaRuchow.Name = "labelLiczbaRuchow";
            this.labelLiczbaRuchow.Size = new System.Drawing.Size(79, 13);
            this.labelLiczbaRuchow.TabIndex = 6;
            this.labelLiczbaRuchow.Text = "Liczba ruchów:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(201, 103);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(30, 13);
            this.labelTimer.TabIndex = 6;
            this.labelTimer.Text = "Czas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 471);
            this.Controls.Add(this.groupBoxKoniec);
            this.Controls.Add(this.groupBoxGra);
            this.Controls.Add(this.buttonPrzerwij);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonHistoria);
            this.Controls.Add(this.groupBoxLosuj);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxLosuj.ResumeLayout(false);
            this.groupBoxLosuj.PerformLayout();
            this.groupBoxGra.ResumeLayout(false);
            this.groupBoxGra.PerformLayout();
            this.groupBoxKoniec.ResumeLayout(false);
            this.groupBoxKoniec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxLosuj;
        private System.Windows.Forms.Button buttonLosuj;
        private System.Windows.Forms.TextBox textBoxDo;
        private System.Windows.Forms.TextBox textBoxOd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHistoria;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonPrzerwij;
        private System.Windows.Forms.GroupBox groupBoxGra;
        private System.Windows.Forms.Button buttonSprawdz;
        private System.Windows.Forms.TextBox textBoxPropozycja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelOdpowiedz;
        private System.Windows.Forms.GroupBox groupBoxKoniec;
        private System.Windows.Forms.Label labelWylosowanaD;
        private System.Windows.Forms.Label labelWylosowana;
        private System.Windows.Forms.Label labelLiczbaRuchow;
        private System.Windows.Forms.Label labelLiczbaRuchowD;
        private System.Windows.Forms.Label labelOdgadnieta;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTimer;
    }
}
