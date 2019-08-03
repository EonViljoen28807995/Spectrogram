using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Spectrogram
{
    public partial class Form1 : Form
    {
        private string path = "";
        private SoundPlayer sound;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            path = openFileDialog1.FileName;
            LblTest.Text = path;

            sound = new SoundPlayer(path);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            sound.Play();
        }
    }
}
