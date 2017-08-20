namespace Main_Template
{
    partial class EmguCv
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
            this.components = new System.ComponentModel.Container();
            this.IbOriginal = new Emgu.CV.UI.ImageBox();
            this.IbProcessed = new Emgu.CV.UI.ImageBox();
            this.btnPauseOrResume = new MetroFramework.Controls.MetroButton();
            this.txtXYRadius = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.IbOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IbProcessed)).BeginInit();
            this.SuspendLayout();
            // 
            // IbOriginal
            // 
            this.IbOriginal.Location = new System.Drawing.Point(23, 63);
            this.IbOriginal.Name = "IbOriginal";
            this.IbOriginal.Size = new System.Drawing.Size(416, 281);
            this.IbOriginal.TabIndex = 2;
            this.IbOriginal.TabStop = false;
            // 
            // IbProcessed
            // 
            this.IbProcessed.Location = new System.Drawing.Point(499, 63);
            this.IbProcessed.Name = "IbProcessed";
            this.IbProcessed.Size = new System.Drawing.Size(400, 281);
            this.IbProcessed.TabIndex = 2;
            this.IbProcessed.TabStop = false;
            // 
            // btnPauseOrResume
            // 
            this.btnPauseOrResume.Location = new System.Drawing.Point(136, 406);
            this.btnPauseOrResume.Name = "btnPauseOrResume";
            this.btnPauseOrResume.Size = new System.Drawing.Size(189, 51);
            this.btnPauseOrResume.TabIndex = 3;
            this.btnPauseOrResume.Text = "Pause";
            this.btnPauseOrResume.UseSelectable = true;
            // 
            // txtXYRadius
            // 
            // 
            // 
            // 
            this.txtXYRadius.CustomButton.Image = null;
            this.txtXYRadius.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.txtXYRadius.CustomButton.Name = "";
            this.txtXYRadius.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtXYRadius.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtXYRadius.CustomButton.TabIndex = 1;
            this.txtXYRadius.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtXYRadius.CustomButton.UseSelectable = true;
            this.txtXYRadius.CustomButton.Visible = false;
            this.txtXYRadius.Lines = new string[0];
            this.txtXYRadius.Location = new System.Drawing.Point(396, 361);
            this.txtXYRadius.MaxLength = 32767;
            this.txtXYRadius.Multiline = true;
            this.txtXYRadius.Name = "txtXYRadius";
            this.txtXYRadius.PasswordChar = '\0';
            this.txtXYRadius.ReadOnly = true;
            this.txtXYRadius.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtXYRadius.SelectedText = "";
            this.txtXYRadius.SelectionLength = 0;
            this.txtXYRadius.SelectionStart = 0;
            this.txtXYRadius.ShortcutsEnabled = true;
            this.txtXYRadius.Size = new System.Drawing.Size(456, 96);
            this.txtXYRadius.TabIndex = 4;
            this.txtXYRadius.UseSelectable = true;
            this.txtXYRadius.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtXYRadius.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EmguCv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 474);
            this.Controls.Add(this.txtXYRadius);
            this.Controls.Add(this.btnPauseOrResume);
            this.Controls.Add(this.IbProcessed);
            this.Controls.Add(this.IbOriginal);
            this.Name = "EmguCv";
            this.Text = "EMGU CV";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IbOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IbProcessed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox IbOriginal;
        private Emgu.CV.UI.ImageBox IbProcessed;
        private MetroFramework.Controls.MetroButton btnPauseOrResume;
        private MetroFramework.Controls.MetroTextBox txtXYRadius;
    }
}

