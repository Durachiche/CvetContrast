using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<float> someList = new List<float>();
        public int count;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (count != 2)
            {
                if (count == 0) { label1.Text += " " + pictureBox1.BackColor.Name; }
                else { label3.Text += " " + pictureBox1.BackColor.Name; }
                count++;
                someList.Add(100f);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (count != 2)
            {
                MessageBox.Show("Выберите более 1 цвета!", "Exseption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (someList[0] > someList[1])
                    textBox1.Text = Convert.ToString((someList[0] + 0.05f) / (someList[1] + 0.05f));
                else textBox1.Text = Convert.ToString((someList[1] + 0.05f) / (someList[0] + 0.05f));
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (count != 2)
            {
                if (count == 0) { label1.Text += " " + pictureBox2.BackColor.Name; }
                else { label3.Text += " " + pictureBox2.BackColor.Name; }
                someList.Add(21.59f);
                count++;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (count != 2)
            {
                if (count == 0) { label1.Text += " " + pictureBox3.BackColor.Name; }
                else { label3.Text += " " + pictureBox3.BackColor.Name; }
                someList.Add(52.71f);
                count++;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (count != 2)
            {
                if (count == 0) { label1.Text += " " + pictureBox4.BackColor.Name; }
                else { label3.Text += " " + pictureBox4.BackColor.Name; }
                someList.Add(92.78f);
                count++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // comment
            label1.Text = "Первый цвет:";
            label3.Text = "Второй цвет:";
            someList.Clear();
            textBox1.Text = "";
            count = 0;
        }
    }
}
