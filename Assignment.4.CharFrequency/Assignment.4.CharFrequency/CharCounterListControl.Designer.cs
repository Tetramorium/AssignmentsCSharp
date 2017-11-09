namespace Assignment._4.CharFrequency
{
    partial class CharCounterListControl
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
            this.lb_CharCounter = new System.Windows.Forms.ListBox();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.lbl_Duration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_CharCounter
            // 
            this.lb_CharCounter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_CharCounter.FormattingEnabled = true;
            this.lb_CharCounter.Location = new System.Drawing.Point(0, 59);
            this.lb_CharCounter.Name = "lb_CharCounter";
            this.lb_CharCounter.Size = new System.Drawing.Size(176, 186);
            this.lb_CharCounter.TabIndex = 0;
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.Location = new System.Drawing.Point(3, 10);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(35, 13);
            this.lbl_FileName.TabIndex = 1;
            this.lbl_FileName.Text = "label1";
            // 
            // lbl_Duration
            // 
            this.lbl_Duration.AutoSize = true;
            this.lbl_Duration.Location = new System.Drawing.Point(3, 34);
            this.lbl_Duration.Name = "lbl_Duration";
            this.lbl_Duration.Size = new System.Drawing.Size(35, 13);
            this.lbl_Duration.TabIndex = 2;
            this.lbl_Duration.Text = "label1";
            // 
            // CharCounterListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Duration);
            this.Controls.Add(this.lbl_FileName);
            this.Controls.Add(this.lb_CharCounter);
            this.Name = "CharCounterListControl";
            this.Size = new System.Drawing.Size(176, 245);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_CharCounter;
        private System.Windows.Forms.Label lbl_FileName;
        private System.Windows.Forms.Label lbl_Duration;
    }
}
