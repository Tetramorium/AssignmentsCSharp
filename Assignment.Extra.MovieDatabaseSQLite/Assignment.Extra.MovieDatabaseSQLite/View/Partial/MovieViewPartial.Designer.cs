namespace Assignment.Extra.MovieDatabaseSQLite.View.Partial
{
    partial class MovieViewPartial
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
            this.lbl_MovieName = new System.Windows.Forms.Label();
            this.lbl_MovieReleaseDate = new System.Windows.Forms.Label();
            this.bt_DeleteMovie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_MovieName
            // 
            this.lbl_MovieName.AutoSize = true;
            this.lbl_MovieName.Location = new System.Drawing.Point(3, 9);
            this.lbl_MovieName.Name = "lbl_MovieName";
            this.lbl_MovieName.Size = new System.Drawing.Size(35, 13);
            this.lbl_MovieName.TabIndex = 0;
            this.lbl_MovieName.Text = "label1";
            // 
            // lbl_MovieReleaseDate
            // 
            this.lbl_MovieReleaseDate.AutoSize = true;
            this.lbl_MovieReleaseDate.Location = new System.Drawing.Point(3, 33);
            this.lbl_MovieReleaseDate.Name = "lbl_MovieReleaseDate";
            this.lbl_MovieReleaseDate.Size = new System.Drawing.Size(35, 13);
            this.lbl_MovieReleaseDate.TabIndex = 1;
            this.lbl_MovieReleaseDate.Text = "label2";
            // 
            // bt_DeleteMovie
            // 
            this.bt_DeleteMovie.BackColor = System.Drawing.Color.Red;
            this.bt_DeleteMovie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_DeleteMovie.Location = new System.Drawing.Point(4, 45);
            this.bt_DeleteMovie.Name = "bt_DeleteMovie";
            this.bt_DeleteMovie.Size = new System.Drawing.Size(24, 23);
            this.bt_DeleteMovie.TabIndex = 2;
            this.bt_DeleteMovie.UseVisualStyleBackColor = false;
            this.bt_DeleteMovie.Click += new System.EventHandler(this.bt_DeleteMovie_Click);
            // 
            // MovieViewPartial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.bt_DeleteMovie);
            this.Controls.Add(this.lbl_MovieReleaseDate);
            this.Controls.Add(this.lbl_MovieName);
            this.Name = "MovieViewPartial";
            this.Size = new System.Drawing.Size(100, 71);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MovieName;
        private System.Windows.Forms.Label lbl_MovieReleaseDate;
        private System.Windows.Forms.Button bt_DeleteMovie;
    }
}
