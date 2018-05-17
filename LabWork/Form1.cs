using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxColor.Items.AddRange(Enum.GetNames(typeof(KnownColor)));
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Вариант №2\n Шигин Александр", "О проекте", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Выполнить Выход?", "Завершение работы", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton_add.Checked)
            {
                comboBox1.Items.Add(textBox_newText.Text);
                textBox_newText.Text = "";
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            } else if (radioButton_del.Checked)
            {
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            } else
            {
                comboBox1.Items.Clear();
                comboBox1.Text = "";
            }
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            String NameColor = comboBoxColor.SelectedItem.ToString();
            comboBox1.BackColor = Color.FromName(NameColor);
            comboBox1.ForeColor = Color.FromArgb(comboBox1.BackColor.ToArgb() ^ 0xffffff);
            this.Text = "Лабораторная работа [" + NameColor + "]";
        }


        private void comboBoxColor_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);

                g.FillRectangle(new SolidBrush(Color.White), rect.X, rect.Y, rect.Width, rect.Height);
                g.DrawString(n, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, rect.X + 20, rect.Top);
                g.FillRectangle(b, rect.X, rect.Y, 20, 20);
            }
        }

        private void radioButton_ChandeColor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_ChandeColorOn.Checked)
            {
                comboBoxColor.Enabled = true;
            } else
            {
                comboBoxColor.Enabled = false;
            }
        }
    }
}
