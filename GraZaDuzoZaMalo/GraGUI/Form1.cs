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
        public static Gra g;
        DateTime d = new DateTime();


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBoxLosuj.Visible = true;
            buttonNowaGra.Enabled = false;
            groupBoxLosuj.Enabled = true;
            groupBoxKoniec.Visible = false;
            groupBoxGra.Visible = false;
            buttonHistoria.Enabled = false;
            d = new DateTime(0);
            labelOdpowiedz.Text = "OdpowiedŸ";
            labelOdpowiedz.ForeColor = System.Drawing.Color.Black;
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


                groupBoxGra.Visible = true;
                groupBoxLosuj.Enabled = false;
                groupBoxGra.Enabled = true;
                buttonHistoria.Enabled = true;
                buttonPrzerwij.Enabled = true;
                timer1.Enabled = true;
            }
            catch(System.FormatException)
            {
                MessageBox.Show("B³êdne dane");
                textBoxOd.Enabled = textBoxDo.Enabled = true;
                groupBoxGra.Visible = false;
                groupBoxLosuj.Enabled = true;
                groupBoxGra.Enabled = false;
                buttonHistoria.Enabled = false;
                buttonPrzerwij.Enabled = false;
            }
            
        }

        private void ButtonPrzerwij_Click(object sender, EventArgs e)
        {
            groupBoxKoniec.Visible = true;
            buttonNowaGra.Enabled = true;
            g.Poddaj();
            groupBoxKoniec.Visible = true;
            labelWylosowanaD.Text = g.Wylosowana.ToString();
            labelLiczbaRuchowD.Text = g.LicznikRuchow.ToString();
            groupBoxGra.Enabled = false;
            buttonNowaGra.Enabled = true;
            buttonPrzerwij.Enabled = false;
            labelOdgadnieta.Text = "Poddano";
            labelOdgadnieta.ForeColor = System.Drawing.Color.Red;
            timer1.Enabled = false;


        }

        private void ButtonSprawdz_Click(object sender, EventArgs e)
        {
            try
            {
                var c = int.Parse(textBoxPropozycja.Text);

                var o = (int)g.Ocena(c);

                if (o == 1)
                {
                    labelOdpowiedz.Text = "Trafiono";
                    groupBoxKoniec.Visible = true;
                    labelWylosowanaD.Text = g.Wylosowana.ToString();
                    labelLiczbaRuchowD.Text = g.LicznikRuchow.ToString();
                    groupBoxGra.Enabled = false;
                    buttonNowaGra.Enabled = true;
                    buttonPrzerwij.Enabled = false;
                    labelOdpowiedz.ForeColor = System.Drawing.Color.Green;
                    labelOdgadnieta.Text = "Odgadniêta";
                    labelOdpowiedz.ForeColor = System.Drawing.Color.Green;
                    timer1.Enabled = false;
                }
                else if (o == -1)
                {
                    labelOdpowiedz.Text = "Za ma³o";
                    labelOdpowiedz.ForeColor = System.Drawing.Color.Blue;
                }
                else if (o == 0)
                {
                    labelOdpowiedz.Text = "Za du¿o";
                    labelOdpowiedz.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch(System.FormatException)
            {
                MessageBox.Show("B³êdna liczba");
            }
            
        }

        private void ButtonHistoria_Click(object sender, EventArgs e)
        {
            Form Historia = new HistoriaForm();
            Historia.Show();
        }

        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            Form About = new AboutBox1();
            About.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            labelTimer.Text = d.ToString("HH:mm:ss");
            d = d.AddSeconds(1);
        }
    }
}