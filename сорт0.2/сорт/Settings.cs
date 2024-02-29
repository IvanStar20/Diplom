using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace сорт
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Цвет формы", "Цвет элементов" });
            comboBox1.SelectedIndex = 1;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public Color FormColor { get; set; }
        public Color BlokColor { get; set; }

        public Color TestColor;

        public Form form { get; set; }

        public bool Save = false;

        private void Settings_Load(object sender, EventArgs e)
        {
            pictureBox3.BackColor = FormColor;
            pictureBox2.BackColor = BlokColor;
        }

        private void ColorChec(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "Цвет формы":
                    pictureBox3.BackColor = (sender as Button).BackColor;
                    break;
                case "Цвет элементов":
                    pictureBox2.BackColor = (sender as Button).BackColor;
                    break;
                    
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BlokColor = pictureBox2.BackColor;
            form.BackColor = pictureBox3.BackColor;
            Save = true;
            this.Close();
        }

        public void SelectColor()
        {
            switch (comboBox1.SelectedItem)
            {
                case "Цвет формы":
                    pictureBox3.BackColor = TestColor;
                    break;
                case "Цвет элементов":
                    pictureBox2.BackColor = TestColor;
                    break;

            }
        }

        private void NumericR_ValueChanged(object sender, EventArgs e)
        {
            TestColor = Color.FromArgb((int)NumericR.Value, (int)NumericG.Value, (int)NumericB.Value);
            SelectColor();
        }

        private void NumericG_ValueChanged(object sender, EventArgs e)
        {
            TestColor = Color.FromArgb((int)NumericR.Value, (int)NumericG.Value, (int)NumericB.Value);
            SelectColor();
        }

        private void NumericB_ValueChanged(object sender, EventArgs e)
        {
            TestColor = Color.FromArgb((int)NumericR.Value, (int)NumericG.Value, (int)NumericB.Value);
            SelectColor();
        }
    }
}
