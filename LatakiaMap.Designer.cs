namespace maps_sy
{
    partial class LatakiaMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LatakiaMap));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.closeb = new System.Windows.Forms.PictureBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TrackBar1 = new System.Windows.Forms.TrackBar();
            this.deg_label = new System.Windows.Forms.Label();
            this.mapviewer = new System.Windows.Forms.PictureBox();
            this.mapselect = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.help = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipMS = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.homeb = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeb)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapviewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.button2);
            this.Panel1.Controls.Add(this.button1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel1.Location = new System.Drawing.Point(1148, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(144, 780);
            this.Panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(79, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 37);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(28, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 37);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LinkLabel1.Location = new System.Drawing.Point(1040, 668);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(64, 13);
            this.LinkLabel1.TabIndex = 4;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "اخفاء القائمة";
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // closeb
            // 
            this.closeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeb.Image = ((System.Drawing.Image)(resources.GetObject("closeb.Image")));
            this.closeb.Location = new System.Drawing.Point(1110, 701);
            this.closeb.Name = "closeb";
            this.closeb.Size = new System.Drawing.Size(35, 35);
            this.closeb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeb.TabIndex = 1;
            this.closeb.TabStop = false;
            this.closeb.Click += new System.EventHandler(this.closeb_Click);
            this.closeb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.closeb_MouseDown);
            this.closeb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.closeb_MouseUp);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.pictureBox2);
            this.Panel2.Controls.Add(this.label1);
            this.Panel2.Controls.Add(this.LinkLabel1);
            this.Panel2.Controls.Add(this.closeb);
            this.Panel2.Controls.Add(this.TextBox1);
            this.Panel2.Controls.Add(this.TrackBar1);
            this.Panel2.Controls.Add(this.deg_label);
            this.Panel2.Controls.Add(this.mapviewer);
            this.Panel2.Controls.Add(this.homeb);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1148, 780);
            this.Panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1110, 646);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Location = new System.Drawing.Point(1069, 723);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "إغلاق";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.ForeColor = System.Drawing.Color.Black;
            this.TextBox1.Location = new System.Drawing.Point(42, 132);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.Size = new System.Drawing.Size(45, 20);
            this.TextBox1.TabIndex = 3;
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TrackBar1
            // 
            this.TrackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TrackBar1.LargeChange = 1;
            this.TrackBar1.Location = new System.Drawing.Point(42, 22);
            this.TrackBar1.Minimum = 8;
            this.TrackBar1.Name = "TrackBar1";
            this.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBar1.Size = new System.Drawing.Size(45, 104);
            this.TrackBar1.TabIndex = 2;
            this.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TrackBar1.Value = 8;
            this.TrackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // deg_label
            // 
            this.deg_label.AutoSize = true;
            this.deg_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deg_label.Location = new System.Drawing.Point(276, 9);
            this.deg_label.Name = "deg_label";
            this.deg_label.Size = new System.Drawing.Size(38, 13);
            this.deg_label.TabIndex = 1;
            this.deg_label.Text = "Label1";
            this.deg_label.Click += new System.EventHandler(this.deg_label_Click);
            // 
            // mapviewer
            // 
            this.mapviewer.Location = new System.Drawing.Point(386, 29);
            this.mapviewer.Name = "mapviewer";
            this.mapviewer.Size = new System.Drawing.Size(358, 223);
            this.mapviewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapviewer.TabIndex = 0;
            this.mapviewer.TabStop = false;
            this.mapviewer.Click += new System.EventHandler(this.mapviewer_Click);
            this.mapviewer.DoubleClick += new System.EventHandler(this.mapviewer_DoubleClick);
            this.mapviewer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapviewer_MouseDown);
            this.mapviewer.MouseLeave += new System.EventHandler(this.mapviewer_MouseLeave);
            this.mapviewer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mapviewer_MouseMove);
            this.mapviewer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mapviewer_MouseUp);
            this.mapviewer.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.mapviewer_MouseWheel);
            this.mapviewer.Move += new System.EventHandler(this.mapviewer_Move);
            this.mapviewer.Resize += new System.EventHandler(this.mapviewer_Resize);
            // 
            // mapselect
            // 
            this.mapselect.Interval = 1;
            this.mapselect.Tick += new System.EventHandler(this.mapselect_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureBox1.Location = new System.Drawing.Point(7, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // homeb
            // 
            this.homeb.Image = ((System.Drawing.Image)(resources.GetObject("homeb.Image")));
            this.homeb.Location = new System.Drawing.Point(666, 194);
            this.homeb.Name = "homeb";
            this.homeb.Size = new System.Drawing.Size(37, 37);
            this.homeb.TabIndex = 6;
            this.homeb.UseVisualStyleBackColor = true;
            this.homeb.Visible = false;
            // 
            // LatakiaMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1292, 780);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LatakiaMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeb)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapviewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.TrackBar TrackBar1;
        internal System.Windows.Forms.Label deg_label;
        internal System.Windows.Forms.PictureBox mapviewer;
        private System.Windows.Forms.Timer mapselect;
        //private firstDataSet firstDataSet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip help;
        //private estateDataSet estateDataSet;
        private System.Windows.Forms.ToolTip ToolTipMS;
        internal System.Windows.Forms.LinkLabel LinkLabel1;
        internal System.Windows.Forms.PictureBox closeb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button homeb;
    }
}

