using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamSpirit_Project1.Properties;

namespace TeamSpirit_Project1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        // string variable for history

        string listHistory;

        // Changing the first player's label name

        string listHistory;

        private void nameBox1_TextChanged_1(object sender, EventArgs e)
        {
            first_player_box.Text = nameBox1.Text;
        }


        // Changing the first player's label name

        private void nameBox2_TextChanged_1(object sender, EventArgs e)
        {
            second_player_box.Text = nameBox2.Text;

        }

        // Creating a function for ForEach radioButtons

        private void button_setup_player1_Click_1(object sender, EventArgs e)
        {
            radioForEach(nameBox1, picture_def_icon, button_setup_player1);
        }

        private void button_setup_player2_Click_1(object sender, EventArgs e)
        {
            radioForEach(nameBox2, pictureBox1, button_setup_player2); // adding the element's name
            radioForEach(nameBox2, pictureBox1, button_setup_player2); 
        }


        private void button_start_Click(object sender, EventArgs e)
        {
            // getting Rounds numbers, if there is text, it will be false

            int numericValue;
            bool isNumber = int.TryParse(Rounds.Text, out numericValue);

            // if first player and second player didnt write the names or didnt select the rounds, there will be an error


            try
            {
                Name playerName = new Name();
                if (string.IsNullOrEmpty(first_player_box.Text) || string.IsNullOrEmpty(second_player_box.Text) || !isNumber || button_setup_player1.Enabled || button_setup_player2.Enabled || Convert.ToInt32(Rounds.Text) <= 4 || Convert.ToInt32(Rounds.Text) >= 31)
                {
                    MessageBox.Show("No name or no rounds error");
                }

                else
                {
                    first_player_box.Text = nameBox1.Text;
                    second_player_box.Text = nameBox2.Text;
                    playerName.name = nameBox1.Text;
                    player_name_text.Text = playerName.nameFunc();
                    // switching buttons
                    button_start.Enabled = false;
                    button_roll.Enabled = true;
                    // adding round
                    count_label.Text = Rounds.Text;
                    firstplayer = !firstplayer; // have to do that in order to display players name correctly and queue too
                }
                    button_start.Enabled = false;
                    button_roll.Enabled = true;
                    count_label.Text = Rounds.Text;
                    firstplayer = !firstplayer; 
                } 
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        int countNumber;
        int secondPlayerCount = 0; // for the official label compare
        int firstPlayerCount = 0; // for the official label compare
        bool firstplayer = true; // is it first player or the second player's 


        int playerWinCount; // for the temporary compare
        int playerWinCount2; // for the temporary compare
        
        int countNumber;
        int secondPlayerCount = 0;
        int firstPlayerCount = 0;
        bool firstplayer = true;


        int playerWinCount; 
        int playerWinCount2; 
        private void button_roll_Click(object sender, EventArgs e)
        {
            countNumber = Convert.ToInt32(count_label.Text);
            whichPlayer(firstplayer, player_name_text, nameBox1, nameBox2, ref countNumber, count_label);

            count_label.Text = countNumber.ToString();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            resetFunc();
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(listHistory))
            {
                MessageBox.Show("No history");
            }
            else
            {
                report.AppendText(listHistory);
            }

        }

        // All functions 


        void whichPlayer(bool player, Control playerNameText, Control nameBox, Control nameboxSecond, ref int rounds, Control countLabel)
        {

            // until round is not 0
            } else{
                report.AppendText(listHistory);
            }

        }        
        void whichPlayer(bool player, Control playerNameText, Control nameBox, Control nameboxSecond, ref int rounds, Control countLabel)
        {

            if (rounds != 0)
            {

                if (player)
                {
                    Name nameClass = new Name();
                    nameClass.name = nameBox.Text;
                    playerNameText.Text = nameClass.nameFunc();
                    Random random = new Random();
                    int number = random.Next(1, 7);
                    switch (number)
                    {
                        case 1:
                            picture_dice.Image = ((System.Drawing.Image)(Resources.Dice1));
                            playerWinCount = 1;
                            break;
                        case 2:
                            picture_dice.Image = ((System.Drawing.Image)(Resources.Dice2));
                            playerWinCount = 2;
                            break;
                        case 3:
                            picture_dice.Image = ((System.Drawing.Image)(Resources.Dice3));
                            playerWinCount = 3;
                            break;
                        case 4:
                            picture_dice.Image = ((System.Drawing.Image)(Resources.Dice4));
                            playerWinCount = 4;
                            break;
                        case 5:
                            picture_dice.Image = ((System.Drawing.Image)(Resources.Dice5));
                            playerWinCount = 5;
                            break;
                        case 6:
                            picture_dice.Image = ((System.Drawing.Image)(Resources.Dice6));
                            playerWinCount = 6;
                            break;

                        default:
                            // code block
                            break;
                    }
                    rounds = rounds - 1;
                    if (playerWinCount > playerWinCount2)
                    {
                        MessageBox.Show(nameBox2.Text + " player won ");
                        listHistory += (";" + nameBox2.Text + "W\n");
                        firstPlayerCount++;
                        label_point_count2.Text = firstPlayerCount.ToString();
                        countLabel.Text = rounds.ToString();
                    }
                    else if (playerWinCount < playerWinCount2)
                    {
                        MessageBox.Show(nameBox1.Text + " player won ");
                        listHistory += (";" + nameBox1.Text + "W\n");
                        secondPlayerCount++;
                        label_point_count.Text = secondPlayerCount.ToString();
                        countLabel.Text = rounds.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Draw");
                        listHistory += (";Draw\n");
                        firstPlayerCount++;
                        secondPlayerCount++;
                        label_point_count.Text = secondPlayerCount.ToString();
                        label_point_count2.Text = firstPlayerCount.ToString();
                        countLabel.Text = rounds.ToString();
                    }
                }
                else
                {
                    Name nameClass = new Name();
                    nameClass.name = nameboxSecond.Text;
                    playerNameText.Text = nameClass.nameFunc();
                    Random random = new Random();
                    int number = random.Next(1, 7);

                    switch (number)
                    {
                        case 1:
                            picture_dice.Image = ((System.Drawing.Image)(Resources.Dice1));
                            playerWinCount2 = 1;
                            break;
                        case 2:
                            picture_dice.Image = ((System.Drawing.Image)(Resources.Dice2));
                            playerWinCount2 = 2;
                            break;
                        case 3:
                            picture_dice.Image = ((System.Drawing.Image)(Resources.Dice3));
                            playerWinCount2 = 3;
                            break;
                        case 4:
                            picture_dice.Image = ((System.Drawing.Image)(Resources.Dice4));
                            playerWinCount2 = 4;
                            break;
                        case 5:
                            picture_dice.Image = ((System.Drawing.Image)(Resources.Dice5));
                            playerWinCount2 = 5;
                            break;
                        case 6:
                            picture_dice.Image = ((System.Drawing.Image)(Resources.Dice6));
                            playerWinCount2 = 6;
                            break;

                        default:
                            // code block

                            break;
                    }
                    label_point_count.Text = secondPlayerCount.ToString();
                }
                firstplayer = !firstplayer;
            }

            else
            {
                if (playerWinCount < playerWinCount2)
                {
                    MessageBox.Show("The game is over, the winner is: " + nameBox1.Text);
                }

                else if (playerWinCount > playerWinCount2)
                {
                    MessageBox.Show("The game is over, the winner is: " + nameBox2.Text);
                }
                else
                {
                    MessageBox.Show("It was DRAW");
                }

            }

        }

        void resetFunc()
        {
            countNumber = 0;
            secondPlayerCount = 0;
            firstPlayerCount = 0;
            firstplayer = true;
            playerWinCount = 0;
            playerWinCount2 = 0;

            Rounds.Text = "";
            nameBox1.Text = "";
            nameBox2.Text = "";
            count_label.Text = "0";
            player_name_text.Text = "FirstPlayer's Turn";
            label_point_count.Text = "0";
            label_point_count2.Text = "0";
            first_player_box.Text = "First Player";
            second_player_box.Text = "Second Player";

            button_roll.Enabled = false;
            button_setup_player1.Enabled = true;
            button_setup_player2.Enabled = true;
            button_reset.Enabled = true;
            button_start.Enabled = true;
            nameBox1.Enabled = true;
            nameBox2.Enabled = true;

            picture_def_icon.Image = ((System.Drawing.Image)(Resources._default));
            pictureBox1.Image = ((System.Drawing.Image)(Resources._default));
            picture_dice.Image = null;

            foreach (Control control in avatar_box.Controls) // Deleting the selected radioButtons
            foreach (Control control in avatar_box.Controls) 
            {
                if (control is System.Windows.Forms.RadioButton)
                {
                    System.Windows.Forms.RadioButton radioButton = (System.Windows.Forms.RadioButton)control;

                    if (radioButton.Checked || !radioButton.Enabled) // 
                    {
                        radioButton.Checked = false; // deactivating the active radioButton
                        radioButton.Enabled = true; // Enabling it
                    if (radioButton.Checked || !radioButton.Enabled) 
                    {
                        radioButton.Checked = false; 
                        radioButton.Enabled = true; 
                    }
                }
            }


        }
        void radioForEach(Control nameBox, PictureBox pictureBox, Control button_setup_player)
        {
            // at first, we are checking if the nameBox is empty or not

            if (string.IsNullOrEmpty(nameBox.Text))
            {
                MessageBox.Show("Player's name is empty");
            }
            else
            {
                foreach (Control control in avatar_box.Controls) // First we are going throught avatar_box div
                foreach (Control control in avatar_box.Controls) 
                {
                    if (control is System.Windows.Forms.RadioButton)
                    {
                        System.Windows.Forms.RadioButton radioButton = (System.Windows.Forms.RadioButton)control;

                        RadioName radioClass = new RadioName();

                        if (radioButton.Checked) // if radio button is active
                        {
                            radioButton.Enabled = false; // deactivating the active icon and setup player button
                        if (radioButton.Checked)
                        {
                            radioButton.Enabled = false;
                            button_setup_player1.Enabled = false;

                            radioClass.radioBtn = radioButton;
                            radioClass.pictureBox = pictureBox;
                            radioClass.radioFunc();
                        }
                    }
                }
                nameBox.Enabled = false; // Deactivating the players textbox
                button_setup_player.Enabled = false; // Deactivating the setup buttons

                foreach (Control control in avatar_box.Controls) // Deleting the selected radioButtons
                nameBox.Enabled = false;
                button_setup_player.Enabled = false;

                foreach (Control control in avatar_box.Controls)
                {
                    if (control is System.Windows.Forms.RadioButton)
                    {
                        System.Windows.Forms.RadioButton radioButton = (System.Windows.Forms.RadioButton)control;

                        if (radioButton.Checked) // 
                        {
                            radioButton.Checked = false;
                        if (radioButton.Checked)
                        {
                            radioButton.Checked = false; 
                        }
                    }
                }

            }





        }

        private void player_name_text_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
