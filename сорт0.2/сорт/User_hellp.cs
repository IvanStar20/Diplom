using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace сорт
{
    public partial class User_hellp : Form
    {
        public User_hellp()
        {
            InitializeComponent();
        }
        public int[] loc = new int[] {13 , 188 , 1083 , 1557};

        private void User_hellp_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point p = new Point(0, loc[0]);
            panel1.AutoScrollPosition = p;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point p = new Point(0, loc[1]);
            panel1.AutoScrollPosition = p;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Point p = new Point(0, loc[2]);
            panel1.AutoScrollPosition = p;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Point p = new Point(0, loc[3]);
            panel1.AutoScrollPosition = p;
        }
    }
}
