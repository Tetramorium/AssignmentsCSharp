namespace Assignment._2.FlagsOfTheWorld.View.MenuItem
{
    partial class GameMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Region = new System.Windows.Forms.Label();
            this.lbl_Cheat = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_CountriesLeft = new System.Windows.Forms.Label();
            this.lbl_CountriesLeftText = new System.Windows.Forms.Label();
            this.bt_Confirm = new System.Windows.Forms.Button();
            this.pb_FlagImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FlagImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.lbl_Region);
            this.panel1.Controls.Add(this.lbl_Cheat);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lbl_CountriesLeft);
            this.panel1.Controls.Add(this.lbl_CountriesLeftText);
            this.panel1.Controls.Add(this.bt_Confirm);
            this.panel1.Controls.Add(this.pb_FlagImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 474);
            this.panel1.TabIndex = 1;
            // 
            // lbl_Region
            // 
            this.lbl_Region.AutoSize = true;
            this.lbl_Region.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Region.Location = new System.Drawing.Point(155, 263);
            this.lbl_Region.Name = "lbl_Region";
            this.lbl_Region.Size = new System.Drawing.Size(75, 17);
            this.lbl_Region.TabIndex = 6;
            this.lbl_Region.Text = "lbl_Region";
            // 
            // lbl_Cheat
            // 
            this.lbl_Cheat.AutoSize = true;
            this.lbl_Cheat.Location = new System.Drawing.Point(459, 11);
            this.lbl_Cheat.Name = "lbl_Cheat";
            this.lbl_Cheat.Size = new System.Drawing.Size(35, 13);
            this.lbl_Cheat.TabIndex = 5;
            this.lbl_Cheat.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 317);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lbl_CountriesLeft
            // 
            this.lbl_CountriesLeft.AutoSize = true;
            this.lbl_CountriesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CountriesLeft.Location = new System.Drawing.Point(212, 11);
            this.lbl_CountriesLeft.Name = "lbl_CountriesLeft";
            this.lbl_CountriesLeft.Size = new System.Drawing.Size(18, 20);
            this.lbl_CountriesLeft.TabIndex = 3;
            this.lbl_CountriesLeft.Text = "0";
            // 
            // lbl_CountriesLeftText
            // 
            this.lbl_CountriesLeftText.AutoSize = true;
            this.lbl_CountriesLeftText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CountriesLeftText.Location = new System.Drawing.Point(13, 11);
            this.lbl_CountriesLeftText.Name = "lbl_CountriesLeftText";
            this.lbl_CountriesLeftText.Size = new System.Drawing.Size(101, 20);
            this.lbl_CountriesLeftText.TabIndex = 2;
            this.lbl_CountriesLeftText.Text = "Landen over:";
            // 
            // bt_Confirm
            // 
            this.bt_Confirm.Location = new System.Drawing.Point(381, 316);
            this.bt_Confirm.Name = "bt_Confirm";
            this.bt_Confirm.Size = new System.Drawing.Size(75, 23);
            this.bt_Confirm.TabIndex = 1;
            this.bt_Confirm.Text = "Volgende";
            this.bt_Confirm.UseVisualStyleBackColor = true;
            this.bt_Confirm.Click += new System.EventHandler(this.bt_Confirm_Click);
            // 
            // pb_FlagImage
            // 
            this.pb_FlagImage.Location = new System.Drawing.Point(156, 60);
            this.pb_FlagImage.Name = "pb_FlagImage";
            this.pb_FlagImage.Size = new System.Drawing.Size(300, 200);
            this.pb_FlagImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_FlagImage.TabIndex = 0;
            this.pb_FlagImage.TabStop = false;
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "GameMenu";
            this.Size = new System.Drawing.Size(637, 474);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FlagImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_FlagImage;
        private System.Windows.Forms.Button bt_Confirm;
        private System.Windows.Forms.Label lbl_CountriesLeft;
        private System.Windows.Forms.Label lbl_CountriesLeftText;
        private System.Windows.Forms.Label lbl_Cheat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Region;
    }
}
