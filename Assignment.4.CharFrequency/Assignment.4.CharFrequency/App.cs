using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment._4.CharFrequency
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();

            this.cb_AlgorithmSelection.SelectedIndex = 0;
        }

        private void bt_OpenTextFile_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                string text = File.ReadAllText(fileName, Encoding.UTF8);

                switch (cb_AlgorithmSelection.SelectedIndex)
                {
                    case 0:
                        countCharsList(fileName, text);
                        break;
                    case 1:
                        countCharsDictionary(fileName, text);
                        break;
                }
                
            }
        }

        public void countCharsList(string fileName, string text)
        {
            Stopwatch s = new Stopwatch();
            s.Start();

            List<CharCounter> Chars = new List<CharCounter>();

            foreach (char c in text)
            {
                int index = Chars.FindIndex(b => b.Character == c);
                if (index < 0)
                {
                    Chars.Add(new CharCounter(c));
                }
                else
                {
                    Chars[index].Count++;
                }
            }

            s.Stop();

            this.charCounterListControl1.Update(Chars, fileName, s.ElapsedMilliseconds);
        }

        public void countCharsDictionary(string fileName, string text)
        {
            Stopwatch s = new Stopwatch();
            s.Start();

            var counts = new Dictionary<char, int>();

            foreach (var c in text)
            {
                int count = 0;
                if (counts.ContainsKey(c))
                {
                    count = counts[c];
                }
                counts[c] = count + 1;
            }

            s.Stop();

            this.charCounterListControl1.Update(counts, fileName, s.ElapsedMilliseconds);
        }
    }
}
