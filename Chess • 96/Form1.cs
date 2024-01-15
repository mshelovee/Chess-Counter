using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess___96
{
    public partial class Form1 : Form
    {
        int sayacBeyaz = 10;
        int sayacSiyah = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {

            timerBeyaz.Start();
            this.BackColor = Color.White;
        }

        private void btnBeyaz_Click(object sender, EventArgs e)
        {
            timerBeyaz.Stop();

            timerSiyah.Start();
            this.BackColor = Color.Black;
            this.lblBeyaz.ForeColor = Color.White;
            this.lblSiyah.ForeColor = Color.White;
        }


        private void timerBeyaz_Tick(object sender, EventArgs e)
        {
            sayacBeyaz--;
            lblBeyaz.Text = sayacBeyaz.ToString();

            if (sayacBeyaz <= 0)
            {
                timerBeyaz.Stop();
                this.BackColor = Color.White;
                lblMesaj.Text = "SİYAH KAZANDI";
            }

        }

        private void timerSiyah_Tick(object sender, EventArgs e)
        {
            sayacSiyah--;
            lblSiyah.Text = sayacSiyah.ToString();

            if (sayacSiyah <= 0)
            {
                timerSiyah.Stop();
                this.BackColor = Color.Black;
                lblMesaj.Text = "BEYAZ KAZANDI";
            }
        }

        private void btnSİyah_Click(object sender, EventArgs e)
        {
            timerSiyah.Stop();

            timerBeyaz.Start();
            this.BackColor = Color.White;
            this.lblBeyaz.ForeColor = Color.Black;
            this.lblSiyah.ForeColor = Color.Black;

        }
    }

}
