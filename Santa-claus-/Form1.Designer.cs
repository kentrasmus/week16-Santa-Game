namespace Santa_claus_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ground = new System.Windows.Forms.PictureBox();
            this.Tree = new System.Windows.Forms.PictureBox();
            this.santa = new System.Windows.Forms.PictureBox();
            this.Flake = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.hut = new System.Windows.Forms.PictureBox();
            this.scorelabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.santa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hut)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-6, 681);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(833, 133);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // Tree
            // 
            this.Tree.Image = ((System.Drawing.Image)(resources.GetObject("Tree.Image")));
            this.Tree.Location = new System.Drawing.Point(652, 507);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(136, 189);
            this.Tree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tree.TabIndex = 1;
            this.Tree.TabStop = false;
            // 
            // santa
            // 
            this.santa.Image = ((System.Drawing.Image)(resources.GetObject("santa.Image")));
            this.santa.Location = new System.Drawing.Point(32, 315);
            this.santa.Name = "santa";
            this.santa.Size = new System.Drawing.Size(198, 134);
            this.santa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.santa.TabIndex = 2;
            this.santa.TabStop = false;
            this.santa.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Flake
            // 
            this.Flake.Image = ((System.Drawing.Image)(resources.GetObject("Flake.Image")));
            this.Flake.Location = new System.Drawing.Point(495, 45);
            this.Flake.Name = "Flake";
            this.Flake.Size = new System.Drawing.Size(140, 132);
            this.Flake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flake.TabIndex = 3;
            this.Flake.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(200, 123);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // hut
            // 
            this.hut.Image = ((System.Drawing.Image)(resources.GetObject("hut.Image")));
            this.hut.Location = new System.Drawing.Point(23, 545);
            this.hut.Name = "hut";
            this.hut.Size = new System.Drawing.Size(180, 173);
            this.hut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hut.TabIndex = 5;
            this.hut.TabStop = false;
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scorelabel.Location = new System.Drawing.Point(32, 186);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(86, 30);
            this.scorelabel.TabIndex = 6;
            this.scorelabel.Text = "Score 0:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playAgain
            // 
            this.playAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playAgain.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playAgain.Location = new System.Drawing.Point(414, 345);
            this.playAgain.Name = "playAgain";
            this.playAgain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.playAgain.Size = new System.Drawing.Size(162, 133);
            this.playAgain.TabIndex = 7;
            this.playAgain.Text = "Play again";
            this.playAgain.UseVisualStyleBackColor = true;
            this.playAgain.Visible = false;
            this.playAgain.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(818, 782);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.hut);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Flake);
            this.Controls.Add(this.santa);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.ground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.santa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox Tree;
        private System.Windows.Forms.PictureBox santa;
        private System.Windows.Forms.PictureBox Flake;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox hut;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button playAgain;
    }
}

