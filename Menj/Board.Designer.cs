namespace Menj
{
    partial class Board
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Mohreh_green = new System.Windows.Forms.PictureBox();
            this.Mohreh_Blue = new System.Windows.Forms.PictureBox();
            this.Mohreh_Yellow = new System.Windows.Forms.PictureBox();
            this.timer_visible = new System.Windows.Forms.Timer(this.components);
            this.timer_invisible = new System.Windows.Forms.Timer(this.components);
            this.timer_suddenMove = new System.Windows.Forms.Timer(this.components);
            this.Mohreh_Red = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Mohreh_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mohreh_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mohreh_Yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mohreh_Red)).BeginInit();
            this.SuspendLayout();
            // 
            // Mohreh_green
            // 
            this.Mohreh_green.BackColor = System.Drawing.Color.Transparent;
            this.Mohreh_green.Image = global::Menj.Properties.Resources.mohre_Green_copy;
            this.Mohreh_green.Location = new System.Drawing.Point(10, 155);
            this.Mohreh_green.Name = "Mohreh_green";
            this.Mohreh_green.Size = new System.Drawing.Size(48, 48);
            this.Mohreh_green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Mohreh_green.TabIndex = 0;
            this.Mohreh_green.TabStop = false;
            this.Mohreh_green.Visible = false;
            // 
            // Mohreh_Blue
            // 
            this.Mohreh_Blue.BackColor = System.Drawing.Color.Transparent;
            this.Mohreh_Blue.Image = global::Menj.Properties.Resources.mohre_Blue_copy;
            this.Mohreh_Blue.Location = new System.Drawing.Point(10, 57);
            this.Mohreh_Blue.Name = "Mohreh_Blue";
            this.Mohreh_Blue.Size = new System.Drawing.Size(48, 48);
            this.Mohreh_Blue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Mohreh_Blue.TabIndex = 1;
            this.Mohreh_Blue.TabStop = false;
            this.Mohreh_Blue.Visible = false;
            // 
            // Mohreh_Yellow
            // 
            this.Mohreh_Yellow.BackColor = System.Drawing.Color.Transparent;
            this.Mohreh_Yellow.Image = global::Menj.Properties.Resources.mohre_Yellow_copy;
            this.Mohreh_Yellow.Location = new System.Drawing.Point(10, 111);
            this.Mohreh_Yellow.Name = "Mohreh_Yellow";
            this.Mohreh_Yellow.Size = new System.Drawing.Size(48, 48);
            this.Mohreh_Yellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Mohreh_Yellow.TabIndex = 3;
            this.Mohreh_Yellow.TabStop = false;
            this.Mohreh_Yellow.Visible = false;
            // 
            // timer_visible
            // 
            this.timer_visible.Tick += new System.EventHandler(this.timer_visible_Tick);
            // 
            // timer_invisible
            // 
            this.timer_invisible.Tick += new System.EventHandler(this.timer_invisible_Tick);
            // 
            // timer_suddenMove
            // 
            this.timer_suddenMove.Tick += new System.EventHandler(this.timer_suddenMove_Tick);
            // 
            // Mohreh_Red
            // 
            this.Mohreh_Red.BackColor = System.Drawing.Color.Transparent;
            this.Mohreh_Red.Image = global::Menj.Properties.Resources.mohre_Red_copy;
            this.Mohreh_Red.Location = new System.Drawing.Point(10, 14);
            this.Mohreh_Red.Name = "Mohreh_Red";
            this.Mohreh_Red.Size = new System.Drawing.Size(48, 48);
            this.Mohreh_Red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Mohreh_Red.TabIndex = 2;
            this.Mohreh_Red.TabStop = false;
            this.Mohreh_Red.Visible = false;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Menj.Properties.Resources.back_copy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Mohreh_Yellow);
            this.Controls.Add(this.Mohreh_Red);
            this.Controls.Add(this.Mohreh_Blue);
            this.Controls.Add(this.Mohreh_green);
            this.Name = "Board";
            this.Size = new System.Drawing.Size(500, 500);
            ((System.ComponentModel.ISupportInitialize)(this.Mohreh_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mohreh_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mohreh_Yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mohreh_Red)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Mohreh_green;
        private System.Windows.Forms.PictureBox Mohreh_Blue;
        private System.Windows.Forms.PictureBox Mohreh_Yellow;
        private System.Windows.Forms.Timer timer_visible;
        private System.Windows.Forms.Timer timer_invisible;
        private System.Windows.Forms.Timer timer_suddenMove;
        private System.Windows.Forms.PictureBox Mohreh_Red;

    }
}
