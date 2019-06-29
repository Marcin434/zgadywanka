namespace GraGUI
{
    partial class HistoriaForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Odp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kiedy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nr,
            this.Prop,
            this.Odp,
            this.Kiedy});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(292, 306);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged_1);
            // 
            // Nr
            // 
            this.Nr.Text = "Nr";
            this.Nr.Width = 30;
            // 
            // Prop
            // 
            this.Prop.Text = "Propozycja";
            this.Prop.Width = 68;
            // 
            // Odp
            // 
            this.Odp.Text = "Odpowiedź";
            this.Odp.Width = 75;
            // 
            // Kiedy
            // 
            this.Kiedy.Text = "Czas";
            this.Kiedy.Width = 111;
            // 
            // HistoriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 330);
            this.Controls.Add(this.listView1);
            this.Name = "HistoriaForm";
            this.Text = "HistoriaForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nr;
        private System.Windows.Forms.ColumnHeader Prop;
        private System.Windows.Forms.ColumnHeader Odp;
        private System.Windows.Forms.ColumnHeader Kiedy;
    }
}