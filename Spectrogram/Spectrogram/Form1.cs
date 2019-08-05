using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using WaveFormRendererLib;

namespace Spectrogram
{
    public partial class Form1 : Form
    {
        private bool closing = false;
        private string path;

        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;

        private WaveFormRenderer waveFormRenderer;
        private WaveFormRendererSettings standardSettings;

        private string imageFile;

        public Form1()
        {
            InitializeComponent();
            outputDevice = new WaveOutEvent();

            standardSettings = new StandardWaveFormRendererSettings
            {
                Name = "StandardSettings",
                TopPeakPen = new Pen(Color.DarkRed),
                BottomPeakPen = new Pen(Color.DarkViolet)
            };

            var topSpacerColor = Color.FromArgb(64, 83, 22, 3);

            var waveGraph = new SoundCloudBlockWaveFormSettings(Color.Coral,Color.Aqua, Color.Black, Color.AliceBlue)
            {
                Name = "Waves",
                PixelsPerPeak = 2,
                SpacerPixels = 1,
                TopSpacerGradientStartColor = Color.Aqua,
                BackgroundColor = Color.Transparent
            };
            

        }

        private WaveFormRendererSettings GetRendererSettings()
        {
            /*var settings = (WaveFormRendererSettings)comboBoxRenderSettings.SelectedItem;
            settings.TopHeight = (int)upDownTopHeight.Value;
            settings.BottomHeight = (int)upDownBottomHeight.Value;
            settings.Width = (int)upDownWidth.Value;
            settings.DecibelScale = checkBoxDecibels.Checked;
            return settings;*/

            var renderSettings = (WaveFormRendererSettings) standardSettings;
            renderSettings.TopHeight = 100;
            renderSettings.BottomHeight = 100;
            renderSettings.Width = 500;
            renderSettings.DecibelScale = false;
            return renderSettings;
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

        private void BtnRender_Click(object sender, EventArgs e)
        {
            imageFile = path;
            RenderWaveForm();
        }

        private void RenderWaveForm()
        {
            var settings = GetRendererSettings();

            if (imageFile != null)
            {
                settings.BackgroundImage = new Bitmap(imageFile);
            }
            PctbxWave.Image = null;
            var peakProvider = new MaxPeakProvider();
            Task.Factory.StartNew(() => RenderThread(peakProvider, settings));
        }

        private void RenderThread(IPeakProvider peak, WaveFormRendererSettings settings)
        {
            Image image = null;
            try
            {
                image = waveFormRenderer.Render(path, peak, settings);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            BeginInvoke((Action) (() => PctbxWave.Image = image));
        }

        /*private void RenderWaveform()
        {
            if (selectedFile == null) return;
            var settings = GetRendererSettings();
            if (imageFile != null)
            {
                settings.BackgroundImage = new Bitmap(imageFile);
            }
            pictureBox1.Image = null;
            labelRendering.Visible = true;
            Enabled = false;
            var peakProvider = GetPeakProvider();
            Task.Factory.StartNew(() => RenderThreadFunc(peakProvider, settings));
        }

        private void RenderThreadFunc(IPeakProvider peakProvider, WaveFormRendererSettings settings)
        {
            Image image = null;
            try
            {
                image = waveFormRenderer.Render(selectedFile, peakProvider, settings);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            BeginInvoke((Action)(() => FinishedRender(image)));
        }

        private void FinishedRender(Image image)
        {
            labelRendering.Visible = false;
            pictureBox1.Image = image;
            Enabled = true;
        }*/
    }
}
