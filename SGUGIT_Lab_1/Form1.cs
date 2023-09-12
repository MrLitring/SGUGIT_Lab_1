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
        private bool isPointInput = false;

        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {

                pointCheck(textBox1.Text);
                if (isPointInput == false)
                {
                    isPointInput = true;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void pointCheck(string value)
        {
            foreach (char elem in value)
            {
                if (elem == '.')
                {
                    if (isPointInput == false)
                    {
                        isPointInput = true;
                        break;
                    }
                    break;
                }
                else
                {
                    isPointInput = false;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                message_error("Введите число", "Ошибка");
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                message_error("Выберите единицу измерения", "Ошибка");
            }
            else
            {
                Converted();
            }

        }

        private void Converted()
        {
            double ch = Convert.ToDouble(textBox1.Text);
            string answer = string.Empty;
            int key = comboBox1.SelectedIndex;

            /*
             * м в м = 1
             * м в фут 1 = 3,28
             * м в км 1 = 0,001
             * м в дюймы 1 = 39,37
            */

            const double ft = 3.28; // Футы 
            //const double km = 0.001; // Километры
            const double dm = 39.37; // Дюймы

            // 
            // Проверка индекса в ComboBox
            //
            switch (key)
            {
                case 1:
                    {
                        ch = ch * 1000;
                        break;
                    }
                case 2:
                    {
                        ch = ch / dm;
                        break;
                    }
                case 3:
                    {
                        ch = ch / ft;
                        break;
                    }
            }


            //
            // Проверка активных RadioButton
            //
            if (radioButton1.Checked)
            {
                answer = (ch).ToString() + " метр(ов)";
            }

            if (radioButton2.Checked)
            {
                answer = (ch * ft).ToString() + " фут(ов)";
            }

            if (radioButton3.Checked)
            {
                answer = (ch / 1000).ToString() + " километр(ов)";
            }

            if (radioButton4.Checked)
            {
                answer = (ch * dm).ToString() + " дюйм(ов)";
            }

            label1.Text = answer;

        }

        private void message_error(string title = "Титул", string content = "Контент")
        {
            MessageBox.Show(title, content, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }
}
