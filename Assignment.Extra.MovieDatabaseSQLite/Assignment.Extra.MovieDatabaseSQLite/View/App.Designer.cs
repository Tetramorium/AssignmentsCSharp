namespace Assignment.Extra.MovieDatabaseSQLite.View
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
            this.button1 = new System.Windows.Forms.Button();
            this.flp_MovieFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_AddMovie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flp_MovieFlow
            // 
            this.flp_MovieFlow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_MovieFlow.Location = new System.Drawing.Point(12, 12);
            this.flp_MovieFlow.Name = "flp_MovieFlow";
            this.flp_MovieFlow.Size = new System.Drawing.Size(260, 160);
            this.flp_MovieFlow.TabIndex = 1;
            // 
            // bt_AddMovie
            // 
            this.bt_AddMovie.Location = new System.Drawing.Point(12, 178);
            this.bt_AddMovie.Name = "bt_AddMovie";
            this.bt_AddMovie.Size = new System.Drawing.Size(75, 23);
            this.bt_AddMovie.TabIndex = 2;
            this.bt_AddMovie.Text = "Add movie";
            this.bt_AddMovie.UseVisualStyleBackColor = true;
            this.bt_AddMovie.Click += new System.EventHandler(this.bt_AddMovie_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bt_AddMovie);
            this.Controls.Add(this.flp_MovieFlow);
            this.Controls.Add(this.button1);
            this.Name = "App";
            this.Text = "App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flp_MovieFlow;
        private System.Windows.Forms.Button bt_AddMovie;
    }
}