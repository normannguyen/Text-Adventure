namespace FinalProject
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
            this.textLbl = new System.Windows.Forms.Label();
            this.playerBox = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.newGME = new System.Windows.Forms.Button();
            this.colorBG = new System.Windows.Forms.GroupBox();
            this.purpleBtn = new System.Windows.Forms.RadioButton();
            this.lightgreenBtn = new System.Windows.Forms.RadioButton();
            this.greyBtn = new System.Windows.Forms.RadioButton();
            this.lightyellowBtn = new System.Windows.Forms.RadioButton();
            this.blueBtn = new System.Windows.Forms.RadioButton();
            this.redBtn = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorBtn = new System.Windows.Forms.Button();
            this.enterBtn = new System.Windows.Forms.Button();
            this.itemBox = new System.Windows.Forms.ListBox();
            this.healthInfo = new System.Windows.Forms.Label();
            this.enterBtn2 = new System.Windows.Forms.Button();
            this.enterBtn3 = new System.Windows.Forms.Button();
            this.enterBtn4 = new System.Windows.Forms.Button();
            this.enterBtn5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colorBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textLbl
            // 
            this.textLbl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.textLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLbl.Location = new System.Drawing.Point(336, 16);
            this.textLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textLbl.Name = "textLbl";
            this.textLbl.Size = new System.Drawing.Size(715, 482);
            this.textLbl.TabIndex = 0;
            this.textLbl.Click += new System.EventHandler(this.textLbl_Click);
            // 
            // playerBox
            // 
            this.playerBox.Location = new System.Drawing.Point(336, 514);
            this.playerBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(713, 22);
            this.playerBox.TabIndex = 1;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(952, 546);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 28);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // newGME
            // 
            this.newGME.Location = new System.Drawing.Point(336, 546);
            this.newGME.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newGME.Name = "newGME";
            this.newGME.Size = new System.Drawing.Size(100, 28);
            this.newGME.TabIndex = 3;
            this.newGME.Text = "New Game";
            this.newGME.UseVisualStyleBackColor = true;
            this.newGME.Click += new System.EventHandler(this.newGME_Click);
            // 
            // colorBG
            // 
            this.colorBG.Controls.Add(this.purpleBtn);
            this.colorBG.Controls.Add(this.lightgreenBtn);
            this.colorBG.Controls.Add(this.greyBtn);
            this.colorBG.Controls.Add(this.lightyellowBtn);
            this.colorBG.Controls.Add(this.blueBtn);
            this.colorBG.Controls.Add(this.redBtn);
            this.colorBG.Location = new System.Drawing.Point(17, 87);
            this.colorBG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorBG.Name = "colorBG";
            this.colorBG.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorBG.Size = new System.Drawing.Size(267, 123);
            this.colorBG.TabIndex = 5;
            this.colorBG.TabStop = false;
            this.colorBG.Text = "Background Color";
            // 
            // purpleBtn
            // 
            this.purpleBtn.AutoSize = true;
            this.purpleBtn.Location = new System.Drawing.Point(133, 80);
            this.purpleBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.purpleBtn.Name = "purpleBtn";
            this.purpleBtn.Size = new System.Drawing.Size(70, 21);
            this.purpleBtn.TabIndex = 5;
            this.purpleBtn.TabStop = true;
            this.purpleBtn.Text = "Purple";
            this.purpleBtn.UseVisualStyleBackColor = true;
            // 
            // lightgreenBtn
            // 
            this.lightgreenBtn.AutoSize = true;
            this.lightgreenBtn.Location = new System.Drawing.Point(133, 54);
            this.lightgreenBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lightgreenBtn.Name = "lightgreenBtn";
            this.lightgreenBtn.Size = new System.Drawing.Size(104, 21);
            this.lightgreenBtn.TabIndex = 4;
            this.lightgreenBtn.TabStop = true;
            this.lightgreenBtn.Text = "Light Green";
            this.lightgreenBtn.UseVisualStyleBackColor = true;
            // 
            // greyBtn
            // 
            this.greyBtn.AutoSize = true;
            this.greyBtn.Location = new System.Drawing.Point(133, 25);
            this.greyBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.greyBtn.Name = "greyBtn";
            this.greyBtn.Size = new System.Drawing.Size(60, 21);
            this.greyBtn.TabIndex = 3;
            this.greyBtn.TabStop = true;
            this.greyBtn.Text = "Grey";
            this.greyBtn.UseVisualStyleBackColor = true;
            // 
            // lightyellowBtn
            // 
            this.lightyellowBtn.AutoSize = true;
            this.lightyellowBtn.Location = new System.Drawing.Point(9, 80);
            this.lightyellowBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lightyellowBtn.Name = "lightyellowBtn";
            this.lightyellowBtn.Size = new System.Drawing.Size(104, 21);
            this.lightyellowBtn.TabIndex = 2;
            this.lightyellowBtn.TabStop = true;
            this.lightyellowBtn.Text = "Light Yellow";
            this.lightyellowBtn.UseVisualStyleBackColor = true;
            // 
            // blueBtn
            // 
            this.blueBtn.AutoSize = true;
            this.blueBtn.Location = new System.Drawing.Point(9, 53);
            this.blueBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.blueBtn.Name = "blueBtn";
            this.blueBtn.Size = new System.Drawing.Size(57, 21);
            this.blueBtn.TabIndex = 1;
            this.blueBtn.TabStop = true;
            this.blueBtn.Text = "Blue";
            this.blueBtn.UseVisualStyleBackColor = true;
            // 
            // redBtn
            // 
            this.redBtn.AutoSize = true;
            this.redBtn.Location = new System.Drawing.Point(9, 25);
            this.redBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(55, 21);
            this.redBtn.TabIndex = 0;
            this.redBtn.TabStop = true;
            this.redBtn.Text = "Red";
            this.redBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.Box_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(17, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // colorBtn
            // 
            this.colorBtn.Location = new System.Drawing.Point(125, 218);
            this.colorBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(159, 28);
            this.colorBtn.TabIndex = 7;
            this.colorBtn.Text = "Change Color";
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(648, 546);
            this.enterBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(100, 28);
            this.enterBtn.TabIndex = 8;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // itemBox
            // 
            this.itemBox.FormattingEnabled = true;
            this.itemBox.ItemHeight = 16;
            this.itemBox.Location = new System.Drawing.Point(27, 284);
            this.itemBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(237, 116);
            this.itemBox.TabIndex = 9;
            // 
            // healthInfo
            // 
            this.healthInfo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.healthInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.healthInfo.Location = new System.Drawing.Point(27, 416);
            this.healthInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.healthInfo.Name = "healthInfo";
            this.healthInfo.Size = new System.Drawing.Size(237, 39);
            this.healthInfo.TabIndex = 10;
            // 
            // enterBtn2
            // 
            this.enterBtn2.Location = new System.Drawing.Point(648, 546);
            this.enterBtn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enterBtn2.Name = "enterBtn2";
            this.enterBtn2.Size = new System.Drawing.Size(100, 28);
            this.enterBtn2.TabIndex = 11;
            this.enterBtn2.Text = "Enter";
            this.enterBtn2.UseVisualStyleBackColor = true;
            this.enterBtn2.Click += new System.EventHandler(this.enterBtn2_Click);
            // 
            // enterBtn3
            // 
            this.enterBtn3.Location = new System.Drawing.Point(648, 546);
            this.enterBtn3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enterBtn3.Name = "enterBtn3";
            this.enterBtn3.Size = new System.Drawing.Size(100, 28);
            this.enterBtn3.TabIndex = 12;
            this.enterBtn3.Text = "Enter";
            this.enterBtn3.UseVisualStyleBackColor = true;
            this.enterBtn3.Click += new System.EventHandler(this.enterBtn3_Click);
            // 
            // enterBtn4
            // 
            this.enterBtn4.Location = new System.Drawing.Point(648, 544);
            this.enterBtn4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enterBtn4.Name = "enterBtn4";
            this.enterBtn4.Size = new System.Drawing.Size(100, 28);
            this.enterBtn4.TabIndex = 13;
            this.enterBtn4.Text = "Enter";
            this.enterBtn4.UseVisualStyleBackColor = true;
            this.enterBtn4.Click += new System.EventHandler(this.enterBtn4_Click);
            // 
            // enterBtn5
            // 
            this.enterBtn5.Location = new System.Drawing.Point(648, 545);
            this.enterBtn5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enterBtn5.Name = "enterBtn5";
            this.enterBtn5.Size = new System.Drawing.Size(100, 28);
            this.enterBtn5.TabIndex = 14;
            this.enterBtn5.Text = "Enter";
            this.enterBtn5.UseVisualStyleBackColor = true;
            this.enterBtn5.Click += new System.EventHandler(this.enterBtn5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 258);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Inventory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterBtn5);
            this.Controls.Add(this.enterBtn4);
            this.Controls.Add(this.enterBtn3);
            this.Controls.Add(this.enterBtn2);
            this.Controls.Add(this.healthInfo);
            this.Controls.Add(this.itemBox);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.colorBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.colorBG);
            this.Controls.Add(this.newGME);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.playerBox);
            this.Controls.Add(this.textLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.colorBG.ResumeLayout(false);
            this.colorBG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button newGME;
        private System.Windows.Forms.GroupBox colorBG;
        private System.Windows.Forms.RadioButton lightyellowBtn;
        private System.Windows.Forms.RadioButton blueBtn;
        private System.Windows.Forms.RadioButton redBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.Button enterBtn;
        public System.Windows.Forms.TextBox playerBox;
        private System.Windows.Forms.ListBox itemBox;
        private System.Windows.Forms.RadioButton lightgreenBtn;
        private System.Windows.Forms.RadioButton greyBtn;
        private System.Windows.Forms.RadioButton purpleBtn;
        private System.Windows.Forms.Label healthInfo;
        private System.Windows.Forms.Button enterBtn2;
        private System.Windows.Forms.Button enterBtn3;
        private System.Windows.Forms.Button enterBtn4;
        private System.Windows.Forms.Button enterBtn5;
        private System.Windows.Forms.Label textLbl;
        private System.Windows.Forms.Label label1;
    }
}

