namespace Assignment._2.FlagsOfTheWorld.View
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.mainMenu1 = new Assignment._2.FlagsOfTheWorld.View.MenuItem.MainMenu();
            this.gameMenu1 = new Assignment._2.FlagsOfTheWorld.View.MenuItem.GameMenu();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainMenu1.Location = new System.Drawing.Point(0, 0);
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Size = new System.Drawing.Size(640, 441);
            this.mainMenu1.TabIndex = 0;
            // 
            // gameMenu1
            // 
            this.gameMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gameMenu1.Location = new System.Drawing.Point(640, 0);
            this.gameMenu1.Name = "gameMenu1";
            this.gameMenu1.Size = new System.Drawing.Size(637, 441);
            this.gameMenu1.TabIndex = 1;
            this.gameMenu1.Visible = false;
            // 
            // App
            // 
            this.ClientSize = new System.Drawing.Size(644, 441);
            this.Controls.Add(this.gameMenu1);
            this.Controls.Add(this.mainMenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "App";
            this.Text = "Flags of the World!";
            this.ResumeLayout(false);

        }

        #endregion

        private View.MenuItem.MainMenu mainMenu1;
        private View.MenuItem.GameMenu gameMenu1;
    }
}

