namespace WindowsFormsApp1
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
            this.NowaGra = new System.Windows.Forms.Button();
            this.Losowanie = new System.Windows.Forms.GroupBox();
            this.ZakresOd = new System.Windows.Forms.Label();
            this.ZakresDo = new System.Windows.Forms.Label();
            this.Losuj = new System.Windows.Forms.Button();
            this.Losowanie.SuspendLayout();
            this.SuspendLayout();
            // 
            // NowaGra
            // 
            this.NowaGra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NowaGra.Location = new System.Drawing.Point(32, 35);
            this.NowaGra.Name = "NowaGra";
            this.NowaGra.Size = new System.Drawing.Size(75, 23);
            this.NowaGra.TabIndex = 0;
            this.NowaGra.Text = "Nowa gra";
            this.NowaGra.UseVisualStyleBackColor = true;
            this.NowaGra.Click += new System.EventHandler(this.button1_Click);
            // 
            // Losowanie
            // 
            this.Losowanie.Controls.Add(this.ZakresDo);
            this.Losowanie.Controls.Add(this.ZakresOd);
            this.Losowanie.Location = new System.Drawing.Point(47, 104);
            this.Losowanie.Name = "Losowanie";
            this.Losowanie.Size = new System.Drawing.Size(200, 100);
            this.Losowanie.TabIndex = 1;
            this.Losowanie.TabStop = false;
            this.Losowanie.Text = "Losowanie";
            // 
            // ZakresOd
            // 
            this.ZakresOd.AutoSize = true;
            this.ZakresOd.Location = new System.Drawing.Point(21, 20);
            this.ZakresOd.Name = "ZakresOd";
            this.ZakresOd.Size = new System.Drawing.Size(58, 13);
            this.ZakresOd.TabIndex = 0;
            this.ZakresOd.Text = "Zakres od:";
            // 
            // ZakresDo
            // 
            this.ZakresDo.AutoSize = true;
            this.ZakresDo.Location = new System.Drawing.Point(21, 55);
            this.ZakresDo.Name = "ZakresDo";
            this.ZakresDo.Size = new System.Drawing.Size(58, 13);
            this.ZakresDo.TabIndex = 1;
            this.ZakresDo.Text = "Zakres do:";
            // 
            // Losuj
            // 
            this.Losuj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Losuj.Location = new System.Drawing.Point(244, 139);
            this.Losuj.Name = "Losuj";
            this.Losuj.Size = new System.Drawing.Size(75, 23);
            this.Losuj.TabIndex = 2;
            this.Losuj.Text = "Wylosuj";
            this.Losuj.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 450);
            this.Controls.Add(this.Losuj);
            this.Controls.Add(this.Losowanie);
            this.Controls.Add(this.NowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Losowanie.ResumeLayout(false);
            this.Losowanie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NowaGra;
        private System.Windows.Forms.GroupBox Losowanie;
        private System.Windows.Forms.Label ZakresDo;
        private System.Windows.Forms.Label ZakresOd;
        private System.Windows.Forms.Button Losuj;
    }
}

