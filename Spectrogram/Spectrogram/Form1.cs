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
        private bool closing = false;
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
            lblVolume.Text = "Volume: " + (audioFile.Volume*10).ToString();

            
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            audioFile.Position = 0;
        }

        private void BtnDump_Click(object sender, EventArgs e)
        {
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            closing = true;
            CloseAudio();
        }

        private void CloseAudio()
        {
            if(closing)
            {
                outputDevice.Dispose();
                audioFile.Dispose();
            }
        }

        private void ScbarVolume_Scroll(object sender, EventArgs e)
        {
            audioFile.Volume = scbarVolume.Value / 10f;
            lblVolume.Text = "Volume: " + (scbarVolume.Value*10).ToString();
        }

        
    }
}
