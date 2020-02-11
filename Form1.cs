using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        String gender;
        private void button1_Click(object sender, EventArgs e)
        {
          if (rbtn1.Checked)
            {
                gender = "Male";
            }
          else if (rbtn2.Checked)
            {
                gender = "Female";
            }
            MessageBox.Show("Student Name: " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + "\n" + "Gender: " + gender + "\n" + "Date of birth:" + " " + comboBox2.SelectedItem + " " + comboBox1.SelectedItem + " " + comboBox3.SelectedItem + "\n" + "Program: " + " " + comboBox4.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int day = 1; day <= 31; day++)
            {
                comboBox1.Items.Add(day);
                comboBox1.Text = "-Day-";
            }
            for (int year = 1900; year <= 2020; year++)
            {
                comboBox3.Items.Add(year);
                comboBox3.Text = "-Year-";
            }
            String[] months_array = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            foreach (String month in months_array)
            {
                comboBox2.Items.Add(month);
                comboBox2.Text = "-Month-";
            }

            ArrayList programs = new ArrayList();

            programs.Add("Bachelor of Science in Computer Science");
            programs.Add("Bachelor of Science in Information Technology");
            programs.Add("Bachelor of Science in Information Systems");
            programs.Add("Bachelor of Science in Computer Engineering");

            foreach (String program in programs)
            {
                comboBox4.Items.Add(program);
                comboBox4.Text = "-Programs-";
            }


        }
      
        }
    }

