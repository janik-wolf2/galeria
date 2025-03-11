using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace galeria
{
    public partial class Form1 : Form
    {
        private OpenFileDialog ofd;
        public Form1()
        {
            InitializeComponent();
        }
        int licznik = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            licznik--;

            if (licznik < 1)
            {
                licznik = 7;
            }

            switch (licznik)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.andrzej;
                    label1.Text = "Andrzej Duda";
                    label2.Text = @"""Lorem ipsum""";
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.jp2;
                    label1.Text = "Jan pawel II";
                    label2.Text = @"""Lorem ipsum""";
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.kubica;
                    label1.Text = "Robert Kubica";
                    label2.Text = @"""szybki hehe niby szybki""";
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.lewy;
                    label1.Text = "Robert Lewandowski";
                    label2.Text = @"""Lorem ipsum""";
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.maria;
                    label1.Text = "Maria Skłodowska-Curie";
                    label2.Text = @"""Lorem ipsum""";
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.pudzian;
                    label1.Text = "Mariusz Pudzianowski";
                    label2.Text = @"""Lorem ipsum""";
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.zenek;
                    label1.Text = "Zenon Martyniuk";
                    label2.Text = @"""Przez twe oczy zielone""";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            licznik++;

            if (licznik > 7)
            {
                licznik = 1;
            }

            switch (licznik)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.andrzej;
                    label1.Text = "Andrzej Duda";
                    label2.Text = @"""Lorem ipsum""";
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.jp2;
                    label1.Text = "Jan pawel II";
                    label2.Text = @"""Lorem ipsum""";
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.kubica;
                    label1.Text = "Robert Kubica";
                    label2.Text = @"""szybki hehe niby szybki""";
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.lewy;
                    label1.Text = "Robert Lewandowski";
                    label2.Text = @"""Lorem ipsum""";
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.maria;
                    label1.Text = "Maria Skłodowska-Curie";
                    label2.Text = @"""Lorem ipsum""";
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.pudzian;
                    label1.Text = "Mariusz Pudzianowski";
                    label2.Text = @"""Lorem ipsum""";
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.zenek;
                    label1.Text = "Zenon Martyniuk";
                    label2.Text = @"""Przez twe oczy zielone""";
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                this.pictureBox1.Image = Image.FromFile(ofd.FileName);

            }
        }


 

        private void Form1_Load_1(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();

            this.pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
