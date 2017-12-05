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
            this.flp_MovieFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_AddMovie = new System.Windows.Forms.Button();
            this.tb_SearchMovie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_OrderBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flp_MovieFlow
            // 
            this.flp_MovieFlow.AutoScroll = true;
            this.flp_MovieFlow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_MovieFlow.Dock = System.Windows.Forms.DockStyle.Left;
            this.flp_MovieFlow.Location = new System.Drawing.Point(0, 0);
            this.flp_MovieFlow.MinimumSize = new System.Drawing.Size(2, 200);
            this.flp_MovieFlow.Name = "flp_MovieFlow";
            this.flp_MovieFlow.Size = new System.Drawing.Size(215, 261);
            this.flp_MovieFlow.TabIndex = 1;
            // 
            // bt_AddMovie
            // 
            this.bt_AddMovie.Location = new System.Drawing.Point(224, 51);
            this.bt_AddMovie.Name = "bt_AddMovie";
            this.bt_AddMovie.Size = new System.Drawing.Size(75, 23);
            this.bt_AddMovie.TabIndex = 2;
            this.bt_AddMovie.Text = "Add movie";
            this.bt_AddMovie.UseVisualStyleBackColor = true;
            this.bt_AddMovie.Click += new System.EventHandler(this.bt_AddMovie_Click);
            // 
            // tb_SearchMovie
            // 
            this.tb_SearchMovie.Location = new System.Drawing.Point(224, 25);
            this.tb_SearchMovie.Name = "tb_SearchMovie";
            this.tb_SearchMovie.Size = new System.Drawing.Size(147, 20);
            this.tb_SearchMovie.TabIndex = 3;
            this.tb_SearchMovie.TextChanged += new System.EventHandler(this.tb_SearchMovie_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search movie";
            // 
            // cb_OrderBy
            // 
            this.cb_OrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_OrderBy.FormattingEnabled = true;
            this.cb_OrderBy.Items.AddRange(new object[] {
            "Name",
            "Releasedate"});
            this.cb_OrderBy.Location = new System.Drawing.Point(221, 118);
            this.cb_OrderBy.Name = "cb_OrderBy";
            this.cb_OrderBy.Size = new System.Drawing.Size(121, 21);
            this.cb_OrderBy.TabIndex = 5;
            this.cb_OrderBy.SelectionChangeCommitted += new System.EventHandler(this.cb_OrderBy_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Order by";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_OrderBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_SearchMovie);
            this.Controls.Add(this.bt_AddMovie);
            this.Controls.Add(this.flp_MovieFlow);
            this.Name = "App";
            this.Text = "App";
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flp_MovieFlow;
        private System.Windows.Forms.Button bt_AddMovie;
        private System.Windows.Forms.TextBox tb_SearchMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_OrderBy;
        private System.Windows.Forms.Label label2;
    }
}