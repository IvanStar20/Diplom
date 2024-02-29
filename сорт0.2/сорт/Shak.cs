using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace сорт
{
    internal class Shak
    {
       /*public void finish { set; get; }
        public Label b1;
        public Label b2;
        public int b1x;
        public int b2x;
        public int spid;
        public int count;
        public int count1;
        public int i = 0;
        public int j = 1;
        public int prohof = 0;
        public int muveover = 0;
        public int proces;
        public List<int> random = new List<int>();

        /*public void box(string gatname, int gatx, int gaty, string gattext)
        {
            int x = gatx;
            int y = gaty;
            Label picture = new Label();
            picture.Width = 50;
            picture.Height = 50;
            picture.Text = gattext;
            picture.Font = new Font("Calibri", 20);
            picture.Padding = new Padding(5);
            picture.ForeColor = Color.White;
            picture.BackColor = Color.Black;
            picture.Name = gatname;
            picture.TextAlign = ContentAlignment.TopCenter;
            picture.Location = new Point(x, y);
            
        }*/

        /*public void rand(int count)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < count; i++)
            {
                list.Add(i);
            }
            while (list.Count > 0)
            {
                Random rand = new Random();
                int n = rand.Next(count);
                if (list.Contains(n))
                {
                    random.Add(n);
                    list.Remove(n);
                }
            }
        }*/

        /*public void finish()
        {

            for (int i = 0; i < random.Count; i++)
            {
                (this.Controls.Find(i.ToString(), true).First() as Label).BackColor = Color.Green;
            }
        }*/
        /*public void newbox()
        {
            int x = (this.Width - (95 * random.Count)) / 2;
            int y = 190;
            for (int i = 0; i < random.Count; i++)
            {
                box(i.ToString(), x, y, random[i].ToString());
                x += 100;
            }
        }*/

        /*private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length > 0)
            {
                string text = textBox1.Text;
                string[] words = text.Split(new char[] { ' ' });
                for (int i = 0; i < words.Length; i++)
                {
                    random.Add(Convert.ToInt32(words[i]));
                }
                newbox();
            }
            if (random.Count == 0)
            {
                string all = "";
                rand(Convert.ToInt32(comboBox1.SelectedItem));
                for (int i = 0; i < random.Count; i++)
                {
                    all += $" | {random[i]} | ";
                }
                listBox1.Items.Add(all);
                newbox();
            }

        }*/

        /*private void button2_Click(object sender, EventArgs e)
        {

        }

        private void muve_Tick(object sender, EventArgs e)
        {

            if (b1.Location.X < b2x)
            {
                proces = 1;
                b1.Left += spid;
            }
            if (b2.Location.X > b1x)
            {
                proces = 1;
                b2.Left -= spid;
            }
            else
            {
                muve.Stop();
                down.Start();
            }
        }*/

        /*private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                count1 = Convert.ToInt32(comboBox1.SelectedItem);
            }
            else
            {
                string[] words = textBox1.Text.Split(new char[] { ' ' });
                count1 = words.Length;
            }
            spid = Convert.ToInt32(trackBar1.Value);
            timer1.Start();
        }*/
        /*public Timer up = new Timer();
        public Timer muve = new Timer();
        public Timer down = new Timer();
        public Timer timer1 = new Timer();*/
        /*private void button4_Click(object sender, EventArgs e)
        {
            up.Stop();
            muve.Stop();
            down.Stop();
            timer1.Stop();
            b1 = null;
            b2 = null;
            b1x = 0;
            b2x = 0;
            proces = 0;
            prohof = 0;
            muveover = 0;
            count1 = 0;
            count = 0;
            and = 0;
            and1 = 0;
            i = 0;
            j = 1;
            for (int i = 0; i < random.Count; i++)
            {
                (this.Controls.Find(i.ToString(), true).First() as Label).Dispose();
            }
            random.Clear();
            listBox1.Items.Clear();

        }*/
        /*public int and = 0;
        public int and1 = 0;
        public void stop()
        {
            for (int i = 0; i < random.Count - 1; i++)
            {
                if (random[i] <= random[i + 1])
                {
                    and++;
                }
            }
            if (and == random.Count - 1)
            {
                timer1.Stop();
                //finish();
            }
            else
            {
                and = 0;
            }
        }
        public void atand()
        {
            for (int i = 0; i < random.Count; ++i)
            {
                for (int j = 0; j < random.Count; ++j)
                {
                    if (random[i] < random[j])
                    {
                        and++;
                    }
                }
                if (and == random.Count)
                {
                    and1 = random[i];

                }
            }


        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            prohof++;
            if (prohof < count1 * count1)
            {
                if (count < count1 - 1)
                {
                    proces = 3;
                    int temp;
                    if (random[i] > random[j])
                    {
                        proces = 3;
                        muveover = 0;
                        temp = random[i];
                        //b1 = (this.Controls.Find(i.ToString(), true).First() as Label);
                        //b2 = (this.Controls.Find(j.ToString(), true).First() as Label);
                        b1.BackColor = Color.Red;
                        b2.BackColor = Color.Red;
                        b1x = b1.Location.X;
                        b2x = b2.Location.X;
                        up.Start();
                        random[i] = random[j];
                        random[j] = temp;
                        i++;
                        j++;
                        count++;

                    }
                    else
                    {
                        i++;
                        j++;
                        count++;
                    }
                }
                else
                {
                    i = 0;
                    j = 1;
                    count = 0;

                }
            }
            else
            {

                timer1.Stop();

            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (proces)
            {
                case 0:
                    up.Stop();
                    break;
                case 1:
                    muve.Stop();

                    break;
                case 2:
                    down.Stop();
                    break;
                case 3:
                    timer1.Stop();
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch (proces)
            {
                case 0:
                    up.Start();
                    break;
                case 1:
                    muve.Start();
                    break;
                case 2:
                    down.Start();
                    break;
                case 3:
                    timer1.Start();
                    break;
            }

        }

        private void up_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (b1.Location.Y > 140)
            {
                proces = 0;
                b1.Top -= spid;
                b2.Top += spid;
            }
            else
            {
                up.Stop();
                muve.Start();
            }

        }

        private void down_Tick(object sender, EventArgs e)
        {

            if (b2.Location.Y > 190)
            {
                proces = 2;
                b2.Top -= spid;
                b1.Top += spid;
            }
            else
            {
                down.Stop();
                b1.BackColor = Color.Black;
                b2.BackColor = Color.Black;
                string name = b1.Name;
                b1.Name = b2.Name;
                b2.Name = name;
                stop();
                timer1.Start();

            }

        }
        
            int chek = 0;
            int repit = 0;
            int numm = 0;
            int reputnumm = 0;
            int[] mass = new int[] { 2, 5 ,1 ,2 ,3 ,5 ,2};
            int[] sort = new int[mass.Length];
            int k = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                chek = mass[i];
                for (int j = 0; j < mass.Length; j++)
                {
                    if ((chek > mass[j]) || ((chek == mass[j]) && (j < i)))
                    {
                        k++;
                    }
        
                }
                sort[k] = chek;
                k = 0;
           }
            for (int i = 0;i < sort.Length; i++)
            {
                Console.Write($"{mass[i]} ,");
            }
            Console.WriteLine();
            for (int i = 0; i < sort.Length; i++)
            {
                Console.Write($"{sort[i]} ,");
            }*/
         
    }
}
