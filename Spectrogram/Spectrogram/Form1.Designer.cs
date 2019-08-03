namespace Spectrogram
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnGo = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnDump = new System.Windows.Forms.Button();
            this.scbarVolume = new System.Windows.Forms.TrackBar();
            this.lblVolume = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scbarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "@\"C:\\\"";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(12, 12);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(102, 23);
            this.BtnSearch.TabIndex = 0;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnGo
            // 
            this.BtnGo.Location = new System.Drawing.Point(120, 12);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(102, 23);
            this.BtnGo.TabIndex = 1;
            this.BtnGo.Text = "Go";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(228, 12);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(102, 23);
            this.BtnStop.TabIndex = 2;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(120, 41);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(102, 23);
            this.BtnReset.TabIndex = 3;
            this.BtnReset.Text = "Reset Position";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnDump
            // 
            this.BtnDump.Location = new System.Drawing.Point(12, 41);
            this.BtnDump.Name = "BtnDump";
            this.BtnDump.Size = new System.Drawing.Size(102, 23);
            this.BtnDump.TabIndex = 4;
            this.BtnDump.Text = "Remove";
            this.BtnDump.UseVisualStyleBackColor = true;
            this.BtnDump.Click += new System.EventHandler(this.BtnDump_Click);
            // 
            // scbarVolume
            // 
            this.scbarVolume.Location = new System.Drawing.Point(336, 16);
            this.scbarVolume.Name = "scbarVolume";
            this.scbarVolume.Size = new System.Drawing.Size(206, 45);
            this.scbarVolume.TabIndex = 7;
            this.scbarVolume.Value = 10;
            this.scbarVolume.Scroll += new System.EventHandler(this.ScbarVolume_Scroll);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(228, 41);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(57, 13);
            this.lblVolume.TabIndex = 8;
            this.lblVolume.Text = "Volume: ...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 277);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.scbarVolume);
            this.Controls.Add(this.BtnDump);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnGo);
            this.Controls.Add(this.BtnSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.scbarVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnDump;
        private System.Windows.Forms.TrackBar scbarVolume;
        private System.Windows.Forms.Label lblVolume;
    }
}

