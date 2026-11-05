using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamSpirit_Project1.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TeamSpirit_Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void report_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void nameBox1_TextChanged(object sender, EventArgs e)
        {
            first_player_box.Text = nameBox1.Text;
        }

        private void nameBox2_TextChanged(object sender, EventArgs e)
        {
            second_player_box.Text = nameBox2.Text;

        }

        //private void nameBox1_Entered(object sender, EventArgs e)
        //{
        //    second_player_box.Text = nameBox2.Text;

        //}

        private void button_setup_player1_Click(object sender, EventArgs e)
        {
            foreach (Control control in avatar_box.Controls)
            {
                if (control is System.Windows.Forms.RadioButton)
                {
                    System.Windows.Forms.RadioButton radioButton = (System.Windows.Forms.RadioButton)control;

                    if (radioButton.Checked)
                    {
                        MessageBox.Show("Selected: " + radioButton.Name);
                        radioButton.Enabled = false;
                        button_setup_player1.Enabled = false;
                        Image myimage = new Bitmap(@"C:\Users\User\TeamSpirit_Project1\1.png");
                        first_player_box.BackgroundImage = myimage;
                        //first_player_box.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_lion.Image")));
                        //first_player_box.BackgroundImage = global::TeamSpirit_Project1.Properties.Resources.("picture_lion.Image");
                    }
                }
            }

        }


        private void button_setup_player2_Click(object sender, EventArgs e)
        {
            foreach (Control control in avatar_box.Controls)
            {
                if (control is System.Windows.Forms.RadioButton)
                {
                    System.Windows.Forms.RadioButton radioButton = (System.Windows.Forms.RadioButton)control;

                    if (radioButton.Checked)
                    {
                        MessageBox.Show("Selected: " + radioButton.Name);
                        radioButton.Enabled = false;
                        button_setup_player2.Enabled = false;
                        Image myimage = new Bitmap(@"C:\Users\User\TeamSpirit_Project1\2.png");
                        second_player_box.BackgroundImage = myimage;

                    }
                }
            }
        }

        

        private void buttonlion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void picture_lion_Click(object sender, EventArgs e)
        {

        }

        
    }
}
