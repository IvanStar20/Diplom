using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace сорт
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            textBox1.TabStop = false;
        }
        public string name { get; set; }

        public int size = 16;

        public List<string> fails = new List<string>();

        public Button button;

        /*public string clean()
        {
            FileInfo fi = new FileInfo(name);
            string[] splitfail = fi.FullName.Split(new char[] { '\\' });
            foreach(string s in splitfail)
            {
                fails.Add(s);
            }
            fails.Remove("bin");
            fails.Remove("Debug");
            string complit = String.Join("\\", fails);
            return complit;
        }*/
      
        public void read()
        {
            string text = "";
            //string pas = clean();
            FileInfo file = new FileInfo(name);
            using (StreamReader reader = new StreamReader(file.FullName, Encoding.GetEncoding(1251)))
            {
                text = reader.ReadToEnd();
            }
            textBox1.Text = text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            read();
        }

        private void Form2_Resize(object sender, EventArgs e)
        {

            Font font = new Font("Times New Roman", this.Width/100 + 10 > 10?this.Width / 100 + 5:10);
            textBox1.Font = font;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            button.Enabled = true;
        }
    }
}
