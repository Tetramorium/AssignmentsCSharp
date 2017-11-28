namespace Assignment._7.YahtzeeGame.View
{
    partial class Yahtzee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yahtzee));
            this.gameMenu1 = new Assignment._7.YahtzeeGame.View.Partial.GameMenu();
            this.mainMenu1 = new Assignment._7.YahtzeeGame.View.Partial.MainMenu();
            this.SuspendLayout();
            // 
            // gameMenu1
            // 
            this.gameMenu1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gameMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameMenu1.Location = new System.Drawing.Point(0, 0);
            this.gameMenu1.Name = "gameMenu1";
            this.gameMenu1.RollsRemaining = 3;
            this.gameMenu1.Size = new System.Drawing.Size(624, 441);
            this.gameMenu1.TabIndex = 0;
            this.gameMenu1.Visible = false;
            // 
            // mainMenu1
            // 
            this.mainMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenu1.Location = new System.Drawing.Point(0, 0);
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Size = new System.Drawing.Size(624, 441);
            this.mainMenu1.TabIndex = 1;
            // 
            // Yahtzee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.gameMenu1);
            this.Controls.Add(this.mainMenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Yahtzee";
            this.Text = "App";
            this.ResumeLayout(false);

        }

        #endregion

        private Partial.GameMenu gameMenu1;
        private Partial.MainMenu mainMenu1;
    }
}