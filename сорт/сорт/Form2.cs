using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            timer2.Start();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            /*pictureBox1.Location = new Point(0, 0);
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height;
            Random rnd = new Random();
            Color color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            pictureBox1.BackColor = color;*/

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*timer1.Start();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] mass = textBox1.Text.Split(',');
            int max = Convert.ToInt32(mass[0]);
            for(int i = 0; i < mass.Length; i++)
            {
                if(max < Convert.ToInt32(mass[i]))
                {
                    max = Convert.ToInt32(mass[i]);
                }
            }
            int[] count = new int[max + 1];
            foreach (string value in mass)
            {
                count[Convert.ToInt32(value)]++;
                
            }
            for(int i = 0; i < count.Length; i++)
            {
                listBox2.Items.Add(count[i]);
            }
            int[] sorted = new int[mass.Length];
            int index = 0;

            for (int i = 0; i < count.Length; i++)
            {
                while (count[i] > 0)
                {
                    sorted[index] = i;
                    index++;
                    count[i]--;
                }
            }
            foreach(int v in sorted)
            {
                listBox1.Items.Add(v);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(w == true)
            {
                label1.Location = new Point(label1.Location.X + 10, label1.Location.Y);
            }
            if(d == true)
            {
                label1.Location = new Point(label1.Location.X - 10, label1.Location.Y);
            }
            
        }
        public bool w = false;
        public bool d = false;
        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.A)
            {
                w = true;
            }
            else
            {
                w = false;
            }
            if(e.KeyChar == (char)Keys.D)
            {
                d = true;
            }
            else
            {
                d = false;
            }
        }
    }
}
