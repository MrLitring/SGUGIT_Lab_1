using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGUGIT_Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                message_error("Введите число", "Ошибка");
            }

            if (comboBox1.SelectedIndex == -1)
            {
                message_error("Выберите еденицу конвертирования", "Ошибка");
            }

            foreach (Component item in groupBox1.Container.Components)
            {
                if (item is RadioButton)
                {
                    
                }
            }
        }

        private void Converted()
        {
            double ch = Convert.ToDouble(textBox1.Text);
            int key = comboBox1.SelectedIndex;

            switch(key)
            {
                case 0:
                    {

                        break;
                    }
                case 1:
                    {

                        break;
                    }
                case 2:
                    {

                        break;
                    }
                case 3:
                    {

                        break;
                    }
                default:
                    {

                        break;
                    }
            }

            if(radioButton1.Checked)
            {
                label1.Text = Convert.ToDouble(textBox1.Text) + "дюйм(ов)";
            }

        }

        private void message_error(string title = "Титул", string content = "Контент")
        {
            MessageBox.Show(title, content, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }
}
