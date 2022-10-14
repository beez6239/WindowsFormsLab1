using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //second default message button
        private void Try_Click(object sender, EventArgs e)    
        {
            MessageBox.Show("Hello, This is the second default message");
        }
        //takes string/text input from the user
        public void text1_TextChanged(object sender, EventArgs e)
        {
            string res = string.Empty;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        //makes the program button visible
        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            comboBox1.Enabled = checkBox2.Checked;
            label2.Visible = checkBox2.Checked;


        }
        //closing the application
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //To view the string input data
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text1.Text , "Your input", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Console.ReadLine();
            
        }
        //first default message button
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the first default message!");
        }
        //dropdown list accessible by index. 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try //exception incase the string is empty
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    this.text1.Clear();
                }
                else
                {
                    if (comboBox1.SelectedIndex == 1)
                    {
                        this.text1.Paste(text1.Text);

                    }
                    else
                    {
                        if (comboBox1.SelectedIndex == 2)
                        {
                            Clipboard.SetText(text1.Text);

                        }
                    }
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please enter a text ", "Empty value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //return the total number of string a user entered 
        private void button5_Click(object sender, EventArgs e)
        {
            int getlength = text1.TextLength;
            
            MessageBox.Show("Total input is: " + getlength);
        }
        //make the textbox visible
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            button4.Visible = checkBox1.Checked;
            text1.Visible = checkBox1.Checked;
        }
        //enable & disable the textbox
        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            button4.Enabled = checkBox3.Checked;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        //enable & disable the program selection
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            button5.Enabled = checkBox4.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
