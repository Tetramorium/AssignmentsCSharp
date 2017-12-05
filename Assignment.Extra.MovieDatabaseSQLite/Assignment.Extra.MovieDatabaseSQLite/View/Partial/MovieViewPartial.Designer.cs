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
            this.lbl_MovieReleaseDate = new System.Windows.Forms.Label();
            this.bt_DeleteMovie = new System.Windows.Forms.Button();
            this.rtb_MovieName = new System.Windows.Forms.RichTextBox();
            this.bt_EditMovie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_MovieReleaseDate
            // 
            this.lbl_MovieReleaseDate.AutoSize = true;
            this.lbl_MovieReleaseDate.Location = new System.Drawing.Point(3, 41);
            this.lbl_MovieReleaseDate.Name = "lbl_MovieReleaseDate";
            this.lbl_MovieReleaseDate.Size = new System.Drawing.Size(35, 13);
            this.lbl_MovieReleaseDate.TabIndex = 1;
            this.lbl_MovieReleaseDate.Text = "label2";
            // 
            // bt_DeleteMovie
            // 
            this.bt_DeleteMovie.BackColor = System.Drawing.Color.Red;
            this.bt_DeleteMovie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_DeleteMovie.Location = new System.Drawing.Point(160, 44);
            this.bt_DeleteMovie.Name = "bt_DeleteMovie";
            this.bt_DeleteMovie.Size = new System.Drawing.Size(24, 23);
            this.bt_DeleteMovie.TabIndex = 2;
            this.bt_DeleteMovie.UseVisualStyleBackColor = false;
            this.bt_DeleteMovie.Click += new System.EventHandler(this.bt_DeleteMovie_Click);
            // 
            // rtb_MovieName
            // 
            this.rtb_MovieName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtb_MovieName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_MovieName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtb_MovieName.Location = new System.Drawing.Point(6, 3);
            this.rtb_MovieName.Name = "rtb_MovieName";
            this.rtb_MovieName.ReadOnly = true;
            this.rtb_MovieName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_MovieName.Size = new System.Drawing.Size(178, 35);
            this.rtb_MovieName.TabIndex = 3;
            this.rtb_MovieName.Text = "";
            // 
            // bt_EditMovie
            // 
            this.bt_EditMovie.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_EditMovie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_EditMovie.Location = new System.Drawing.Point(130, 44);
            this.bt_EditMovie.Name = "bt_EditMovie";
            this.bt_EditMovie.Size = new System.Drawing.Size(24, 23);
            this.bt_EditMovie.TabIndex = 4;
            this.bt_EditMovie.UseVisualStyleBackColor = false;
            this.bt_EditMovie.Click += new System.EventHandler(this.bt_EditMovie_Click);
            // 
            // MovieViewPartial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.bt_EditMovie);
            this.Controls.Add(this.rtb_MovieName);
            this.Controls.Add(this.bt_DeleteMovie);
            this.Controls.Add(this.lbl_MovieReleaseDate);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MovieViewPartial";
            this.Size = new System.Drawing.Size(187, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_MovieReleaseDate;
        private System.Windows.Forms.Button bt_DeleteMovie;
        private System.Windows.Forms.RichTextBox rtb_MovieName;
        private System.Windows.Forms.Button bt_EditMovie;
    }
}
