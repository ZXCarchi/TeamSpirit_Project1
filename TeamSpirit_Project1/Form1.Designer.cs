namespace TeamSpirit_Project1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.initializations_box = new System.Windows.Forms.GroupBox();
            this.nameBox2 = new System.Windows.Forms.TextBox();
            this.nameBox1 = new System.Windows.Forms.TextBox();
            this.playerlabel2 = new System.Windows.Forms.Label();
            this.playerlabel1 = new System.Windows.Forms.Label();
            this.Rounds = new System.Windows.Forms.DomainUpDown();
            this.Round_label = new System.Windows.Forms.Label();
            this.avatar_box = new System.Windows.Forms.GroupBox();
            this.buttonsmurf = new System.Windows.Forms.RadioButton();
            this.buttonbird = new System.Windows.Forms.RadioButton();
            this.buttonshrek = new System.Windows.Forms.RadioButton();
            this.buttonlion = new System.Windows.Forms.RadioButton();
            this.picture_smurf = new System.Windows.Forms.PictureBox();
            this.picture_bird = new System.Windows.Forms.PictureBox();
            this.picture_shrek = new System.Windows.Forms.PictureBox();
            this.picture_lion = new System.Windows.Forms.PictureBox();
            this.first_player_box = new System.Windows.Forms.GroupBox();
            this.label_point_count = new System.Windows.Forms.Label();
            this.label_point = new System.Windows.Forms.Label();
            this.picture_def_icon = new System.Windows.Forms.PictureBox();
            this.second_player_box = new System.Windows.Forms.GroupBox();
            this.label_point2 = new System.Windows.Forms.Label();
            this.label_point_count2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_setup_player1 = new System.Windows.Forms.Button();
            this.button_setup_player2 = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.label_report = new System.Windows.Forms.Label();
            this.button_result = new System.Windows.Forms.Button();
            this.action_box = new System.Windows.Forms.GroupBox();
            this.picture_dice = new System.Windows.Forms.PictureBox();
            this.button_roll = new System.Windows.Forms.Button();
            this.player_name_text = new System.Windows.Forms.TextBox();
            this.count_label = new System.Windows.Forms.Label();
            this.label_round_action = new System.Windows.Forms.Label();
            this.report = new System.Windows.Forms.ListBox();
            this.initializations_box.SuspendLayout();
            this.avatar_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_smurf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_shrek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_lion)).BeginInit();
            this.first_player_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_def_icon)).BeginInit();
            this.second_player_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.action_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_dice)).BeginInit();
            this.SuspendLayout();
            // 
            // initializations_box
            // 
            this.initializations_box.Controls.Add(this.nameBox2);
            this.initializations_box.Controls.Add(this.nameBox1);
            this.initializations_box.Controls.Add(this.playerlabel2);
            this.initializations_box.Controls.Add(this.playerlabel1);
            this.initializations_box.Controls.Add(this.Rounds);
            this.initializations_box.Controls.Add(this.Round_label);
            this.initializations_box.Location = new System.Drawing.Point(42, 64);
            this.initializations_box.Margin = new System.Windows.Forms.Padding(2);
            this.initializations_box.Name = "initializations_box";
            this.initializations_box.Padding = new System.Windows.Forms.Padding(2);
            this.initializations_box.Size = new System.Drawing.Size(279, 138);
            this.initializations_box.TabIndex = 0;
            this.initializations_box.TabStop = false;
            this.initializations_box.Text = "Initializations";
            // 
            // nameBox2
            // 
            this.nameBox2.Location = new System.Drawing.Point(134, 86);
            this.nameBox2.Margin = new System.Windows.Forms.Padding(2);
            this.nameBox2.Name = "nameBox2";
            this.nameBox2.Size = new System.Drawing.Size(117, 20);
            this.nameBox2.TabIndex = 5;
            this.nameBox2.TextChanged += new System.EventHandler(this.nameBox2_TextChanged_1);
            // 
            // nameBox1
            // 
            this.nameBox1.Location = new System.Drawing.Point(134, 57);
            this.nameBox1.Margin = new System.Windows.Forms.Padding(2);
            this.nameBox1.Name = "nameBox1";
            this.nameBox1.Size = new System.Drawing.Size(117, 20);
            this.nameBox1.TabIndex = 4;
            this.nameBox1.TextChanged += new System.EventHandler(this.nameBox1_TextChanged_1);
            // 
            // playerlabel2
            // 
            this.playerlabel2.AutoSize = true;
            this.playerlabel2.Location = new System.Drawing.Point(4, 90);
            this.playerlabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerlabel2.Name = "playerlabel2";
            this.playerlabel2.Size = new System.Drawing.Size(107, 13);
            this.playerlabel2.TabIndex = 3;
            this.playerlabel2.Text = "Second Player Name";
            // 
            // playerlabel1
            // 
            this.playerlabel1.AutoSize = true;
            this.playerlabel1.Location = new System.Drawing.Point(4, 60);
            this.playerlabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerlabel1.Name = "playerlabel1";
            this.playerlabel1.Size = new System.Drawing.Size(89, 13);
            this.playerlabel1.TabIndex = 2;
            this.playerlabel1.Text = "First Player Name";
            // 
            // Rounds
            // 
            this.Rounds.Location = new System.Drawing.Point(102, 30);
            this.Rounds.Margin = new System.Windows.Forms.Padding(2);
            this.Rounds.Name = "Rounds";
            this.Rounds.Size = new System.Drawing.Size(39, 20);
            this.Rounds.TabIndex = 1;
            // 
            // Round_label
            // 
            this.Round_label.AutoSize = true;
            this.Round_label.Location = new System.Drawing.Point(4, 30);
            this.Round_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Round_label.Name = "Round_label";
            this.Round_label.Size = new System.Drawing.Size(44, 13);
            this.Round_label.TabIndex = 0;
            this.Round_label.Text = "Rounds";
            // 
            // avatar_box
            //
            this.avatar_box.Controls.Add(this.buttonsmurf);
            this.avatar_box.Controls.Add(this.buttonbird);
            this.avatar_box.Controls.Add(this.buttonshrek);
            this.avatar_box.Controls.Add(this.buttonlion);
            this.avatar_box.Controls.Add(this.picture_smurf);
            this.avatar_box.Controls.Add(this.picture_bird);
            this.avatar_box.Controls.Add(this.picture_shrek);
            this.avatar_box.Controls.Add(this.picture_lion);
            this.avatar_box.Location = new System.Drawing.Point(335, 64);
            this.avatar_box.Margin = new System.Windows.Forms.Padding(2);
            this.avatar_box.Name = "avatar_box";
            this.avatar_box.Padding = new System.Windows.Forms.Padding(2);
            this.avatar_box.Size = new System.Drawing.Size(142, 277);
            this.avatar_box.TabIndex = 1;
            this.avatar_box.TabStop = false;
            this.avatar_box.Text = "Avatars";
            // 
            // buttonsmurf
            // 
            this.buttonsmurf.AutoSize = true;
            this.buttonsmurf.Location = new System.Drawing.Point(23, 232);
            this.buttonsmurf.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsmurf.Name = "buttonsmurf";
            this.buttonsmurf.Size = new System.Drawing.Size(14, 13);
            this.buttonsmurf.TabIndex = 7;
            this.buttonsmurf.TabStop = true;
            this.buttonsmurf.UseVisualStyleBackColor = true;
            // 
            // buttonbird
            // 
            this.buttonbird.AutoSize = true;
            this.buttonbird.Location = new System.Drawing.Point(23, 167);
            this.buttonbird.Margin = new System.Windows.Forms.Padding(2);
            this.buttonbird.Name = "buttonbird";
            this.buttonbird.Size = new System.Drawing.Size(14, 13);
            this.buttonbird.TabIndex = 6;
            this.buttonbird.TabStop = true;
            this.buttonbird.UseVisualStyleBackColor = true;
            // 
            // buttonshrek
            // 
            this.buttonshrek.AutoSize = true;
            this.buttonshrek.Location = new System.Drawing.Point(23, 107);
            this.buttonshrek.Margin = new System.Windows.Forms.Padding(2);
            this.buttonshrek.Name = "buttonshrek";
            this.buttonshrek.Size = new System.Drawing.Size(14, 13);
            this.buttonshrek.TabIndex = 5;
            this.buttonshrek.TabStop = true;
            this.buttonshrek.UseVisualStyleBackColor = true;
            // 
            // buttonlion
            // 
            this.buttonlion.AutoSize = true;
            this.buttonlion.Location = new System.Drawing.Point(23, 41);
            this.buttonlion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonlion.Name = "buttonlion";
            this.buttonlion.Size = new System.Drawing.Size(14, 13);
            this.buttonlion.TabIndex = 4;
            this.buttonlion.UseVisualStyleBackColor = true;
            // 
            // picture_smurf
            // 
            this.picture_smurf.Image = global::TeamSpirit_Project1.Properties.Resources.Icon04;
            this.picture_smurf.Location = new System.Drawing.Point(69, 218);
            this.picture_smurf.Margin = new System.Windows.Forms.Padding(2);
            this.picture_smurf.Name = "picture_smurf";
            this.picture_smurf.Size = new System.Drawing.Size(54, 44);
            this.picture_smurf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_smurf.TabIndex = 3;
            this.picture_smurf.TabStop = false;
            // 
            // picture_bird
            // 
            this.picture_bird.Image = global::TeamSpirit_Project1.Properties.Resources.Icon03;
            this.picture_bird.Location = new System.Drawing.Point(69, 153);
            this.picture_bird.Margin = new System.Windows.Forms.Padding(2);
            this.picture_bird.Name = "picture_bird";
            this.picture_bird.Size = new System.Drawing.Size(54, 44);
            this.picture_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_bird.TabIndex = 2;
            this.picture_bird.TabStop = false;
            // 
            // picture_shrek
            // 
            this.picture_shrek.Image = global::TeamSpirit_Project1.Properties.Resources.Icon02;
            this.picture_shrek.Location = new System.Drawing.Point(69, 90);
            this.picture_shrek.Margin = new System.Windows.Forms.Padding(2);
            this.picture_shrek.Name = "picture_shrek";
            this.picture_shrek.Size = new System.Drawing.Size(54, 44);
            this.picture_shrek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_shrek.TabIndex = 1;
            this.picture_shrek.TabStop = false;
            // 
            // picture_lion
            // 
            this.picture_lion.Image = global::TeamSpirit_Project1.Properties.Resources.Icon01;
            this.picture_lion.Location = new System.Drawing.Point(69, 23);
            this.picture_lion.Margin = new System.Windows.Forms.Padding(2);
            this.picture_lion.Name = "picture_lion";
            this.picture_lion.Size = new System.Drawing.Size(54, 51);
            this.picture_lion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_lion.TabIndex = 0;
            this.picture_lion.TabStop = false;
            // 
            // first_player_box
            // 
            this.first_player_box.Controls.Add(this.label_point_count);
            this.first_player_box.Controls.Add(this.label_point);
            this.first_player_box.Controls.Add(this.picture_def_icon);
            this.first_player_box.Location = new System.Drawing.Point(487, 64);
            this.first_player_box.Margin = new System.Windows.Forms.Padding(2);
            this.first_player_box.Name = "first_player_box";
            this.first_player_box.Padding = new System.Windows.Forms.Padding(2);
            this.first_player_box.Size = new System.Drawing.Size(201, 146);
            this.first_player_box.TabIndex = 2;
            this.first_player_box.TabStop = false;
            this.first_player_box.Text = "First Player";
            // 
            // label_point_count
            // 
            this.label_point_count.AutoSize = true;
            this.label_point_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_point_count.Location = new System.Drawing.Point(123, 61);
            this.label_point_count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_point_count.Name = "label_point_count";
            this.label_point_count.Size = new System.Drawing.Size(57, 63);
            this.label_point_count.TabIndex = 2;
            this.label_point_count.Text = "0";
            // 
            // label_point
            // 
            this.label_point.AutoSize = true;
            this.label_point.Location = new System.Drawing.Point(120, 30);
            this.label_point.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_point.Name = "label_point";
            this.label_point.Size = new System.Drawing.Size(31, 13);
            this.label_point.TabIndex = 1;
            this.label_point.Text = "Point";
            // 
            // picture_def_icon
            // 
            this.picture_def_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_def_icon.Image = global::TeamSpirit_Project1.Properties.Resources._default;
            this.picture_def_icon.Location = new System.Drawing.Point(13, 31);
            this.picture_def_icon.Margin = new System.Windows.Forms.Padding(2);
            this.picture_def_icon.Name = "picture_def_icon";
            this.picture_def_icon.Size = new System.Drawing.Size(93, 89);
            this.picture_def_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_def_icon.TabIndex = 0;
            this.picture_def_icon.TabStop = false;
            // 
            // second_player_box
            // 
            this.second_player_box.Controls.Add(this.label_point2);
            this.second_player_box.Controls.Add(this.label_point_count2);
            this.second_player_box.Controls.Add(this.pictureBox1);
            this.second_player_box.Location = new System.Drawing.Point(487, 245);
            this.second_player_box.Margin = new System.Windows.Forms.Padding(2);
            this.second_player_box.Name = "second_player_box";
            this.second_player_box.Padding = new System.Windows.Forms.Padding(2);
            this.second_player_box.Size = new System.Drawing.Size(201, 146);
            this.second_player_box.TabIndex = 3;
            this.second_player_box.TabStop = false;
            this.second_player_box.Text = "Second Player";
            // 
            // label_point2
            // 
            this.label_point2.AutoSize = true;
            this.label_point2.Location = new System.Drawing.Point(120, 31);
            this.label_point2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_point2.Name = "label_point2";
            this.label_point2.Size = new System.Drawing.Size(31, 13);
            this.label_point2.TabIndex = 4;
            this.label_point2.Text = "Point";
            // 
            // label_point_count2
            // 
            this.label_point_count2.AutoSize = true;
            this.label_point_count2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_point_count2.Location = new System.Drawing.Point(123, 60);
            this.label_point_count2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_point_count2.Name = "label_point_count2";
            this.label_point_count2.Size = new System.Drawing.Size(57, 63);
            this.label_point_count2.TabIndex = 3;
            this.label_point_count2.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::TeamSpirit_Project1.Properties.Resources._default;
            this.pictureBox1.Location = new System.Drawing.Point(13, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button_setup_player1
            // 
            this.button_setup_player1.Location = new System.Drawing.Point(335, 356);
            this.button_setup_player1.Margin = new System.Windows.Forms.Padding(2);
            this.button_setup_player1.Name = "button_setup_player1";
            this.button_setup_player1.Size = new System.Drawing.Size(142, 36);
            this.button_setup_player1.TabIndex = 4;
            this.button_setup_player1.Text = "Set Up First Player";
            this.button_setup_player1.UseVisualStyleBackColor = true;
            this.button_setup_player1.Click += new System.EventHandler(this.button_setup_player1_Click_1);
            // 
            // button_setup_player2
            // 
            this.button_setup_player2.Location = new System.Drawing.Point(335, 403);
            this.button_setup_player2.Margin = new System.Windows.Forms.Padding(2);
            this.button_setup_player2.Name = "button_setup_player2";
            this.button_setup_player2.Size = new System.Drawing.Size(142, 36);
            this.button_setup_player2.TabIndex = 5;
            this.button_setup_player2.Text = "Set Up Second Player";
            this.button_setup_player2.UseVisualStyleBackColor = true;
            this.button_setup_player2.Click += new System.EventHandler(this.button_setup_player2_Click_1);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(335, 453);
            this.button_reset.Margin = new System.Windows.Forms.Padding(2);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(142, 36);
            this.button_reset.TabIndex = 6;
            this.button_reset.Text = "RESET ALL";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(487, 403);
            this.button_start.Margin = new System.Windows.Forms.Padding(2);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(201, 86);
            this.button_start.TabIndex = 7;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_report
            // 
            this.label_report.AutoSize = true;
            this.label_report.Location = new System.Drawing.Point(711, 64);
            this.label_report.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_report.Name = "label_report";
            this.label_report.Size = new System.Drawing.Size(39, 13);
            this.label_report.TabIndex = 8;
            this.label_report.Text = "Report";
            // 
            // button_result
            // 
            this.button_result.Location = new System.Drawing.Point(703, 403);
            this.button_result.Margin = new System.Windows.Forms.Padding(2);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(201, 86);
            this.button_result.TabIndex = 10;
            this.button_result.Text = "SHOW RESULT";
            this.button_result.UseVisualStyleBackColor = true;
            this.button_result.Click += new System.EventHandler(this.button_result_Click);
            // 
            // action_box
            // 
            this.action_box.Controls.Add(this.picture_dice);
            this.action_box.Controls.Add(this.button_roll);
            this.action_box.Controls.Add(this.player_name_text);
            this.action_box.Controls.Add(this.count_label);
            this.action_box.Controls.Add(this.label_round_action);
            this.action_box.Location = new System.Drawing.Point(42, 218);
            this.action_box.Margin = new System.Windows.Forms.Padding(2);
            this.action_box.Name = "action_box";
            this.action_box.Padding = new System.Windows.Forms.Padding(2);
            this.action_box.Size = new System.Drawing.Size(279, 271);
            this.action_box.TabIndex = 11;
            this.action_box.TabStop = false;
            this.action_box.Text = "Action";
            // 
            // picture_dice
            // 
            this.picture_dice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picture_dice.Location = new System.Drawing.Point(89, 170);
            this.picture_dice.Margin = new System.Windows.Forms.Padding(2);
            this.picture_dice.Name = "picture_dice";
            this.picture_dice.Size = new System.Drawing.Size(97, 84);
            this.picture_dice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_dice.TabIndex = 4;
            this.picture_dice.TabStop = false;
            // 
            // button_roll
            // 
            this.button_roll.Enabled = false;
            this.button_roll.Location = new System.Drawing.Point(5, 130);
            this.button_roll.Margin = new System.Windows.Forms.Padding(2);
            this.button_roll.Name = "button_roll";
            this.button_roll.Size = new System.Drawing.Size(268, 23);
            this.button_roll.TabIndex = 3;
            this.button_roll.Text = "ROLL";
            this.button_roll.UseVisualStyleBackColor = true;
            this.button_roll.Click += new System.EventHandler(this.button_roll_Click);
            // 
            // player_name_text
            // 
            this.player_name_text.BackColor = System.Drawing.Color.SeaGreen;
            this.player_name_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player_name_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player_name_text.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.player_name_text.Location = new System.Drawing.Point(7, 100);
            this.player_name_text.Margin = new System.Windows.Forms.Padding(2);
            this.player_name_text.Name = "player_name_text";
            this.player_name_text.Size = new System.Drawing.Size(172, 26);
            this.player_name_text.TabIndex = 2;
            this.player_name_text.Text = "FirstPlayer\'s Turn";
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.Location = new System.Drawing.Point(166, 30);
            this.count_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(13, 13);
            this.count_label.TabIndex = 1;
            this.count_label.Text = "0";
            // 
            // label_round_action
            // 
            this.label_round_action.AutoSize = true;
            this.label_round_action.Location = new System.Drawing.Point(4, 31);
            this.label_round_action.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_round_action.Name = "label_round_action";
            this.label_round_action.Size = new System.Drawing.Size(39, 13);
            this.label_round_action.TabIndex = 0;
            this.label_round_action.Text = "Round";
            // 
            // report
            // 
            this.report.FormattingEnabled = true;
            this.report.Location = new System.Drawing.Point(703, 79);
            this.report.Margin = new System.Windows.Forms.Padding(2);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(203, 316);
            this.report.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 668);
            this.Controls.Add(this.action_box);
            this.Controls.Add(this.button_result);
            this.Controls.Add(this.report);
            this.Controls.Add(this.label_report);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_setup_player2);
            this.Controls.Add(this.button_setup_player1);
            this.Controls.Add(this.second_player_box);
            this.Controls.Add(this.first_player_box);
            this.Controls.Add(this.avatar_box);
            this.Controls.Add(this.initializations_box);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.initializations_box.ResumeLayout(false);
            this.initializations_box.PerformLayout();
            this.avatar_box.ResumeLayout(false);
            this.avatar_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_smurf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_shrek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_lion)).EndInit();
            this.first_player_box.ResumeLayout(false);
            this.first_player_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_def_icon)).EndInit();
            this.second_player_box.ResumeLayout(false);
            this.second_player_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.action_box.ResumeLayout(false);
            this.action_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_dice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox initializations_box;
        private System.Windows.Forms.Label playerlabel1;
        private System.Windows.Forms.DomainUpDown Rounds;
        private System.Windows.Forms.Label Round_label;
        private System.Windows.Forms.Label playerlabel2;
        private System.Windows.Forms.TextBox nameBox2;
        private System.Windows.Forms.TextBox nameBox1;
        private System.Windows.Forms.GroupBox avatar_box;
        private System.Windows.Forms.PictureBox picture_smurf;
        private System.Windows.Forms.PictureBox picture_bird;
        private System.Windows.Forms.PictureBox picture_shrek;
        private System.Windows.Forms.PictureBox picture_lion;
        private System.Windows.Forms.RadioButton buttonsmurf;
        private System.Windows.Forms.RadioButton buttonbird;
        private System.Windows.Forms.RadioButton buttonshrek;
        private System.Windows.Forms.RadioButton buttonlion;
        private System.Windows.Forms.GroupBox first_player_box;
        private System.Windows.Forms.GroupBox second_player_box;
        private System.Windows.Forms.Button button_setup_player1;
        private System.Windows.Forms.Button button_setup_player2;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_report;
        private System.Windows.Forms.Button button_result;
        private System.Windows.Forms.GroupBox action_box;
        private System.Windows.Forms.Label count_label;
        private System.Windows.Forms.Label label_round_action;
        private System.Windows.Forms.TextBox player_name_text;
        private System.Windows.Forms.ListBox report;
        private System.Windows.Forms.PictureBox picture_dice;
        private System.Windows.Forms.Button button_roll;
        private System.Windows.Forms.Label label_point;
        private System.Windows.Forms.PictureBox picture_def_icon;
        private System.Windows.Forms.Label label_point_count;
        private System.Windows.Forms.Label label_point_count2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_point2;
    }
}