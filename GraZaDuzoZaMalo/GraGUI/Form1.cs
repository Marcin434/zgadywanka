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
    public partial class Form1 : Form
    {
        private Gra g;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBoxLosuj.Visible = true;
            buttonNowaGra.Enabled = false;
            groupBoxKoniec.Visible = false;
        }

        private void buttonLosuj_Click(object sender, EventArgs e)
        {

            var a = 0;
            var b = 0;


            try
            {
                a = int.Parse(textBoxOd.Text);
                b = int.Parse(textBoxDo.Text);

                g = new Gra(a, b);


                buttonLosuj.Enabled = false;
                textBoxOd.Enabled = textBoxDo.Enabled = false;
                groupBoxGra.Visible = true;

            }
            catch(System.FormatException)
            {
                MessageBox.Show("B³êdne dane");
                buttonLosuj.Enabled = true;
                textBoxOd.Enabled = textBoxDo.Enabled = true;
                groupBoxGra.Visible = false;

            }


            
        }
        private void TextBoxPropozycja_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void ButtonPrzerwij_Click(object sender, EventArgs e)
        {
            groupBoxKoniec.Visible = true;
            buttonNowaGra.Enabled = true;
            g.Poddaj();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void GroupBoxKoniec_Enter(object sender, EventArgs e)
        {

        }

        private void ButtonSprawdz_Click(object sender, EventArgs e)
        {
            var c = int.Parse(textBoxPropozycja.Text);

            var o = (int)g.Ocena(c);

            if (o == 1)
            {
                labelOdpowiedz.Text = "Trafiono";
                groupBoxKoniec.Visible = true;
            }
            else if (o == -1)
            {
                labelOdpowiedz.Text = "Za ma³o";
            }
            else if (o == 0)
            {
                labelOdpowiedz.Text = "Za du¿o";
            }
        }
    }
}