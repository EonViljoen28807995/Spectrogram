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
using NAudio.Wave;

namespace Spectrogram
{
    public partial class Form1 : Form
    {
        private string path;
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;

        public Form1()
        {
            InitializeComponent();
            outputDevice = new WaveOutEvent();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            path = openFileDialog1.FileName;
            audioFile = new AudioFileReader(path);
            outputDevice.Init(audioFile);
            
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            outputDevice.Play();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
        }
    }
}
