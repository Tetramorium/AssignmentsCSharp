namespace Assignment._2.FlagsOfTheWorld.View.MenuItem
{
    partial class MainMenu
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Start = new System.Windows.Forms.Button();
            this.bt_French = new System.Windows.Forms.Button();
            this.bt_German = new System.Windows.Forms.Button();
            this.bt_Dutch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bt_Start);
            this.panel1.Controls.Add(this.bt_French);
            this.panel1.Controls.Add(this.bt_German);
            this.panel1.Controls.Add(this.bt_Dutch);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 474);
            this.panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(74, 250);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(477, 44);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Français";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Deutsche";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nederlands";
            // 
            // bt_Start
            // 
            this.bt_Start.Location = new System.Drawing.Point(248, 300);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(129, 51);
            this.bt_Start.TabIndex = 3;
            this.bt_Start.Text = "Starten";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // bt_French
            // 
            this.bt_French.BackgroundImage = global::Assignment._2.FlagsOfTheWorld.Properties.Resources.flag_of_France;
            this.bt_French.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_French.Location = new System.Drawing.Point(430, 3);
            this.bt_French.Name = "bt_French";
            this.bt_French.Size = new System.Drawing.Size(204, 120);
            this.bt_French.TabIndex = 2;
            this.bt_French.UseVisualStyleBackColor = true;
            // 
            // bt_German
            // 
            this.bt_German.BackgroundImage = global::Assignment._2.FlagsOfTheWorld.Properties.Resources.flag_of_Germany;
            this.bt_German.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_German.Location = new System.Drawing.Point(216, 3);
            this.bt_German.Name = "bt_German";
            this.bt_German.Size = new System.Drawing.Size(204, 120);
            this.bt_German.TabIndex = 1;
            this.bt_German.UseVisualStyleBackColor = true;
            // 
            // bt_Dutch
            // 
            this.bt_Dutch.BackgroundImage = global::Assignment._2.FlagsOfTheWorld.Properties.Resources.flag_of_Netherlands;
            this.bt_Dutch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Dutch.Location = new System.Drawing.Point(3, 3);
            this.bt_Dutch.Name = "bt_Dutch";
            this.bt_Dutch.Size = new System.Drawing.Size(204, 120);
            this.bt_Dutch.TabIndex = 0;
            this.bt_Dutch.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(640, 480);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_French;
        private System.Windows.Forms.Button bt_German;
        private System.Windows.Forms.Button bt_Dutch;
        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
