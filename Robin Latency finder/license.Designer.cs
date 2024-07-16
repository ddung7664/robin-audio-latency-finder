namespace Robin_Latency_finder
{
    partial class license
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(license));
            this.tb_license = new System.Windows.Forms.RichTextBox();
            this.lb_robin = new System.Windows.Forms.Label();
            this.lb_audio = new System.Windows.Forms.Label();
            this.lb_font = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_license
            // 
            this.tb_license.Font = new System.Drawing.Font("넥슨Lv1고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_license.Location = new System.Drawing.Point(33, 58);
            this.tb_license.Name = "tb_license";
            this.tb_license.ReadOnly = true;
            this.tb_license.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tb_license.Size = new System.Drawing.Size(300, 361);
            this.tb_license.TabIndex = 0;
            this.tb_license.Text = "";
            // 
            // lb_robin
            // 
            this.lb_robin.AutoSize = true;
            this.lb_robin.Font = new System.Drawing.Font("넥슨Lv1고딕 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_robin.Location = new System.Drawing.Point(41, 22);
            this.lb_robin.Name = "lb_robin";
            this.lb_robin.Size = new System.Drawing.Size(54, 18);
            this.lb_robin.TabIndex = 1;
            this.lb_robin.Text = "Robin";
            this.lb_robin.Click += new System.EventHandler(this.lb_robin_Click);
            // 
            // lb_audio
            // 
            this.lb_audio.AutoSize = true;
            this.lb_audio.Font = new System.Drawing.Font("넥슨Lv1고딕 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_audio.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_audio.Location = new System.Drawing.Point(154, 22);
            this.lb_audio.Name = "lb_audio";
            this.lb_audio.Size = new System.Drawing.Size(66, 18);
            this.lb_audio.TabIndex = 2;
            this.lb_audio.Text = "NAudio";
            this.lb_audio.Click += new System.EventHandler(this.lb_audio_Click);
            // 
            // lb_font
            // 
            this.lb_font.AutoSize = true;
            this.lb_font.Font = new System.Drawing.Font("넥슨Lv1고딕 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_font.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_font.Location = new System.Drawing.Point(282, 22);
            this.lb_font.Name = "lb_font";
            this.lb_font.Size = new System.Drawing.Size(51, 18);
            this.lb_font.TabIndex = 3;
            this.lb_font.Text = "Fonts";
            this.lb_font.Click += new System.EventHandler(this.lb_font_Click);
            // 
            // license
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.lb_font);
            this.Controls.Add(this.lb_audio);
            this.Controls.Add(this.lb_robin);
            this.Controls.Add(this.tb_license);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "license";
            this.Text = "Robin Audio Latency finder 0.43.0";
            this.Load += new System.EventHandler(this.license_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tb_license;
        private System.Windows.Forms.Label lb_robin;
        private System.Windows.Forms.Label lb_audio;
        private System.Windows.Forms.Label lb_font;
    }
}