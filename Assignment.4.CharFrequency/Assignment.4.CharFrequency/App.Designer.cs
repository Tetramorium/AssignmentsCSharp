namespace Assignment._4.CharFrequency
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
            this.bt_OpenTextFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cb_AlgorithmSelection = new System.Windows.Forms.ComboBox();
            this.charCounterListControl1 = new Assignment._4.CharFrequency.CharCounterListControl();
            this.SuspendLayout();
            // 
            // bt_OpenTextFile
            // 
            this.bt_OpenTextFile.Location = new System.Drawing.Point(187, 226);
            this.bt_OpenTextFile.Name = "bt_OpenTextFile";
            this.bt_OpenTextFile.Size = new System.Drawing.Size(116, 23);
            this.bt_OpenTextFile.TabIndex = 0;
            this.bt_OpenTextFile.Text = "Open";
            this.bt_OpenTextFile.UseVisualStyleBackColor = true;
            this.bt_OpenTextFile.Click += new System.EventHandler(this.bt_OpenTextFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Text|*.txt|All|*.*\"";
            // 
            // cb_AlgorithmSelection
            // 
            this.cb_AlgorithmSelection.FormattingEnabled = true;
            this.cb_AlgorithmSelection.Items.AddRange(new object[] {
            "Method List",
            "Method Dictionary"});
            this.cb_AlgorithmSelection.Location = new System.Drawing.Point(187, 199);
            this.cb_AlgorithmSelection.Name = "cb_AlgorithmSelection";
            this.cb_AlgorithmSelection.Size = new System.Drawing.Size(116, 21);
            this.cb_AlgorithmSelection.TabIndex = 2;
            // 
            // charCounterListControl1
            // 
            this.charCounterListControl1.Location = new System.Drawing.Point(5, 4);
            this.charCounterListControl1.Name = "charCounterListControl1";
            this.charCounterListControl1.Size = new System.Drawing.Size(176, 245);
            this.charCounterListControl1.TabIndex = 1;
            this.charCounterListControl1.Visible = false;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 261);
            this.Controls.Add(this.cb_AlgorithmSelection);
            this.Controls.Add(this.charCounterListControl1);
            this.Controls.Add(this.bt_OpenTextFile);
            this.Name = "App";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_OpenTextFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private CharCounterListControl charCounterListControl1;
        private System.Windows.Forms.ComboBox cb_AlgorithmSelection;
    }
}

