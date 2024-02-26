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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Фон формы", "Фон элементов" });
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        public Color FormColor { get; set; }
        public Color BlokColor { get; set; }

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
                case "Фон формы":
                    pictureBox3.BackColor = (sender as Button).BackColor;
                    break;
                case "Фон элементов":
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
    }
}
