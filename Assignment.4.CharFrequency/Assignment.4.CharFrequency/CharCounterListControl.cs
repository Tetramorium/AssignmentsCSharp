using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment._4.CharFrequency
{
    public partial class CharCounterListControl : UserControl
    {
        public CharCounterListControl()
        {
            InitializeComponent();

            this.Hide();
        }

        public void Update(List<CharCounter> lcc, string fileName, long timeElapsed)
        {
            this.lb_CharCounter.DataSource = null;
            this.lb_CharCounter.DataSource = lcc;

            this.lbl_FileName.Text = fileName;
            this.lbl_Duration.Text = timeElapsed.ToString();

            this.Show();
        }

        public void Update(Dictionary<Char, int> lcc, string fileName, long timeElapsed)
        {
            this.lb_CharCounter.DataSource = null;
            this.lb_CharCounter.DataSource = new BindingSource(lcc, null);

            this.lbl_FileName.Text = fileName;
            this.lbl_Duration.Text = timeElapsed.ToString();

            this.Show();
        }
    }
}
