using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace сорт
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Решить проблему с последним видом сортировки
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "4", "5", "6", "7", "8", "9", "10" });
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.Items.AddRange(new string[] { "сортировка пузырьком", "сортировка перемешиванием", "сортировка вставками", /*"сортировка подсчетом"*/"сортировка подсчетом 2" });
            comboBox2.SelectedIndex = 0;
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            trackBar1.Minimum = 2;
            trackBar1.Maximum = 5;
            for (int i = 1; i < 7; i++)
            {
                (this.Controls.Find("button" + i, true).First() as Button).Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            }
            for (int i = 1; i < 5; i++)
            {
                (this.Controls.Find("label" + i, true).First() as Label).Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            }
            //for (int i = 2; i < 3; i++)
            //{
                (this.Controls.Find("textbox1", true).First() as TextBox).Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            //}
            trackBar1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            comboBox1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            comboBox2.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            button7.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            button8.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            kpros.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            ipros.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            label1.Text = $"Скорость анимации : {trackBar1.Value}";
            button3.Enabled = false;
            button3.Visible = false;
            button5.Enabled = false;
            button6.Enabled = false;

        }

        public Label b1;
        public Label b2;
        public int white;
        public int b1x;
        public int b2x;
        public int spid;
        public int count;
        public int count1;
        public int i = 0;
        public int j = 1;
        public int prohof = 0;
        public int muveover = 0;
        public int proces = -1;
        public int and = 0;
        public int y;
        public int selected = 0;
        public bool stopstatus = true;
        public bool ProgremStatus = true;
        // public int sizechengt = 0;
        public int combo1selected = 0;
        public List<int> random = new List<int>();
        //public Color FormColor;
        public Color BlockColor = Color.Black;
        //Пораметры элемента
        public void box(string gatname, int gatx, int gaty, string gattext, int wight, int textsize)
        {
            int x = gatx;
            int y = gaty;
            Label picture = new Label();
            picture.Size = new Size(wight, wight);
            picture.Text = gattext;
            picture.Font = new Font("Calibri", textsize);
            picture.Padding = new Padding(5);
            picture.ForeColor = this.BackColor;
            picture.BackColor = BlockColor;
            picture.Name = gatname;
            picture.TextAlign = ContentAlignment.MiddleCenter;
            picture.Location = new Point(x, y);
            this.Controls.Add(picture);
        }
        //Случайные элементы для сортировки
        public void rand(int count)
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
        }
        //Последний этап сортировки
        public int finishishir = 0;

        public void finish()
        {
            button5.Enabled = false;
            button6.Enabled = false;
            int andsort1 = and1;
            if (andsort1 > 0 && comboBox2.SelectedItem.ToString() != "сортировка вставками")
            {
                elarm_2.Interval = 2000;
                elarm2chek();
                elarm_2.Start();
            }
            if (comboBox2.SelectedItem.ToString() == "сортировка вставками")
            {
                (this.Controls.Find(0.ToString(), true).First() as Label).BackColor = Color.Green;
            }
            this.FormBorderStyle = FormBorderStyle.Sizable;
            proces = -1;
            finishishir = 1;
            MessageBox.Show("END OF SORT");
            button5.Enabled = true;
            button6.Enabled = true;
        }
        //Центровка элементов
        public void incentr()
        {
            if (random.Count > 0)
            {
                int stap = white * 2;
                int centr = 0;
                y = (this.Height / 2) - white;
                if (random.Count % 2 == 0)
                {
                    centr = (this.Width / 2) + (white / 2);
                    for (int i = 0; i < random.Count / 2 - 1; i++)
                    {
                        int amount = (random.Count / 2) - i;
                        (this.Controls.Find(i.ToString(), true).First() as Label).Location = new Point(centr - (stap * amount), y);

                    }
                    (this.Controls.Find((random.Count / 2 - 1).ToString(), true).First() as Label).Location = new Point(centr - stap, y);
                    (this.Controls.Find((random.Count / 2).ToString(), true).First() as Label).Location = new Point(centr, y);
                    for (int i = random.Count / 2 + 1; i < random.Count; i++)
                    {
                        int start = (this.Controls.Find("0", true).First() as Label).Location.X;
                        int amount = stap * i;
                        (this.Controls.Find(i.ToString(), true).First() as Label).Location = new Point(start + amount, y);
                    }
                }
                if (random.Count % 2 == 1)
                {
                    centr = (this.Width / 2) - (white / 2);
                    for (int i = 0; i < random.Count / 2; i++)
                    {
                        int amount = (random.Count / 2) - i;
                        (this.Controls.Find(i.ToString(), true).First() as Label).Location = new Point(centr - (stap * amount), y);

                    }
                    for (int i = random.Count / 2; i < random.Count; i++)
                    {
                        int start = (this.Controls.Find("0", true).First() as Label).Location.X;
                        int amount = stap * i;
                        (this.Controls.Find(i.ToString(), true).First() as Label).Location = new Point(start + amount, y);
                    }
                }
            }

        }
        //Подсчет размера элементов
        public int itfit(int count)
        {

            int size1 = (this.Width) / (count * 2) <= 100 ? (this.Width) / (count * 2) : 100;
            white = size1;
            return white;

        }
        //Новый элемент
        public void newbox()
        {
            int wight;
            wight = textBox1.Text.Length > 0 ? itfit(random.Count) : itfit(Convert.ToInt32(comboBox1.SelectedItem.ToString()));
            for (int i = 0; i < random.Count; i++)
            {
                box(i.ToString(), x, y, random[i].ToString(), wight, wight / 2);
            }
            incentr();
        }
        public void StarProgrem()
        {

            count1 = random.Count;
            spid = Convert.ToInt32(trackBar1.Value);
            switch (comboBox2.SelectedItem)
            {
                case "сортировка пузырьком":
                    proces = 100;
                    timer1.Start();
                    break;
                case "сортировка перемешиванием":
                    proces = 200;
                    laft.Start();
                    break;
                case "сортировка вставками":
                    proces = 400;
                    sortinsert.Start();
                    break;
                case "сортировка подсчетом":
                    countn();
                    break;
                case "сортировка подсчетом 2":
                    proces = 500;
                    countn();
                    break;
            }
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            button3.Enabled = false;

        }
        //Кнопка добавения элементов
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length == 0)
            {
                rand(Convert.ToInt32(comboBox1.SelectedItem));
                newbox();
                button2.Enabled = false;
                button6.Enabled = true;
                comboBox2.Enabled = false;
            }
            else
            {
                string text = textBox1.Text;
                string[] words = text.Split(new char[] { ',' });
                if(int.TryParse(String.Join("",words), out int o))
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        random.Add(Convert.ToInt32(words[i]));
                    }
                    newbox();
                    button2.Enabled = false;
                    button6.Enabled = true;
                    comboBox2.Enabled = false;
                }
                /*int good = 0;
                for (int i = 0; i < words.Length; i++)
                {
                    if (int.TryParse(words[i], out int o) == true)
                    {
                        good++;
                    }
                }
                if (good == words.Length)
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        random.Add(Convert.ToInt32(words[i]));
                    }
                    newbox();
                    button2.Enabled = false;
                    comboBox2.Enabled = false;
                }*/
                else
                {
                    MessageBox.Show("Ошибка массива данных !\nВозможные причины:\n1) Указанны не верные данные.\n2) Ввод данных выполнен не правильно.\nДанные должны вводится через запятую без пробелов !\nВ конце не должно быть запятой !");
                    return;
                }
            }
        }
        //Перемешение элементов
        private void muve_Tick(object sender, EventArgs e)
        {
            proces = 1;
            switch (comboBox2.SelectedItem)
            {
                case "сортировка подсчетом 2":
                    goinplase_2.Stop();
                    if (top == 1)
                    {
                        if (b3.Location.X < b2.Location.X)
                        {
                            b3.Left += spid;
                        }
                        else
                        {
                            top = 3;
                        }
                    }
                    if (top == 2)
                    {
                        if (b3.Location.X > b2.Location.X)
                        {
                            b3.Left -= spid;
                        }
                        else
                        {
                            top = 3;
                        }
                    }
                    if (top == 3)
                    {
                        muve.Stop();
                        goinplase.Start();
                    }
                    break;
                default:
                    if (b1.Location.X < b2x)
                    {
                        b1.Left += spid;
                    }
                    if (b2.Location.X > b1x)
                    {
                        b2.Left -= spid;
                    }
                    else
                    {
                        muve.Stop();
                        down.Start();
                    }
                    break;

            }

        }
        //Кнопка запуска
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        public void fullcliar()
        {
            switch (comboBox2.SelectedItem)
            {
                case "сортировка подсчетом":
                    for (int i = 0; i < list2.Count; i++)
                    {
                        (this.Controls.Find("0" + list2[i].ToString(), true).First() as Label).Dispose();
                        (this.Controls.Find("l" + list2[i].ToString(), true).First() as Label).Dispose();
                    }
                    break;
                case "сортировка подсчетом 2":
                    for (int i = 0; i < random.Count; i++)
                    {
                        (this.Controls.Find("0" + i.ToString(), true).First() as Label).Dispose();
                        (this.Controls.Find("l" + i.ToString(), true).First() as Label).Dispose();
                    }
                    for (int i = 0; i < list3.Count; i++)
                    {
                        (this.Controls.Find(list3[i].ToString(), true).First() as Label).Dispose();
                    }
                    (this.Controls.Find("ipros", true).First() as Label).Visible = false;
                    (this.Controls.Find("kpros", true).First() as Label).Visible = false;
                    pic1.Dispose();
                    bmp.Dispose();
                    break;
            }
            if (proces == 9 || proces == 10 || proces == 15)
            {
                for (int i = 0; i < index; i++)
                {
                    (this.Controls.Find("b" + sorted[i].ToString(), true).First() as Label).Dispose();
                }
            }
        }
        public void fullstopanim()
        {
            up.Stop();
            muve.Stop();
            down.Stop();
            elarm.Stop();
            elarm_2.Stop();
            appinsert.Stop();
            godown.Stop();
            gotostart.Stop();
            goforword.Stop();
            countsort.Stop();
            coutindex.Stop();
            startcort.Stop();
            goinplase.Stop();
            countsort2in.Stop();
            goinplase_2.Stop();
        }
        //Кнопка очистк
        private void button4_Click(object sender, EventArgs e)
        {
            if (random.Count > 0)
            {
                fullstopanim();
                b1 = null;
                b2 = null;
                b3 = null;
                b1x = 0;
                b2x = 0;
                prohof = 0;
                muveover = 0;
                count1 = 0;
                count = 0;
                and = 0;
                left = 0;
                right1 = 1;
                hod = 0;
                hod2 = 0;
                stop1 = 0;
                finishishir = 0;
                greeni = 0;
                greenj = 0;
                x = 0;
                muv = 0;
                i = 0;
                j = 1;
                gofor = 0;
                interval = 0;
                counttwo = 0;
                k = 0;
                for (int i = 0; i < random.Count; i++)
                {
                    (this.Controls.Find(i.ToString(), true).First() as Label).Dispose();
                }
                if (button3.Enabled == false)
                {
                    fullcliar();
                    timer1.Stop();
                    laft.Stop();
                    right.Stop();
                    sortinsert.Stop();
                    chaksvop.Stop();
                }
                proces = -1;
                i1 = 0;
                i2 = 0;
                index = 0;
                c = 0;
                sdvig1 = 0;
                sdvig2 = 0;
                top = 0;
                random.Clear();
                list3.Clear();
                list2.Clear();
                list.Clear();
                this.FormBorderStyle = FormBorderStyle.Sizable;
                stopstatus = true;
                ProgremStatus = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button5.Enabled = false;
                button6.Enabled = false;
                comboBox2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Элементы не добавлены, очистка не нужна !");
            }
        }
        //Остановка сортировки
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
                switch (comboBox2.SelectedItem)
                {
                    case "сортировка пузырьком":
                        elarm.Stop();
                        finish();
                        break;
                    case "сортировка перемешиванием":
                        finish();
                        break;
                }
            }
            else
            {
                and = 0;
            }
        }
        //Смена элементов
        public void set(string i, string j)
        {
            b1 = (this.Controls.Find(i, true).First() as Label);
            b2 = (this.Controls.Find(j, true).First() as Label);
        }
        //Сортировка пузырьком
        public int hod = 0;
        public int notsvop = 0;
        public int and1 = 0;
        public void atand()
        {
            hod++;
            and1 = count1 - hod;
            if (count1 > hod - 1 && notsvop != 0)
            {
                (this.Controls.Find(and1.ToString(), true).First() as Label).BackColor = Color.Green;
            }
            else
            {
                and1 = count1;
            }
            timer1.Stop();
            stop();

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (stopstatus && proces == 100)
                if (count < count1 - (hod + 1))
                {
                    int temp;
                    if (random[i] > random[j])
                    {
                        muveover = 0;
                        temp = random[i];
                        set(i.ToString(), j.ToString());
                        proces = 0;
                        up.Start();
                        Thread.Sleep(100);
                        b1.BackColor = Color.Green;
                        b2.BackColor = Color.Green;
                        b1x = b1.Location.X;
                        b2x = b2.Location.X;
                        random[i] = random[j];
                        random[j] = temp;
                        i++;
                        j++;
                        count++;
                        notsvop = 1;

                    }
                    else
                    {

                        i++;
                        j++;
                        count++;
                        proces = 11;
                        timer1.Stop();
                        elarmchak();
                        elarm.Start();
                    }
                }
                else
                {
                    atand();
                    if (and == 0)
                    {
                        i = 0;
                        j = 1;
                        count = 0;
                        timer1.Start();
                    }

                }


        }
        //Кнопка стоп
        private void button5_Click(object sender, EventArgs e)
        {
            stopstatus = false;
            button6.Enabled = true;
            button5.Enabled = false;
            /*if (random.Count == 0)
            {
                MessageBox.Show("Элементы не добавленны !");
                return;
            }*/
            fullstopanim();
            MessageBox.Show(proces.ToString() + stopstatus + countsort2in.Enabled);
        }
        //Кнопка старт
        private void button6_Click(object sender, EventArgs e)
        {
            stopstatus = true;
            button6.Enabled = false;
            button5.Enabled = true;
            /*if(random.Count == 0)
            {
                MessageBox.Show("Элементы не добавленны !");
                return;
            }*/
            if (ProgremStatus)
            {
                StarProgrem();
                ProgremStatus = false;
            }
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
                    appinsert.Start();
                    break;
                case 4:
                    goforword.Start();
                    break;
                case 5:
                    gotostart.Start();
                    break;
                case 6:
                    godown.Start();
                    break;
                case 7:
                    coutindex.Start();
                    break;
                case 8:
                    startcort.Start();
                    break;
                case 9:
                    countsort.Start();
                    break;
                case 10:
                    goinplase.Start();
                    break;
                case 11:
                    elarm.Start();
                    break;
                case 12:
                    countsort2out.Start();
                    break;
                case 13:
                    countsort2in.Start();
                    break;
                case 14:
                    goinplase_2.Start();
                    break;
                case 100:
                    timer1.Start();
                    break;
                case 200:
                    laft.Start();
                    break;
                case 300:
                    right.Start();
                    break;
                case 500:
                    countsort2out.Start();
                    break;
            }
            MessageBox.Show($"{proces}" + stopstatus + countsort2in.Enabled);

        }
        //Анимации движения при сортировке перемешивание и сортировки пузырьком
        public void mdown()
        {
            switch (comboBox2.Text)
            {
                case "сортировка перемешиванием":
                    if (left == 0)
                    {
                        b1.Top += spid;
                        b2.Top -= spid;
                    }
                    if (right1 == 0)
                    {

                        b1.Top -= spid;
                        b2.Top += spid;
                    }
                    break;
                default:
                    b1.Top += spid;
                    b2.Top -= spid;
                    break;
            }
        }
        public void mup()
        {
            switch (comboBox2.Text)
            {
                case "сортировка перемешиванием":
                    if (left == 0)
                    {
                        b1.Top -= spid;
                        b2.Top += spid;
                    }
                    if (right1 == 0)
                    {

                        b1.Top += spid;
                        b2.Top -= spid;
                    }
                    break;
                default:
                    b1.Top -= spid;
                    b2.Top += spid;
                    break;
            }

        }
        public Label b;
        private void up_Tick(object sender, EventArgs e)
        {
            proces = 0;
            timer1.Stop();
            laft.Stop();
            right.Stop();
            chaksvop.Stop();
            if (right1 == 0)
            {
                b = b2;
            }
            else
            {
                b = b1;
            }
            if (b.Location.Y > (y - white))
            {
                proces = 0;
                mup();
            }
            else
            {
                up.Stop();
                muve.Start();
            }

        }

        private void down_Tick(object sender, EventArgs e)
        {
            proces = 2;
            if (right1 == 0)
            {
                b = b1;
            }
            else
            {
                b = b2;
            }
            if (b.Location.Y > y)
            {
                proces = 2;
                mdown();
            }
            else
            {
                b1.BackColor = BlockColor;
                b2.BackColor = BlockColor;
                Thread.Sleep(50);
                string name = b1.Name;
                b1.Name = b2.Name;
                b2.Name = name;
                down.Stop();
                switch (comboBox2.Text)
                {
                    case "сортировка пузырьком":
                        proces = 100;
                        timer1.Start();
                        break;
                    case "сортировка перемешиванием":
                        if (left == 0)
                        {
                            proces = 200;
                            laft.Start();
                        }
                        if (right1 == 0)
                        {
                            proces = 300;
                            right.Start();
                        }
                        break;
                    case "сортировка вставками":
                        //proces = 401;
                        chaksvop.Start();
                        break;
                }

            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = $"Скорость анимации : {trackBar1.Value}";
        }
        //Сортировка перемешивание
        public int left = 0;
        public int right1 = 1;
        public int hod2 = 0;
        public void atandshaklaft()
        {
            hod++;
            and1 = count1 - hod;
            if (count1 > hod - 1)
            {
                (this.Controls.Find(and1.ToString(), true).First() as Label).BackColor = Color.Green;
            }
            laft.Stop();
            stop();
        }

        public void atandshakright()
        {
            int and = hod2;
            (this.Controls.Find(and.ToString(), true).First() as Label).BackColor = Color.Green;
            hod2++;
            right.Stop();
            stop();
        }
        
        private void laft_Tick(object sender, EventArgs e)
        {
            if (stopstatus && proces == 200)
                if (count < count1 - (hod + 1))
                {
                    int temp;
                    if (random[i] > random[j])
                    {
                        temp = random[i];
                        set(i.ToString(), j.ToString());
                        proces = 0;
                        up.Start();
                        Thread.Sleep(100);
                        b1.BackColor = Color.Orange;
                        b2.BackColor = Color.Orange;
                        b1x = b1.Location.X;
                        b2x = b2.Location.X;
                        random[i] = random[j];
                        random[j] = temp;
                        i++;
                        j++;
                        count++;

                    }
                    else
                    {
                        proces = 11;
                        laft.Stop();
                        elarmchak();
                        elarm.Start();
                        i++;
                        j++;
                        count++;
                    }
                }
                else
                {
                    atandshaklaft();
                    if (and == 0)
                    {
                        left = 1;
                        right1 = 0;
                        j = random.Count - (hod + 1);
                        i = random.Count - (hod + 2);
                        laft.Stop();
                        proces = 300;
                        right.Start();
                    }
                }

        }

        private void right_Tick(object sender, EventArgs e)
        {
            if (stopstatus && proces == 300)
                if (count > hod)
                {
                    int temp;
                    if (random[i] > random[j])
                    {
                        temp = random[j];
                        set(i.ToString(), j.ToString());
                        proces = 0;
                        up.Start();
                        Thread.Sleep(100);
                        b1.BackColor = Color.Blue;
                        b2.BackColor = Color.Blue;
                        b1x = b1.Location.X;
                        b2x = b2.Location.X;
                        random[j] = random[i];
                        random[i] = temp;
                        i--;
                        j--;
                        count--;
                    }
                    else
                    {
                        proces = 11;
                        right.Stop();
                        elarmchak();
                        elarm.Start();
                        i--;
                        j--;
                        count--;
                    }
                }
                else
                {
                    atandshakright();
                    if (and == 0)
                    {
                        right1 = 1;
                        left = 0;
                        i = hod2;
                        j = hod2 + 1;
                        right.Stop();
                        proces = 200;
                        laft.Start();
                    }

                }

        }
        public int it = 0;
        //Центровка элементов
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (button2.Enabled == false)
            {
                int siz = textBox1.Text.Length > 0 ? itfit(random.Count) : itfit(Convert.ToInt32(comboBox1.SelectedItem.ToString())); ;
                for (int i = 0; i < random.Count; i++)
                {
                    (this.Controls.Find(i.ToString(), true).First() as Label).Size = new Size(siz, siz);
                    (this.Controls.Find(i.ToString(), true).First() as Label).Font = new Font("Calibri", siz / 2);
                }
                incentr();
            }

        }

        //Сортировка вставкой
        public int chakvalue;
        public Label moustsmol;
        List<int> list = new List<int>();
        public int gofor = 0;
        private void sortinsert_Tick(object sender, EventArgs e)
        {
            if (stopstatus && proces == 400)
                if (count < count1 - 1)
                {
                    count++;
                    chakvalue = random[count];
                    j = count;
                    sortinsert.Stop();
                    chaksvop.Start();

                }
                else
                {
                    sortinsert.Stop();
                    chaksvop.Stop();
                    finish();
                }
        }
        public int yes = 0;
        private void chaksvop_Tick(object sender, EventArgs e)
        {
            if (stopstatus && proces == 400)
                if (j > 0 && random[j - 1] > chakvalue)
                {
                    int temp = random[j];
                    list.Add(j - 1);
                    moustsmol = (this.Controls.Find(count.ToString(), true).First() as Label);
                    random[j] = random[j - 1];
                    random[j - 1] = temp;
                    j -= 1;
                    yes += 1;

                }
                else
                {

                    if (yes > 0)
                    {
                        yes = 0;
                        chaksvop.Stop();
                        sortinsert.Stop();
                        appinsert.Start();
                    }
                    else
                    {
                        proces = 11;
                        chaksvop.Stop();
                        random[j] = chakvalue;
                        elarmchak();
                        elarm.Start();
                        //sortinsert.Start();
                    }

                }
        }
        private void appinsert_Tick(object sender, EventArgs e)
        {
            proces = 3;
            if (moustsmol.Location.Y > (y - white * 2))
            {
                moustsmol.Top -= spid;
            }
            else
            {
                appinsert.Stop();
                chaksvop.Stop();
                goforword.Start();
            }
        }
        public int interval = 0;
        private void goforword_Tick(object sender, EventArgs e)
        {
            proces = 4;
            if ((this.Controls.Find(list[gofor].ToString(), true).First() as Label).Location.X < (this.Controls.Find((list[gofor] + 1).ToString(), true).First() as Label).Location.X - interval)
            {
                (this.Controls.Find(list[gofor].ToString(), true).First() as Label).Left += spid;
                (this.Controls.Find(list[gofor].ToString(), true).First() as Label).BackColor = Color.Green;

            }
            else
            {

                gofor++;
                interval = white * 2;
                if (gofor == list.Count)
                {

                    goforword.Stop();
                    gotostart.Start();
                }
            }
        }
        private void gotostart_Tick(object sender, EventArgs e)
        {
            proces = 5;
            if (moustsmol.Location.X > (this.Controls.Find(list[gofor - 1].ToString(), true).First() as Label).Location.X - white * 2)
            {
                moustsmol.Left -= spid;
            }
            else
            {
                gotostart.Stop();
                godown.Start();
            }
        }
        private void godown_Tick(object sender, EventArgs e)
        {
            proces = 6;
            if (moustsmol.Location.Y < y)
            {
                moustsmol.Top += spid;
            }
            else
            {
                int smolind = count - gofor;
                moustsmol.Name = (count - gofor).ToString();
                moustsmol.BackColor = Color.Green;
                int sdvig = gofor - 1;
                for (int i = 0; i < gofor; i++)
                {
                    (this.Controls.Find(list[i].ToString(), true).First() as Label).Name = (list[i] + 1).ToString();
                }
                gofor = 0;
                interval = 0;
                godown.Stop();
                list.Clear();
                proces = 400;
                sortinsert.Start();
                
            }
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //combo1selected = 1;
        }

        //Анимация подцветки элементов
        public int stop1 = 0;
        public int greeni, greenj = 0;
        public int start = 0;
        public int i1, j1 = 0;
        public Color color;
        public void elarmchak()
        {
            switch (comboBox2.Text)
            {
                case "сортировка пузырьком":
                    i1 = i - 1;
                    j1 = j - 1;
                    break;
                case "сортировка перемешиванием":
                    i1 = i;
                    j1 = j;
                    break;
                case "сортировка вставками":
                    i1 = j;
                    j1 = j;
                    start = 1;
                    break;
                case "сортировка подсчетом 2":
                    i1 = counttwo;
                    j1 = counttwo;
                    break;
            }
            if (green == 1)
            {
                color = Color.Green;
            }
            else
            {
                color = Color.Red;
            }
        }
        private void elarm_Tick(object sender, EventArgs e)
        {
            proces = 11;
            if (finishishir < 1)
            {

                if ((this.Controls.Find((i1).ToString(), true).First() as Label).BackColor == System.Drawing.Color.Green)
                {
                    greeni = 1;
                }
                if ((this.Controls.Find((j1).ToString(), true).First() as Label).BackColor == System.Drawing.Color.Green)
                {
                    greenj = 1;
                }
                if ((this.Controls.Find((i1).ToString(), true).First() as Label).BackColor == BlockColor && (this.Controls.Find((j1).ToString(), true).First() as Label).BackColor == BlockColor)
                {
                    (this.Controls.Find((i1).ToString(), true).First() as Label).BackColor = color;
                    (this.Controls.Find((j1).ToString(), true).First() as Label).BackColor = color;
                }
                else
                {
                    (this.Controls.Find((i1).ToString(), true).First() as Label).BackColor = BlockColor;
                    (this.Controls.Find((j1).ToString(), true).First() as Label).BackColor = BlockColor;
                }
                if (stop1 == 6)
                {
                    if (start == 1)
                    {
                        (this.Controls.Find((j1).ToString(), true).First() as Label).BackColor = Color.Green;
                        (this.Controls.Find((i1).ToString(), true).First() as Label).BackColor = Color.Green;
                        start = 0;
                    }
                    else
                    {
                        if (greeni == 1 && green == 0)
                        {
                            (this.Controls.Find((i1).ToString(), true).First() as Label).BackColor = Color.Green;

                        }
                        if (greenj == 1 && green == 0)
                        {
                            (this.Controls.Find((j1).ToString(), true).First() as Label).BackColor = Color.Green;
                        }
                        else
                        {
                            (this.Controls.Find((i1).ToString(), true).First() as Label).BackColor = BlockColor;
                            (this.Controls.Find((j1).ToString(), true).First() as Label).BackColor = BlockColor;
                        }
                    }
                    stop1 = 0;
                    greeni = 0;
                    greenj = 0;
                    green = 0;
                    switch (comboBox2.Text)
                    {
                        case "сортировка пузырьком":
                            timer1.Start();
                            proces = 100;
                            break;
                        case "сортировка перемешиванием":
                            if (left == 0)
                            {
                                laft.Start();
                                right.Stop();
                                proces = 200;
                            }
                            if (right1 == 0)
                            {
                                right.Start();
                                laft.Stop();
                                proces = 300;
                            }
                            break;
                        case "сортировка вставками":
                            sortinsert.Start();
                            proces = 400;
                            break;
                        case "сортировка подсчетом 2":
                            countsort2in.Start();
                            proces = 13;
                            break;
                    }
                    elarm.Stop();
                }
                stop1++;
            }

        }

        //Сортировка подсчетам
        public Label addlabel(string gatname, int gatx, int gaty, string gattext, int wight, int textsize, int box)
        {
            int x = gatx;
            int y = gaty;
            Label picture = new Label();
            picture.Size = new Size(wight, wight);
            picture.Text = gattext;
            picture.Font = new Font("Calibri", textsize);
            picture.Padding = new Padding(5);
            if (box == 1)
            {
                switch (comboBox2.SelectedItem.ToString())
                {

                    case "сортировка подсчетом":
                        picture.ForeColor = Color.White;
                        picture.BackColor = Color.Black;
                        break;
                    case "сортировка подсчетом 2":
                        picture.ForeColor = Color.Black;
                        break;
                }

            }
            picture.Name = gatname;
            picture.TextAlign = ContentAlignment.MiddleCenter;
            picture.Location = new Point(x, y);
            this.Controls.Add(picture);
            return picture;
        }
        public void countn()
        {
            int x = (this.Controls.Find(0.ToString(), true).First() as Label).Location.X;
            int max = Convert.ToInt32(random[0]);
            for (int i = 0; i < random.Count; i++)
            {
                if (max < Convert.ToInt32(random[i]))
                {
                    max = Convert.ToInt32(random[i]);
                }
                countindex = new int[max + 1];
            }
            for (int i = 0; i < random.Count; i++)
            {
                countindex[random[i]]++;
                x = (this.Controls.Find(i.ToString(), true).First() as Label).Location.X;
                (this.Controls.Find(i.ToString(), true).First() as Label).Location = new Point(x, y - white - white / 4);
            }
            for (int i = 0; i < max + 1; i++)
            {
                if (countindex[i] > 0)
                {
                    list2.Add(i.ToString());
                }
            }
            switch (comboBox2.SelectedItem)
            {

                case "сортировка подсчетом":
                    for (int i = 0; i < list2.Count; i++)
                    {
                        x = (this.Controls.Find(i.ToString(), true).First() as Label).Location.X;
                        box("0" + list2[i].ToString(), x, y, list2[i].ToString(), white, white / 2);
                        addlabel("l" + list2[i].ToString(), x, y + (white - white / 4), 0.ToString(), white, white / 2, 0);
                    }
                    countindex = new int[max + 1];
                    coutindex.Start();
                    break;
                case "сортировка подсчетом 2":
                    for (int i = 0; i < random.Count; i++)
                    {
                        x = (this.Controls.Find(i.ToString(), true).First() as Label).Location.X;
                        box("0" + i.ToString(), x, y + white + white / 4, 0.ToString(), white, white / 2);
                        addlabel("l" + i.ToString(), x, y + white * 2, i.ToString(), white, white / 2, 0);
                    }
                    (this.Controls.Find("ipros".ToString(), true).First() as Label).Visible = true;
                    (this.Controls.Find("kpros".ToString(), true).First() as Label).Visible = true;
                    strelca(white - white / 4);
                    img();
                    pic1.Location = new Point(0, -500);
                    countsort2out.Start();
                    break;
            }
        }
        public List<string> list2 = new List<string>();
        public List<string> list3 = new List<string>();
        public int[] countindex = new int[0];
        public int[] sorted = new int[0];
        public int muv = 0;
        public int x = 0;
        public int index = 0;
        public int i2 = 0;
        private void coutindex_Tick(object sender, EventArgs e)
        {
            proces = 7;
            if (muv == random.Count)
            {
                coutindex.Stop();
                x = 2;
                muv = 0;
                for (int i = 0; i < random.Count; i++)
                {
                    (this.Controls.Find(i.ToString(), true).First() as Label).Visible = false;
                }
                sorted = new int[random.Count];
                countsort.Start();
            }
            if (x == 0)
            {
                (this.Controls.Find(muv.ToString(), true).First() as Label).BackColor = Color.Red;
                int index = Convert.ToInt32((this.Controls.Find(muv.ToString(), true).First() as Label).Text);
                (this.Controls.Find(("0" + index).ToString(), true).First() as Label).BackColor = Color.Red;
                countindex[random[muv]]++;
                (this.Controls.Find("l" + index.ToString(), true).First() as Label).Text = countindex[random[muv]].ToString();
                x = 1;
                return;
            }
            if (x == 1)
            {
                (this.Controls.Find(muv.ToString(), true).First() as Label).BackColor = Color.Black;
                int index = Convert.ToInt32((this.Controls.Find(muv.ToString(), true).First() as Label).Text);
                (this.Controls.Find("0" + index.ToString(), true).First() as Label).BackColor = Color.Black;
                x = 0;
            }
            muv++;

        }
        public int c = 0;
        private void startcort_Tick(object sender, EventArgs e)
        {
            proces = 8;
            if (i2 < countindex.Length)
            {
                i2++;
                countsort.Start();
                startcort.Stop();

            }

        }

        private void countsort_Tick(object sender, EventArgs e)
        {
            proces = 9;
            //if(stopstatus)
            if (countindex[i2] > 0)
            {
                sorted[index] = i2;
                int x = (this.Controls.Find("0" + i2.ToString(), true).First() as Label).Location.X;
                b2 = (this.Controls.Find(index.ToString(), true).First() as Label);
                b1 = addlabel("b" + i2.ToString(), x, y, i2.ToString(), white, white / 2, 1);
                index++;
                countindex[i2]--;
                (this.Controls.Find("l" + i2.ToString(), true).First() as Label).Text = countindex[i2].ToString();
                (this.Controls.Find(("0" + i2).ToString(), true).First() as Label).BackColor = Color.Red;
                goinplase.Start();
                c++;
            }
            else
            {
                startcort.Start();
            }
        }
        public int sdvig1 = 0;
        public int sdvig2 = 0;
        private void goinplase_Tick(object sender, EventArgs e)
        {
            proces = 10;
            switch (comboBox2.SelectedItem)
            {
                case "сортировка подсчетом":
                    countsort.Stop();
                    if (b1.Location.Y > b2.Location.Y)
                    {
                        if (spid != 1)
                        {
                            b1.Top -= spid / 2;
                        }
                        else
                        {
                            b1.Top -= spid;
                        }
                    }
                    else
                    {
                        sdvig1 = 1;
                    }
                    if (b2.Location.X > b1.Location.X)
                    {
                        b1.Left += spid;
                    }
                    else
                    {
                        sdvig2 = 1;
                    }
                    if (sdvig1 == 1 && sdvig2 == 1)
                    {
                        b1.BackColor = Color.Green;
                        (this.Controls.Find(("0" + i2).ToString(), true).First() as Label).BackColor = Color.Black;
                        goinplase.Stop();
                        countsort.Start();
                        sdvig1 = 0;
                        sdvig2 = 0;
                        if (c == random.Count)
                        {
                            countsort.Stop();
                            goinplase.Stop();
                            startcort.Stop();
                            c = 0;
                            sdvig1 = 0;
                            sdvig2 = 0;
                            proces = 15;
                            MessageBox.Show(proces.ToString());
                        }
                    }
                    break;
                case "сортировка подсчетом 2":
                    if (top == 3 && b3.Location.Y < b2.Location.Y)
                    {
                        b3.Top += spid;
                    }
                    else
                    {
                        top = 4;
                        goinplase.Stop();
                        goinplase_2.Start();
                    }
                    break;
            }

        }
        //Сортировка подсчетом 2
        public int chak = 0;
        public int counttwo = 0;
        public int k = 0;
        private void countsort2out_Tick(object sender, EventArgs e)
        {
            //proces = 12;
            if (stopstatus && proces == 500)
                if (count < count1)
                {
                    chak = random[count];
                    //(this.Controls.Find("t".ToString(), true).First() as Label).Text = $"chak = {chak}";
                    pic1.Location = new Point((this.Controls.Find(count.ToString(), true).First() as Label).Location.X + white / 8, y - white * 2);
                    (this.Controls.Find("ipros".ToString(), true).First() as Label).Text = $"i = {count}";
                    (this.Controls.Find("kpros".ToString(), true).First() as Label).Text = $"k = {k}";
                    countsort2in.Start();
                    proces = 13;
                    //countsort2out.Stop();
                }
                else
                {
                    //fullstop();
                    countsort2out.Stop();
                    MessageBox.Show("END OF SORT");
                }
        }
        public Label b3;
        public int green = 0;
        private void countsort2in_Tick(object sender, EventArgs e)
        {
            proces = 13;
            if (counttwo < count1)
            {

                if ((chak > random[counttwo]) || ((chak == random[counttwo]) && (counttwo < count)))
                {

                    k++;
                    (this.Controls.Find("kpros".ToString(), true).First() as Label).Text = $"k = {k}";
                    if (counttwo < count1)
                    {
                        green = 1;
                        proces = 11;
                        countsort2in.Stop();
                        elarmchak();
                        elarm.Start();
                        
                    }
                }
                else
                {
                    if (counttwo < count1)
                    {
                        proces = 11;
                        countsort2in.Stop();
                        elarmchak();
                        elarm.Start();
                        
                    }
                }
                counttwo++;
            }
            else
            {
                b3 = new Label();
                countsort2in.Stop();
                set(count.ToString(), "0" + k.ToString());
                box("s" + b1.Name.ToString(), b1.Location.X, b1.Location.Y, b1.Text.ToString(), b1.Width, b1.Width / 2);
                b3 = (this.Controls.Find("s" + b1.Name.ToString(), true).First() as Label);
                list3.Add(b3.Name);
                int x = b2.Location.X;
                int y = b2.Location.Y;
                b3.BringToFront();
                goinplase_2.Start();

            }
        }
        public int top = 0;
        private void goinplase_2_Tick(object sender, EventArgs e)
        {
            proces = 14;
            if (top == 4)
            {
                goinplase_2.Stop();
                b2.Visible = false;
                //(this.Controls.Find(count.ToString(), true).First() as Label).BackColor = Color.Black;
                (this.Controls.Find("s" + b1.Name.ToString(), true).First() as Label).BackColor = Color.Green;
                count++;
                k = 0;
                (this.Controls.Find("kpros".ToString(), true).First() as Label).Text = $"k = {k}";
                counttwo = 0;
                top = 0;
                //pic1.Location = new Point((this.Controls.Find(count.ToString(), true).First() as Label).Location.X, y - size);
                countsort2out.Start();
                proces = 500;
            }
            else
            {
                if (top == 0 && b3.Location.Y < b2.Location.Y - (b2.Width + (b2.Width / 4)))
                {
                    b3.Top += spid;
                }
                else
                {
                    if (b3.Location.X < b2.Location.X)
                    {
                        top = 1;
                    }
                    else
                    {
                        top = 2;
                    }
                    muve.Start();
                }

            }

        }

        public PictureBox pic1;
        public Bitmap bmp;

        public void strelca(int white)
        {
            PictureBox pic = new PictureBox();
            pic.Size = new Size(white, white);
            pic.BackColor = Color.Transparent;
            pic.Name = "strelka";
            this.Controls.Add(pic);
            pic1 = pic;
        }
        public void img()
        {
            bmp = new Bitmap(Convert.ToInt32(1024), Convert.ToInt32(1024));
            using (Graphics g = Graphics.FromImage(bmp))
            {
                Pen pen = new Pen(Color.Red, pic1.Width / 3);
                pen.StartCap = LineCap.ArrowAnchor;
                g.DrawLine(pen, pic1.Width / 2, pic1.Width, pic1.Width / 2, 0);
            }
            pic1.Image = bmp;
        }

        public int startof;
        public int andof;
        public int blink;
        public void elarm2chek()
        {
            elarm_2.Interval = 200;
            switch (comboBox2.SelectedItem)
            {
                case "сортировка пузырьком":
                    startof = 0;
                    andof = and1;
                    blink = 12;
                    break;
                case "сортировка перемешиванием":
                    startof = hod2;
                    andof = and1;
                    blink = 12;
                    break;
            }
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //selected = 1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button4_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //FormColor = this.BackColor;
            Settings settings = new Settings();
            settings.FormColor = this.BackColor;
            settings.BlokColor = BlockColor;
            settings.form = this;
            settings.ShowDialog();
            if(settings.Save)
            BlockColor = settings.BlokColor;
            //MessageBox.Show(BlockColor.Name);
        }

        private void elarm_2_Tick(object sender, EventArgs e)
        {
            if (stop1 < blink)
            {
                if ((this.Controls.Find(startof.ToString(), true).First() as Label).BackColor == BlockColor)
                {
                    for (int j = startof; j < andof; j++)
                    {
                        (this.Controls.Find(j.ToString(), true).First() as Label).BackColor = Color.Green;
                    }
                }
                else
                {
                    for (int j = startof; j < andof; j++)
                    {
                        (this.Controls.Find(j.ToString(), true).First() as Label).BackColor = BlockColor;
                    }
                }
                stop1++;
            }
            else
            {
                elarm_2.Stop();
                //blink = 0;
            }
            //stop1++;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.button = button7;
            button7.Enabled = false;
            switch (comboBox2.SelectedItem)
            {
                case "сортировка пузырьком":
                    form.name = "text\\text1.txt";
                    break;
                case "сортировка перемешиванием":
                    form.name = "text\\text2.txt";
                    break;
                case "сортировка вставками":
                    form.name = "text\\text3.txt";
                    break;
                case "сортировка подсчетом 2":
                    form.name = "text\\text4.txt";
                    break;
            }
            form.Show();
        }

    }
}
