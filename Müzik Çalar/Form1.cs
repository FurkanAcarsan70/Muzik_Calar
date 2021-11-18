using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Müzik_Çalar
{
    public partial class MüzikÇalar : Form
    {
        OpenFileDialog Dosya = new OpenFileDialog();
        public MüzikÇalar()
        {
            InitializeComponent();
        }

        private void MüzikÇalar_Load(object sender, EventArgs e)
        {
            Dosya.Multiselect = true;
            lstMüzik.DoubleClick += LstMüzik_DoubleClick;
            wdpMüzik.settings.volume = 50;
        }

        private void LstMüzik_DoubleClick(object sender, EventArgs e)
        {
            wdpMüzik.URL = lstMüzik.SelectedItem.ToString();
            wdpMüzik.Ctlcontrols.play();
            lblŞarkıİsmi.Text = lstMüzik.SelectedItem.ToString();
        }

        private void btnListeOluştur_Click(object sender, EventArgs e)
        {
            if (Dosya.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < Dosya.FileNames.Length; i++)
                {
                    lstMüzik.Items.Add(Dosya.FileNames[i].ToString());
                }
                if (lstMüzik.Items.Count > 0)
                {
                    lstMüzik.SelectedIndex = 0;
                }
            }
        }

        private void btnListeyiTemizle_Click(object sender, EventArgs e)
        {
            lstMüzik.Items.Clear();
        }

        private void btnŞarkıyıTemizle_Click(object sender, EventArgs e)
        {
            lstMüzik.Items.RemoveAt(lstMüzik.SelectedIndex);
        }

        private void btnOynat_Click(object sender, EventArgs e)
        {
            wdpMüzik.URL = lstMüzik.SelectedItem.ToString();
            wdpMüzik.Ctlcontrols.play();
            lblŞarkıİsmi.Text = lstMüzik.SelectedItem.ToString();
        }

        private void btnDuraklat_Click(object sender, EventArgs e)
        {
            wdpMüzik.Ctlcontrols.pause();
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            wdpMüzik.Ctlcontrols.stop();
        }

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            wdpMüzik.Ctlcontrols.play();
        }

        private void btnSonrakiŞarkı_Click(object sender, EventArgs e)
        {
            lstMüzik.SelectedIndex++;
            wdpMüzik.URL = lstMüzik.SelectedItem.ToString();
            wdpMüzik.Ctlcontrols.play();
            lblŞarkıİsmi.Text = lstMüzik.SelectedItem.ToString();
        }

        private void btnÖncekiŞarkı_Click(object sender, EventArgs e)
        {
            lstMüzik.SelectedIndex--;
            wdpMüzik.URL = lstMüzik.SelectedItem.ToString();
            wdpMüzik.Ctlcontrols.play();
            lblŞarkıİsmi.Text = lstMüzik.SelectedItem.ToString();
        }

        private void btnSesArttır_Click(object sender, EventArgs e)
        {
            wdpMüzik.settings.volume += 5;
        }

        private void btnSesAzalt_Click(object sender, EventArgs e)
        {
            wdpMüzik.settings.volume -= 5;
        }

        private void btnGeriSar_Click(object sender, EventArgs e)
        {
            wdpMüzik.Ctlcontrols.fastReverse();
        }

        private void btnİleriSar_Click(object sender, EventArgs e)
        {
            wdpMüzik.Ctlcontrols.fastForward();
        }
    }
}
