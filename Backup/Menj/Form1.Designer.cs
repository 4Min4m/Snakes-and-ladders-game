namespace Menj
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
            this.btn_tass1 = new System.Windows.Forms.Button();
            this.lbl_tass1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer_nobat = new System.Windows.Forms.Timer(this.components);
            this.pic_nobat = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_tass2 = new System.Windows.Forms.Button();
            this.lbl_tass2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_tass3 = new System.Windows.Forms.Button();
            this.lbl_tass3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_tass4 = new System.Windows.Forms.Button();
            this.lbl_tass4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.board1 = new Menj.Board();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nobat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_tass1
            // 
            this.btn_tass1.Location = new System.Drawing.Point(15, 51);
            this.btn_tass1.Name = "btn_tass1";
            this.btn_tass1.Size = new System.Drawing.Size(107, 23);
            this.btn_tass1.TabIndex = 3;
            this.btn_tass1.Text = "پرتاب تاس";
            this.btn_tass1.UseVisualStyleBackColor = true;
            this.btn_tass1.Click += new System.EventHandler(this.btn_tass_Click);
            // 
            // lbl_tass1
            // 
            this.lbl_tass1.AutoSize = true;
            this.lbl_tass1.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_tass1.Location = new System.Drawing.Point(58, 74);
            this.lbl_tass1.Name = "lbl_tass1";
            this.lbl_tass1.Size = new System.Drawing.Size(0, 29);
            this.lbl_tass1.TabIndex = 6;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "mohre-blue copy.jpg");
            this.imageList1.Images.SetKeyName(1, "mohre-red copy.jpg");
            this.imageList1.Images.SetKeyName(2, "mohre-Green copy.jpg");
            this.imageList1.Images.SetKeyName(3, "mohre-yellow copy.jpg");
            // 
            // timer_nobat
            // 
            this.timer_nobat.Tick += new System.EventHandler(this.timer_nobat_Tick);
            // 
            // pic_nobat
            // 
            this.pic_nobat.Image = ((System.Drawing.Image)(resources.GetObject("pic_nobat.Image")));
            this.pic_nobat.Location = new System.Drawing.Point(44, -1);
            this.pic_nobat.Name = "pic_nobat";
            this.pic_nobat.Size = new System.Drawing.Size(48, 48);
            this.pic_nobat.TabIndex = 8;
            this.pic_nobat.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 22);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "تعداد بازیکنان :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(553, 20);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pic_nobat);
            this.panel1.Controls.Add(this.btn_tass1);
            this.panel1.Controls.Add(this.lbl_tass1);
            this.panel1.Location = new System.Drawing.Point(537, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 107);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btn_tass2);
            this.panel2.Controls.Add(this.lbl_tass2);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(537, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 107);
            this.panel2.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_tass2
            // 
            this.btn_tass2.Location = new System.Drawing.Point(15, 51);
            this.btn_tass2.Name = "btn_tass2";
            this.btn_tass2.Size = new System.Drawing.Size(107, 23);
            this.btn_tass2.TabIndex = 3;
            this.btn_tass2.Text = "پرتاب تاس";
            this.btn_tass2.UseVisualStyleBackColor = true;
            this.btn_tass2.Click += new System.EventHandler(this.btn_tass2_Click);
            // 
            // lbl_tass2
            // 
            this.lbl_tass2.AutoSize = true;
            this.lbl_tass2.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_tass2.Location = new System.Drawing.Point(58, 74);
            this.lbl_tass2.Name = "lbl_tass2";
            this.lbl_tass2.Size = new System.Drawing.Size(0, 29);
            this.lbl_tass2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.btn_tass3);
            this.panel3.Controls.Add(this.lbl_tass3);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(537, 276);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 107);
            this.panel3.TabIndex = 13;
            this.panel3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(44, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btn_tass3
            // 
            this.btn_tass3.Location = new System.Drawing.Point(15, 51);
            this.btn_tass3.Name = "btn_tass3";
            this.btn_tass3.Size = new System.Drawing.Size(107, 23);
            this.btn_tass3.TabIndex = 3;
            this.btn_tass3.Text = "پرتاب تاس";
            this.btn_tass3.UseVisualStyleBackColor = true;
            this.btn_tass3.Click += new System.EventHandler(this.btn_tass3_Click);
            // 
            // lbl_tass3
            // 
            this.lbl_tass3.AutoSize = true;
            this.lbl_tass3.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_tass3.Location = new System.Drawing.Point(58, 74);
            this.lbl_tass3.Name = "lbl_tass3";
            this.lbl_tass3.Size = new System.Drawing.Size(0, 29);
            this.lbl_tass3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.btn_tass4);
            this.panel4.Controls.Add(this.lbl_tass4);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(540, 389);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(141, 107);
            this.panel4.TabIndex = 14;
            this.panel4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(44, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // btn_tass4
            // 
            this.btn_tass4.Location = new System.Drawing.Point(15, 51);
            this.btn_tass4.Name = "btn_tass4";
            this.btn_tass4.Size = new System.Drawing.Size(107, 23);
            this.btn_tass4.TabIndex = 3;
            this.btn_tass4.Text = "پرتاب تاس";
            this.btn_tass4.UseVisualStyleBackColor = true;
            this.btn_tass4.Click += new System.EventHandler(this.btn_tass4_Click);
            // 
            // lbl_tass4
            // 
            this.lbl_tass4.AutoSize = true;
            this.lbl_tass4.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_tass4.Location = new System.Drawing.Point(58, 74);
            this.lbl_tass4.Name = "lbl_tass4";
            this.lbl_tass4.Size = new System.Drawing.Size(0, 29);
            this.lbl_tass4.TabIndex = 6;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(30, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "1";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Location = new System.Drawing.Point(12, 514);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(92, 58);
            this.panel5.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.pictureBox5);
            this.panel6.Location = new System.Drawing.Point(110, 514);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(92, 58);
            this.panel6.TabIndex = 18;
            this.panel6.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "2";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(30, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 48);
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.pictureBox6);
            this.panel7.Location = new System.Drawing.Point(208, 514);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(92, 58);
            this.panel7.TabIndex = 19;
            this.panel7.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "3";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Location = new System.Drawing.Point(30, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 48);
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // board1
            // 
            this.board1.BackgroundImage = global::Menj.Properties.Resources.back_copy;
            this.board1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.board1.Delay = 700;
            this.board1.Location = new System.Drawing.Point(12, 12);
            this.board1.Name = "board1";
            this.board1.NardebanMusicFile = "nardeban.wav";
            this.board1.Size = new System.Drawing.Size(500, 500);
            this.board1.SnakeMusicFile = "snake.wav";
            this.board1.TabIndex = 0;
            this.board1.WinnerMusicFile = "winner.wav";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 577);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.board1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Menj - Designed By Mahdi Ghorbanpour";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_nobat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Board board1;
        private System.Windows.Forms.Button btn_tass1;
        private System.Windows.Forms.Label lbl_tass1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pic_nobat;
        private System.Windows.Forms.Timer timer_nobat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_tass2;
        private System.Windows.Forms.Label lbl_tass2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_tass3;
        private System.Windows.Forms.Label lbl_tass3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_tass4;
        private System.Windows.Forms.Label lbl_tass4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

