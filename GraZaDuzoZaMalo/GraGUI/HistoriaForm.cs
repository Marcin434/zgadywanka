using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace GraGUI
{
    public partial class HistoriaForm : Form
    {
        public HistoriaForm()
        {
            InitializeComponent();

            int a = 1;
            foreach (Gra.Ruch historia in Form1.g.Historia)
            {
                ListViewItem h = new ListViewItem((a++).ToString());
                h.SubItems.Add(historia.propozycja.ToString());
                h.SubItems.Add(historia.odpowiedz.ToString());
                h.SubItems.Add(historia.kiedy.ToString());

                listView1.Items.Add(h);
            }
        }

        private void ListView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
