namespace сорт
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.muve = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Timer(this.components);
            this.down = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.laft = new System.Windows.Forms.Timer(this.components);
            this.right = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sortinsert = new System.Windows.Forms.Timer(this.components);
            this.chaksvop = new System.Windows.Forms.Timer(this.components);
            this.elarm = new System.Windows.Forms.Timer(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.appinsert = new System.Windows.Forms.Timer(this.components);
            this.goforword = new System.Windows.Forms.Timer(this.components);
            this.gotostart = new System.Windows.Forms.Timer(this.components);
            this.godown = new System.Windows.Forms.Timer(this.components);
            this.coutindex = new System.Windows.Forms.Timer(this.components);
            this.startcort = new System.Windows.Forms.Timer(this.components);
            this.countsort = new System.Windows.Forms.Timer(this.components);
            this.goinplase = new System.Windows.Forms.Timer(this.components);
            this.countsort2out = new System.Windows.Forms.Timer(this.components);
            this.countsort2in = new System.Windows.Forms.Timer(this.components);
            this.goinplase_2 = new System.Windows.Forms.Timer(this.components);
            this.elarm_2 = new System.Windows.Forms.Timer(this.components);
            this.ipros = new System.Windows.Forms.Label();
            this.kpros = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 706);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 0;
            this.button2.Text = "добавить элементы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // muve
            // 
            this.muve.Interval = 1;
            this.muve.Tick += new System.EventHandler(this.muve_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(984, 719);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "запуск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(115, 706);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 50);
            this.button4.TabIndex = 5;
            this.button4.Text = "удалить элементы\r\n";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(115, 760);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 50);
            this.button5.TabIndex = 7;
            this.button5.Text = "стоп";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(8, 760);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 50);
            this.button6.TabIndex = 8;
            this.button6.Text = "старт";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // up
            // 
            this.up.Interval = 1;
            this.up.Tick += new System.EventHandler(this.up_Tick);
            // 
            // down
            // 
            this.down.Interval = 1;
            this.down.Tick += new System.EventHandler(this.down_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(221, 727);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(566, 775);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(211, 56);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 756);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 709);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Длина случайного массива данных\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(327, 775);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 34);
            this.textBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(119, 9);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(312, 24);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // laft
            // 
            this.laft.Tick += new System.EventHandler(this.laft_Tick);
            // 
            // right
            // 
            this.right.Tick += new System.EventHandler(this.right_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "вид сортирови:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 756);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Поле для ввода данных массива";
            // 
            // sortinsert
            // 
            this.sortinsert.Tick += new System.EventHandler(this.sortinsert_Tick);
            // 
            // chaksvop
            // 
            this.chaksvop.Tick += new System.EventHandler(this.chaksvop_Tick);
            // 
            // elarm
            // 
            this.elarm.Interval = 200;
            this.elarm.Tick += new System.EventHandler(this.elarm_Tick);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(1262, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(208, 31);
            this.button7.TabIndex = 25;
            this.button7.Text = "информация о сортировке!";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // appinsert
            // 
            this.appinsert.Interval = 1;
            this.appinsert.Tick += new System.EventHandler(this.appinsert_Tick);
            // 
            // goforword
            // 
            this.goforword.Interval = 1;
            this.goforword.Tick += new System.EventHandler(this.goforword_Tick);
            // 
            // gotostart
            // 
            this.gotostart.Interval = 1;
            this.gotostart.Tick += new System.EventHandler(this.gotostart_Tick);
            // 
            // godown
            // 
            this.godown.Interval = 1;
            this.godown.Tick += new System.EventHandler(this.godown_Tick);
            // 
            // coutindex
            // 
            this.coutindex.Interval = 300;
            this.coutindex.Tick += new System.EventHandler(this.coutindex_Tick);
            // 
            // startcort
            // 
            this.startcort.Interval = 1;
            this.startcort.Tick += new System.EventHandler(this.startcort_Tick);
            // 
            // countsort
            // 
            this.countsort.Interval = 1;
            this.countsort.Tick += new System.EventHandler(this.countsort_Tick);
            // 
            // goinplase
            // 
            this.goinplase.Interval = 1;
            this.goinplase.Tick += new System.EventHandler(this.goinplase_Tick);
            // 
            // countsort2out
            // 
            this.countsort2out.Tick += new System.EventHandler(this.countsort2out_Tick);
            // 
            // countsort2in
            // 
            this.countsort2in.Tick += new System.EventHandler(this.countsort2in_Tick);
            // 
            // goinplase_2
            // 
            this.goinplase_2.Interval = 1;
            this.goinplase_2.Tick += new System.EventHandler(this.goinplase_2_Tick);
            // 
            // elarm_2
            // 
            this.elarm_2.Interval = 200;
            this.elarm_2.Tick += new System.EventHandler(this.elarm_2_Tick);
            // 
            // ipros
            // 
            this.ipros.AutoSize = true;
            this.ipros.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ipros.Location = new System.Drawing.Point(1369, 719);
            this.ipros.Name = "ipros";
            this.ipros.Size = new System.Drawing.Size(0, 46);
            this.ipros.TabIndex = 26;
            // 
            // kpros
            // 
            this.kpros.AutoSize = true;
            this.kpros.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kpros.Location = new System.Drawing.Point(1358, 673);
            this.kpros.Name = "kpros";
            this.kpros.Size = new System.Drawing.Size(0, 46);
            this.kpros.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 760);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 28;
            this.button1.Text = "прервать сортировку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1482, 821);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kpros);
            this.Controls.Add(this.ipros);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1500, 823);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Визуализация сортировок";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer muve;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer up;
        private System.Windows.Forms.Timer down;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Timer laft;
        private System.Windows.Forms.Timer right;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer sortinsert;
        private System.Windows.Forms.Timer chaksvop;
        private System.Windows.Forms.Timer elarm;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer appinsert;
        private System.Windows.Forms.Timer goforword;
        private System.Windows.Forms.Timer gotostart;
        private System.Windows.Forms.Timer godown;
        private System.Windows.Forms.Timer coutindex;
        private System.Windows.Forms.Timer startcort;
        private System.Windows.Forms.Timer countsort;
        private System.Windows.Forms.Timer goinplase;
        private System.Windows.Forms.Timer countsort2out;
        private System.Windows.Forms.Timer countsort2in;
        private System.Windows.Forms.Timer goinplase_2;
        private System.Windows.Forms.Timer elarm_2;
        private System.Windows.Forms.Label ipros;
        private System.Windows.Forms.Label kpros;
        private System.Windows.Forms.Button button1;
    }
}

