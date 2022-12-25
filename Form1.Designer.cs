namespace Color_Picker
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.lblHEX = new System.Windows.Forms.Label();
            this.lblRGB = new System.Windows.Forms.Label();
            this.txtHEX = new System.Windows.Forms.TextBox();
            this.txtRGB = new System.Windows.Forms.TextBox();
            this.btnColorPic = new System.Windows.Forms.Button();
            this.btnCopyHEX = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picTop = new System.Windows.Forms.PictureBox();
            this.btnCopyRGB = new System.Windows.Forms.Button();
            this.tltMain = new System.Windows.Forms.ToolTip(this.components);
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnMaximize);
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Controls.Add(this.lblHeader);
            this.pnlTop.Controls.Add(this.picTop);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(584, 42);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Andalus", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Yellow;
            this.lblHeader.Location = new System.Drawing.Point(215, 4);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(154, 38);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Color Picker";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 42);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(584, 236);
            this.pnlMain.TabIndex = 1;
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRed.Font = new System.Drawing.Font("Andalus", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.Location = new System.Drawing.Point(12, 282);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(48, 30);
            this.lblRed.TabIndex = 0;
            this.lblRed.Text = "RED";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGreen.Font = new System.Drawing.Font("Andalus", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.ForeColor = System.Drawing.Color.Green;
            this.lblGreen.Location = new System.Drawing.Point(12, 340);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(72, 30);
            this.lblGreen.TabIndex = 2;
            this.lblGreen.Text = "GREEN";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBlue.Font = new System.Drawing.Font("Andalus", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.ForeColor = System.Drawing.Color.Blue;
            this.lblBlue.Location = new System.Drawing.Point(12, 391);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(58, 30);
            this.lblBlue.TabIndex = 3;
            this.lblBlue.Text = "BLUE";
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(92, 285);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(178, 45);
            this.trackBarRed.TabIndex = 4;
            this.trackBarRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRed.ValueChanged += new System.EventHandler(this.trackBarRed_ValueChanged);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(92, 340);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(178, 45);
            this.trackBarGreen.TabIndex = 5;
            this.trackBarGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGreen.ValueChanged += new System.EventHandler(this.trackBarGreen_ValueChanged);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(92, 391);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(178, 45);
            this.trackBarBlue.TabIndex = 6;
            this.trackBarBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBlue.ValueChanged += new System.EventHandler(this.trackBarBlue_ValueChanged);
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(296, 293);
            this.txtRed.Name = "txtRed";
            this.txtRed.ReadOnly = true;
            this.txtRed.Size = new System.Drawing.Size(53, 20);
            this.txtRed.TabIndex = 7;
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(296, 340);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.ReadOnly = true;
            this.txtGreen.Size = new System.Drawing.Size(53, 20);
            this.txtGreen.TabIndex = 8;
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(296, 391);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.ReadOnly = true;
            this.txtBlue.Size = new System.Drawing.Size(53, 20);
            this.txtBlue.TabIndex = 9;
            // 
            // lblHEX
            // 
            this.lblHEX.AutoSize = true;
            this.lblHEX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHEX.Font = new System.Drawing.Font("Andalus", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHEX.ForeColor = System.Drawing.Color.Black;
            this.lblHEX.Location = new System.Drawing.Point(386, 285);
            this.lblHEX.Name = "lblHEX";
            this.lblHEX.Size = new System.Drawing.Size(49, 30);
            this.lblHEX.TabIndex = 10;
            this.lblHEX.Text = "HEX";
            // 
            // lblRGB
            // 
            this.lblRGB.AutoSize = true;
            this.lblRGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRGB.Font = new System.Drawing.Font("Andalus", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRGB.ForeColor = System.Drawing.Color.Black;
            this.lblRGB.Location = new System.Drawing.Point(386, 341);
            this.lblRGB.Name = "lblRGB";
            this.lblRGB.Size = new System.Drawing.Size(49, 30);
            this.lblRGB.TabIndex = 11;
            this.lblRGB.Text = "RGB";
            // 
            // txtHEX
            // 
            this.txtHEX.Location = new System.Drawing.Point(458, 293);
            this.txtHEX.Name = "txtHEX";
            this.txtHEX.ReadOnly = true;
            this.txtHEX.Size = new System.Drawing.Size(73, 20);
            this.txtHEX.TabIndex = 12;
            // 
            // txtRGB
            // 
            this.txtRGB.Location = new System.Drawing.Point(458, 349);
            this.txtRGB.Name = "txtRGB";
            this.txtRGB.ReadOnly = true;
            this.txtRGB.Size = new System.Drawing.Size(73, 20);
            this.txtRGB.TabIndex = 13;
            // 
            // btnColorPic
            // 
            this.btnColorPic.BackColor = System.Drawing.Color.Yellow;
            this.btnColorPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnColorPic.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnColorPic.FlatAppearance.BorderSize = 2;
            this.btnColorPic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnColorPic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnColorPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorPic.Font = new System.Drawing.Font("Andalus", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorPic.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnColorPic.Location = new System.Drawing.Point(391, 398);
            this.btnColorPic.Name = "btnColorPic";
            this.btnColorPic.Size = new System.Drawing.Size(156, 38);
            this.btnColorPic.TabIndex = 14;
            this.btnColorPic.Text = "COLOR PICK";
            this.tltMain.SetToolTip(this.btnColorPic, "Click For Pick Color ");
            this.btnColorPic.UseVisualStyleBackColor = false;
            this.btnColorPic.Click += new System.EventHandler(this.btnColorPic_Click);
            // 
            // btnCopyHEX
            // 
            this.btnCopyHEX.BackgroundImage = global::Color_Picker.Properties.Resources.CopyIcon;
            this.btnCopyHEX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopyHEX.Location = new System.Drawing.Point(537, 286);
            this.btnCopyHEX.Name = "btnCopyHEX";
            this.btnCopyHEX.Size = new System.Drawing.Size(35, 33);
            this.btnCopyHEX.TabIndex = 15;
            this.btnCopyHEX.UseVisualStyleBackColor = true;
            this.btnCopyHEX.Click += new System.EventHandler(this.btnCopyHEX_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackgroundImage = global::Color_Picker.Properties.Resources.minimize;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(505, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(26, 27);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackgroundImage = global::Color_Picker.Properties.Resources.maximize;
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(532, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(26, 27);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackgroundImage = global::Color_Picker.Properties.Resources.Exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(558, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 27);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picTop
            // 
            this.picTop.Dock = System.Windows.Forms.DockStyle.Left;
            this.picTop.Image = global::Color_Picker.Properties.Resources.pngwing_com;
            this.picTop.Location = new System.Drawing.Point(0, 0);
            this.picTop.Name = "picTop";
            this.picTop.Size = new System.Drawing.Size(68, 42);
            this.picTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTop.TabIndex = 0;
            this.picTop.TabStop = false;
            // 
            // btnCopyRGB
            // 
            this.btnCopyRGB.BackgroundImage = global::Color_Picker.Properties.Resources.CopyIcon;
            this.btnCopyRGB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopyRGB.Location = new System.Drawing.Point(537, 342);
            this.btnCopyRGB.Name = "btnCopyRGB";
            this.btnCopyRGB.Size = new System.Drawing.Size(35, 33);
            this.btnCopyRGB.TabIndex = 16;
            this.btnCopyRGB.UseVisualStyleBackColor = true;
            this.btnCopyRGB.Click += new System.EventHandler(this.btnCopyRGB_Click);
            // 
            // tltMain
            // 
            this.tltMain.AutomaticDelay = 200;
            this.tltMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btnCopyRGB);
            this.Controls.Add(this.btnCopyHEX);
            this.Controls.Add(this.btnColorPic);
            this.Controls.Add(this.txtRGB);
            this.Controls.Add(this.txtHEX);
            this.Controls.Add(this.lblRGB);
            this.Controls.Add(this.lblHEX);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox picTop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.Label lblHEX;
        private System.Windows.Forms.Label lblRGB;
        private System.Windows.Forms.TextBox txtHEX;
        private System.Windows.Forms.TextBox txtRGB;
        private System.Windows.Forms.Button btnColorPic;
        private System.Windows.Forms.Button btnCopyHEX;
        private System.Windows.Forms.Button btnCopyRGB;
        private System.Windows.Forms.ToolTip tltMain;
    }
}

