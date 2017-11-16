namespace Assignment._7.YahtzeeGame.View.Partial
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
            this.bt_StartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_StartGame
            // 
            this.bt_StartGame.Location = new System.Drawing.Point(267, 152);
            this.bt_StartGame.Name = "bt_StartGame";
            this.bt_StartGame.Size = new System.Drawing.Size(75, 23);
            this.bt_StartGame.TabIndex = 0;
            this.bt_StartGame.Text = "Start Game";
            this.bt_StartGame.UseVisualStyleBackColor = true;
            this.bt_StartGame.Click += new System.EventHandler(this.bt_StartGame_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_StartGame);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(624, 441);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_StartGame;
    }
}
