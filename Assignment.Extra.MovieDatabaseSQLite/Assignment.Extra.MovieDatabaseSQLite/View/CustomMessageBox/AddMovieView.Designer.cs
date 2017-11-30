namespace Assignment.Extra.MovieDatabaseSQLite.View.CustomMessageBox
{
    partial class AddMovieView
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
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Accept = new System.Windows.Forms.Button();
            this.dtp_MovieReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.tb_MovieName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancel.Location = new System.Drawing.Point(12, 64);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancel.TabIndex = 0;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            // 
            // bt_Accept
            // 
            this.bt_Accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Accept.Location = new System.Drawing.Point(137, 64);
            this.bt_Accept.Name = "bt_Accept";
            this.bt_Accept.Size = new System.Drawing.Size(75, 23);
            this.bt_Accept.TabIndex = 1;
            this.bt_Accept.Text = "Accept";
            this.bt_Accept.UseVisualStyleBackColor = true;
            this.bt_Accept.Click += new System.EventHandler(this.bt_Accept_Click);
            // 
            // dtp_MovieReleaseDate
            // 
            this.dtp_MovieReleaseDate.Location = new System.Drawing.Point(12, 38);
            this.dtp_MovieReleaseDate.MaxDate = new System.DateTime(2017, 11, 29, 0, 0, 0, 0);
            this.dtp_MovieReleaseDate.Name = "dtp_MovieReleaseDate";
            this.dtp_MovieReleaseDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_MovieReleaseDate.TabIndex = 2;
            this.dtp_MovieReleaseDate.Value = new System.DateTime(2017, 11, 29, 0, 0, 0, 0);
            // 
            // tb_MovieName
            // 
            this.tb_MovieName.Location = new System.Drawing.Point(12, 12);
            this.tb_MovieName.Name = "tb_MovieName";
            this.tb_MovieName.Size = new System.Drawing.Size(200, 20);
            this.tb_MovieName.TabIndex = 3;
            // 
            // AddMovieView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 97);
            this.Controls.Add(this.tb_MovieName);
            this.Controls.Add(this.dtp_MovieReleaseDate);
            this.Controls.Add(this.bt_Accept);
            this.Controls.Add(this.bt_Cancel);
            this.Name = "AddMovieView";
            this.Text = "AddMovieView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_Accept;
        private System.Windows.Forms.DateTimePicker dtp_MovieReleaseDate;
        private System.Windows.Forms.TextBox tb_MovieName;
    }
}