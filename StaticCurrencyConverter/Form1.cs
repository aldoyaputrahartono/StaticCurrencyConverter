using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticCurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox1.Text);
            float conver = (float)i;

            if (comboBox1.SelectedItem == "Rupiah" && comboBox2.SelectedItem == "US Dollar")
                conver = (float)i / 14415;

            else if (comboBox1.SelectedItem == "US Dollar" && comboBox2.SelectedItem == "Rupiah")
                conver = (float)i * 14415;

            else if (comboBox1.SelectedItem == "Rupiah" && comboBox2.SelectedItem == "Euro")
                conver = (float)i / 17045;
            
            else if (comboBox1.SelectedItem == "Euro" && comboBox2.SelectedItem == "Rupiah")
                conver = (float)i * 17045;

            else if (comboBox1.SelectedItem == "Rupiah" && comboBox2.SelectedItem == "Ringgit")
                conver = (float)i / 3474;

            else if (comboBox1.SelectedItem == "Ringgit" && comboBox2.SelectedItem == "Rupiah")
                conver = (float)i * 3474;

            else if (comboBox1.SelectedItem == "Ringgit" && comboBox2.SelectedItem == "US Dollar")
                conver = (float)i / (float)4.15;

            else if (comboBox1.SelectedItem == "US Dollar" && comboBox2.SelectedItem == "Ringgit")
                conver = (float)i * (float)4.15;

            else if (comboBox1.SelectedItem == "Ringgit" && comboBox2.SelectedItem == "Euro")
                conver = (float)i / (float)4.90;

            else if (comboBox1.SelectedItem == "Euro" && comboBox2.SelectedItem == "Ringgit")
                conver = (float)i * (float)4.90;

            else if (comboBox1.SelectedItem == "US Dollar" && comboBox2.SelectedItem == "Euro")
                conver = (float)i / (float)1.18;

            else if (comboBox1.SelectedItem == "Euro" && comboBox2.SelectedItem == "US Dollar")
                conver = (float)i * (float)1.18;

            textBox2.Text = conver.ToString();
        }
    }
}
