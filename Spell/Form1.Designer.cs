namespace Spell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtfAnswer = new System.Windows.Forms.RichTextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.chkRaagTaal = new System.Windows.Forms.CheckBox();
            this.chkAudio = new System.Windows.Forms.CheckBox();
            this.chkVideo = new System.Windows.Forms.CheckBox();
            this.chkSwaralipi = new System.Windows.Forms.CheckBox();
            this.chkEnglish = new System.Windows.Forms.CheckBox();
            this.btnResetRaag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtfAnswer
            // 
            this.rtfAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfAnswer.Font = new System.Drawing.Font("SolaimanLipi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfAnswer.Location = new System.Drawing.Point(0, 0);
            this.rtfAnswer.Name = "rtfAnswer";
            this.rtfAnswer.Size = new System.Drawing.Size(653, 432);
            this.rtfAnswer.TabIndex = 4;
            this.rtfAnswer.Text = "";
            // 
            // btnClean
            // 
            this.btnClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClean.Location = new System.Drawing.Point(546, 438);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(95, 34);
            this.btnClean.TabIndex = 5;
            this.btnClean.Text = "Clean Text";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // chkRaagTaal
            // 
            this.chkRaagTaal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkRaagTaal.AutoSize = true;
            this.chkRaagTaal.Checked = true;
            this.chkRaagTaal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRaagTaal.Location = new System.Drawing.Point(8, 448);
            this.chkRaagTaal.Name = "chkRaagTaal";
            this.chkRaagTaal.Size = new System.Drawing.Size(98, 17);
            this.chkRaagTaal.TabIndex = 6;
            this.chkRaagTaal.Text = "Raag And Taal";
            this.chkRaagTaal.UseVisualStyleBackColor = true;
            this.chkRaagTaal.CheckedChanged += new System.EventHandler(this.chkRaagTaal_CheckedChanged);
            // 
            // chkAudio
            // 
            this.chkAudio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAudio.AutoSize = true;
            this.chkAudio.Location = new System.Drawing.Point(107, 448);
            this.chkAudio.Name = "chkAudio";
            this.chkAudio.Size = new System.Drawing.Size(53, 17);
            this.chkAudio.TabIndex = 7;
            this.chkAudio.Text = "Audio";
            this.chkAudio.UseVisualStyleBackColor = true;
            this.chkAudio.CheckedChanged += new System.EventHandler(this.chkAudio_CheckedChanged);
            // 
            // chkVideo
            // 
            this.chkVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkVideo.AutoSize = true;
            this.chkVideo.Location = new System.Drawing.Point(161, 448);
            this.chkVideo.Name = "chkVideo";
            this.chkVideo.Size = new System.Drawing.Size(53, 17);
            this.chkVideo.TabIndex = 8;
            this.chkVideo.Text = "Video";
            this.chkVideo.UseVisualStyleBackColor = true;
            this.chkVideo.CheckedChanged += new System.EventHandler(this.chkVideo_CheckedChanged);
            // 
            // chkSwaralipi
            // 
            this.chkSwaralipi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSwaralipi.AutoSize = true;
            this.chkSwaralipi.Location = new System.Drawing.Point(215, 448);
            this.chkSwaralipi.Name = "chkSwaralipi";
            this.chkSwaralipi.Size = new System.Drawing.Size(68, 17);
            this.chkSwaralipi.TabIndex = 9;
            this.chkSwaralipi.Text = "Swaralipi";
            this.chkSwaralipi.UseVisualStyleBackColor = true;
            this.chkSwaralipi.CheckedChanged += new System.EventHandler(this.chkSwaralipi_CheckedChanged);
            // 
            // chkEnglish
            // 
            this.chkEnglish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkEnglish.AutoSize = true;
            this.chkEnglish.Location = new System.Drawing.Point(284, 448);
            this.chkEnglish.Name = "chkEnglish";
            this.chkEnglish.Size = new System.Drawing.Size(60, 17);
            this.chkEnglish.TabIndex = 10;
            this.chkEnglish.Text = "English";
            this.chkEnglish.UseVisualStyleBackColor = true;
            this.chkEnglish.CheckedChanged += new System.EventHandler(this.chkEnglish_CheckedChanged);
            // 
            // btnResetRaag
            // 
            this.btnResetRaag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResetRaag.Location = new System.Drawing.Point(349, 438);
            this.btnResetRaag.Name = "btnResetRaag";
            this.btnResetRaag.Size = new System.Drawing.Size(121, 34);
            this.btnResetRaag.TabIndex = 5;
            this.btnResetRaag.Text = "Reset Raag And Taal";
            this.btnResetRaag.UseVisualStyleBackColor = true;
            this.btnResetRaag.Click += new System.EventHandler(this.btnResetRaag_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 477);
            this.Controls.Add(this.chkEnglish);
            this.Controls.Add(this.chkSwaralipi);
            this.Controls.Add(this.chkVideo);
            this.Controls.Add(this.chkAudio);
            this.Controls.Add(this.chkRaagTaal);
            this.Controls.Add(this.btnResetRaag);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.rtfAnswer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clean Pad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfAnswer;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.CheckBox chkRaagTaal;
        private System.Windows.Forms.CheckBox chkAudio;
        private System.Windows.Forms.CheckBox chkVideo;
        private System.Windows.Forms.CheckBox chkSwaralipi;
        private System.Windows.Forms.CheckBox chkEnglish;
        private System.Windows.Forms.Button btnResetRaag;
    }
}

