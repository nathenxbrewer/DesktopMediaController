namespace Tablet_Media_Control
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.volumeSlider = new MetroFramework.Controls.MetroTrackBar();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lblVolume = new System.Windows.Forms.Label();
            this.picMute = new System.Windows.Forms.PictureBox();
            this.picPrev = new System.Windows.Forms.PictureBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // volumeSlider
            // 
            this.volumeSlider.BackColor = System.Drawing.Color.Transparent;
            this.volumeSlider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeSlider.ForeColor = System.Drawing.Color.Cornsilk;
            this.volumeSlider.Location = new System.Drawing.Point(179, 361);
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(451, 47);
            this.volumeSlider.TabIndex = 3;
            this.volumeSlider.Text = "metroTrackBar1";
            this.volumeSlider.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.volumeSlider.ValueChanged += new System.EventHandler(this.volumeSlider_ValueChanged);
            this.volumeSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar1_Scroll);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // lblVolume
            // 
            this.lblVolume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVolume.Font = new System.Drawing.Font("Segoe UI", 26.25F);
            this.lblVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.lblVolume.Location = new System.Drawing.Point(359, 413);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(80, 47);
            this.lblVolume.TabIndex = 6;
            this.lblVolume.Text = "100";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVolume.Click += new System.EventHandler(this.lblVolume_Click);
            // 
            // picMute
            // 
            this.picMute.Image = global::Tablet_Media_Control.Properties.Resources.volume_mute_solid;
            this.picMute.Location = new System.Drawing.Point(737, 430);
            this.picMute.Name = "picMute";
            this.picMute.Size = new System.Drawing.Size(40, 40);
            this.picMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMute.TabIndex = 5;
            this.picMute.TabStop = false;
            this.picMute.Click += new System.EventHandler(this.picMute_Click);
            // 
            // picPrev
            // 
            this.picPrev.Image = global::Tablet_Media_Control.Properties.Resources.step_backward_solid1;
            this.picPrev.Location = new System.Drawing.Point(76, 153);
            this.picPrev.Name = "picPrev";
            this.picPrev.Size = new System.Drawing.Size(160, 160);
            this.picPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPrev.TabIndex = 2;
            this.picPrev.TabStop = false;
            this.picPrev.Click += new System.EventHandler(this.picPrev_Click);
            // 
            // picNext
            // 
            this.picNext.Image = global::Tablet_Media_Control.Properties.Resources.step_forward_solid1;
            this.picNext.Location = new System.Drawing.Point(555, 153);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(160, 160);
            this.picNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNext.TabIndex = 1;
            this.picNext.TabStop = false;
            this.picNext.Click += new System.EventHandler(this.picNext_Click);
            // 
            // picPlay
            // 
            this.picPlay.Image = global::Tablet_Media_Control.Properties.Resources.play_circle_regular1;
            this.picPlay.Location = new System.Drawing.Point(299, 133);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(200, 200);
            this.picPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlay.TabIndex = 0;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            this.picPlay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picPlay_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.ControlBox = false;
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.picMute);
            this.Controls.Add(this.volumeSlider);
            this.Controls.Add(this.picPrev);
            this.Controls.Add(this.picNext);
            this.Controls.Add(this.picPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Mini Media Controller";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.PictureBox picPrev;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MetroFramework.Controls.MetroTrackBar volumeSlider;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.PictureBox picMute;
        private System.Windows.Forms.Label lblVolume;
    }
}

