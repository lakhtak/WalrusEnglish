namespace WalrusEnglishGui
{
    partial class NewGameDialog
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
            this.panelPlayerNumber = new System.Windows.Forms.Panel();
            this.pictureBoxPlayer2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer1 = new System.Windows.Forms.PictureBox();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.radioTwoPlayers = new System.Windows.Forms.RadioButton();
            this.radioOnePlayer = new System.Windows.Forms.RadioButton();
            this.textBoxPlayer1Name = new System.Windows.Forms.TextBox();
            this.labelPlayerTwo = new System.Windows.Forms.Label();
            this.textBoxPlayer2Name = new System.Windows.Forms.TextBox();
            this.labelPlayerOne = new System.Windows.Forms.Label();
            this.panelPointsToWin = new System.Windows.Forms.Panel();
            this.labelPointsToWin = new System.Windows.Forms.Label();
            this.radioPoints3 = new System.Windows.Forms.RadioButton();
            this.radioPoints2 = new System.Windows.Forms.RadioButton();
            this.radioPoints1 = new System.Windows.Forms.RadioButton();
            this.panelFailsToLose = new System.Windows.Forms.Panel();
            this.labelFailCount = new System.Windows.Forms.Label();
            this.radioFails3 = new System.Windows.Forms.RadioButton();
            this.radioFails2 = new System.Windows.Forms.RadioButton();
            this.radioFails1 = new System.Windows.Forms.RadioButton();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCance = new System.Windows.Forms.Button();
            this.panelTranslation = new System.Windows.Forms.Panel();
            this.labelTranslation = new System.Windows.Forms.Label();
            this.radioRussianEnglish = new System.Windows.Forms.RadioButton();
            this.radioEnglishRussian = new System.Windows.Forms.RadioButton();
            this.comboBoxDictionary = new System.Windows.Forms.ComboBox();
            this.labelDictionary = new System.Windows.Forms.Label();
            this.panelPlayerNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).BeginInit();
            this.panelPointsToWin.SuspendLayout();
            this.panelFailsToLose.SuspendLayout();
            this.panelTranslation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPlayerNumber
            // 
            this.panelPlayerNumber.BackColor = System.Drawing.Color.Transparent;
            this.panelPlayerNumber.Controls.Add(this.pictureBoxPlayer2);
            this.panelPlayerNumber.Controls.Add(this.pictureBoxPlayer1);
            this.panelPlayerNumber.Controls.Add(this.labelPlayers);
            this.panelPlayerNumber.Controls.Add(this.radioTwoPlayers);
            this.panelPlayerNumber.Controls.Add(this.radioOnePlayer);
            this.panelPlayerNumber.Controls.Add(this.textBoxPlayer1Name);
            this.panelPlayerNumber.Controls.Add(this.labelPlayerTwo);
            this.panelPlayerNumber.Controls.Add(this.textBoxPlayer2Name);
            this.panelPlayerNumber.Controls.Add(this.labelPlayerOne);
            this.panelPlayerNumber.Location = new System.Drawing.Point(12, 14);
            this.panelPlayerNumber.Name = "panelPlayerNumber";
            this.panelPlayerNumber.Size = new System.Drawing.Size(735, 165);
            this.panelPlayerNumber.TabIndex = 0;
            this.panelPlayerNumber.Tag = "";
            // 
            // pictureBoxPlayer2
            // 
            this.pictureBoxPlayer2.Image = global::WalrusEnglishGui.Properties.Resources.avatar01;
            this.pictureBoxPlayer2.Location = new System.Drawing.Point(568, 5);
            this.pictureBoxPlayer2.Name = "pictureBoxPlayer2";
            this.pictureBoxPlayer2.Size = new System.Drawing.Size(145, 100);
            this.pictureBoxPlayer2.TabIndex = 7;
            this.pictureBoxPlayer2.TabStop = false;
            this.pictureBoxPlayer2.Click += new System.EventHandler(this.pictureBoxPlayer2_Click);
            // 
            // pictureBoxPlayer1
            // 
            this.pictureBoxPlayer1.Image = global::WalrusEnglishGui.Properties.Resources.avatar01;
            this.pictureBoxPlayer1.Location = new System.Drawing.Point(287, 5);
            this.pictureBoxPlayer1.Name = "pictureBoxPlayer1";
            this.pictureBoxPlayer1.Size = new System.Drawing.Size(145, 100);
            this.pictureBoxPlayer1.TabIndex = 6;
            this.pictureBoxPlayer1.TabStop = false;
            this.pictureBoxPlayer1.Click += new System.EventHandler(this.pictureBoxPlayer1_Click);
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayers.Location = new System.Drawing.Point(9, 5);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(90, 25);
            this.labelPlayers.TabIndex = 2;
            this.labelPlayers.Text = "Players:";
            // 
            // radioTwoPlayers
            // 
            this.radioTwoPlayers.AutoSize = true;
            this.radioTwoPlayers.Checked = true;
            this.radioTwoPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioTwoPlayers.Location = new System.Drawing.Point(14, 68);
            this.radioTwoPlayers.Name = "radioTwoPlayers";
            this.radioTwoPlayers.Size = new System.Drawing.Size(146, 29);
            this.radioTwoPlayers.TabIndex = 1;
            this.radioTwoPlayers.TabStop = true;
            this.radioTwoPlayers.Text = "Two players";
            this.radioTwoPlayers.UseVisualStyleBackColor = true;
            // 
            // radioOnePlayer
            // 
            this.radioOnePlayer.AutoSize = true;
            this.radioOnePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioOnePlayer.Location = new System.Drawing.Point(14, 33);
            this.radioOnePlayer.Name = "radioOnePlayer";
            this.radioOnePlayer.Size = new System.Drawing.Size(135, 29);
            this.radioOnePlayer.TabIndex = 0;
            this.radioOnePlayer.TabStop = true;
            this.radioOnePlayer.Text = "One player";
            this.radioOnePlayer.UseVisualStyleBackColor = true;
            this.radioOnePlayer.CheckedChanged += new System.EventHandler(this.radioOnePlayer_CheckedChanged);
            // 
            // textBoxPlayer1Name
            // 
            this.textBoxPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPlayer1Name.Location = new System.Drawing.Point(166, 122);
            this.textBoxPlayer1Name.MaxLength = 20;
            this.textBoxPlayer1Name.Name = "textBoxPlayer1Name";
            this.textBoxPlayer1Name.Size = new System.Drawing.Size(266, 31);
            this.textBoxPlayer1Name.TabIndex = 3;
            // 
            // labelPlayerTwo
            // 
            this.labelPlayerTwo.AutoSize = true;
            this.labelPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayerTwo.Location = new System.Drawing.Point(445, 5);
            this.labelPlayerTwo.Name = "labelPlayerTwo";
            this.labelPlayerTwo.Size = new System.Drawing.Size(118, 25);
            this.labelPlayerTwo.TabIndex = 4;
            this.labelPlayerTwo.Text = "Player two:";
            // 
            // textBoxPlayer2Name
            // 
            this.textBoxPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPlayer2Name.Location = new System.Drawing.Point(447, 122);
            this.textBoxPlayer2Name.MaxLength = 20;
            this.textBoxPlayer2Name.Name = "textBoxPlayer2Name";
            this.textBoxPlayer2Name.Size = new System.Drawing.Size(266, 31);
            this.textBoxPlayer2Name.TabIndex = 5;
            // 
            // labelPlayerOne
            // 
            this.labelPlayerOne.AutoSize = true;
            this.labelPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayerOne.Location = new System.Drawing.Point(161, 5);
            this.labelPlayerOne.Name = "labelPlayerOne";
            this.labelPlayerOne.Size = new System.Drawing.Size(121, 25);
            this.labelPlayerOne.TabIndex = 2;
            this.labelPlayerOne.Text = "Player one:";
            // 
            // panelPointsToWin
            // 
            this.panelPointsToWin.BackColor = System.Drawing.Color.Transparent;
            this.panelPointsToWin.Controls.Add(this.labelPointsToWin);
            this.panelPointsToWin.Controls.Add(this.radioPoints3);
            this.panelPointsToWin.Controls.Add(this.radioPoints2);
            this.panelPointsToWin.Controls.Add(this.radioPoints1);
            this.panelPointsToWin.Location = new System.Drawing.Point(12, 206);
            this.panelPointsToWin.Name = "panelPointsToWin";
            this.panelPointsToWin.Size = new System.Drawing.Size(149, 147);
            this.panelPointsToWin.TabIndex = 1;
            // 
            // labelPointsToWin
            // 
            this.labelPointsToWin.AutoSize = true;
            this.labelPointsToWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPointsToWin.Location = new System.Drawing.Point(5, 8);
            this.labelPointsToWin.Name = "labelPointsToWin";
            this.labelPointsToWin.Size = new System.Drawing.Size(140, 25);
            this.labelPointsToWin.TabIndex = 3;
            this.labelPointsToWin.Text = "Points to win:";
            // 
            // radioPoints3
            // 
            this.radioPoints3.AutoSize = true;
            this.radioPoints3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioPoints3.Location = new System.Drawing.Point(10, 108);
            this.radioPoints3.Name = "radioPoints3";
            this.radioPoints3.Size = new System.Drawing.Size(118, 29);
            this.radioPoints3.TabIndex = 2;
            this.radioPoints3.Text = "15 points";
            this.radioPoints3.UseVisualStyleBackColor = true;
            // 
            // radioPoints2
            // 
            this.radioPoints2.AutoSize = true;
            this.radioPoints2.Checked = true;
            this.radioPoints2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioPoints2.Location = new System.Drawing.Point(10, 73);
            this.radioPoints2.Name = "radioPoints2";
            this.radioPoints2.Size = new System.Drawing.Size(118, 29);
            this.radioPoints2.TabIndex = 1;
            this.radioPoints2.TabStop = true;
            this.radioPoints2.Text = "10 points";
            this.radioPoints2.UseVisualStyleBackColor = true;
            // 
            // radioPoints1
            // 
            this.radioPoints1.AutoSize = true;
            this.radioPoints1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioPoints1.Location = new System.Drawing.Point(10, 38);
            this.radioPoints1.Name = "radioPoints1";
            this.radioPoints1.Size = new System.Drawing.Size(106, 29);
            this.radioPoints1.TabIndex = 0;
            this.radioPoints1.Text = "5 points";
            this.radioPoints1.UseVisualStyleBackColor = true;
            // 
            // panelFailsToLose
            // 
            this.panelFailsToLose.BackColor = System.Drawing.Color.Transparent;
            this.panelFailsToLose.Controls.Add(this.labelFailCount);
            this.panelFailsToLose.Controls.Add(this.radioFails3);
            this.panelFailsToLose.Controls.Add(this.radioFails2);
            this.panelFailsToLose.Controls.Add(this.radioFails1);
            this.panelFailsToLose.Location = new System.Drawing.Point(216, 206);
            this.panelFailsToLose.Name = "panelFailsToLose";
            this.panelFailsToLose.Size = new System.Drawing.Size(183, 147);
            this.panelFailsToLose.TabIndex = 6;
            // 
            // labelFailCount
            // 
            this.labelFailCount.AutoSize = true;
            this.labelFailCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFailCount.Location = new System.Drawing.Point(10, 8);
            this.labelFailCount.Name = "labelFailCount";
            this.labelFailCount.Size = new System.Drawing.Size(162, 25);
            this.labelFailCount.TabIndex = 3;
            this.labelFailCount.Text = "Number of fails:";
            // 
            // radioFails3
            // 
            this.radioFails3.AutoSize = true;
            this.radioFails3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioFails3.Location = new System.Drawing.Point(15, 108);
            this.radioFails3.Name = "radioFails3";
            this.radioFails3.Size = new System.Drawing.Size(87, 29);
            this.radioFails3.TabIndex = 2;
            this.radioFails3.Text = "3 fails";
            this.radioFails3.UseVisualStyleBackColor = true;
            // 
            // radioFails2
            // 
            this.radioFails2.AutoSize = true;
            this.radioFails2.Checked = true;
            this.radioFails2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioFails2.Location = new System.Drawing.Point(15, 73);
            this.radioFails2.Name = "radioFails2";
            this.radioFails2.Size = new System.Drawing.Size(87, 29);
            this.radioFails2.TabIndex = 1;
            this.radioFails2.TabStop = true;
            this.radioFails2.Text = "2 fails";
            this.radioFails2.UseVisualStyleBackColor = true;
            // 
            // radioFails1
            // 
            this.radioFails1.AutoSize = true;
            this.radioFails1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioFails1.Location = new System.Drawing.Point(15, 38);
            this.radioFails1.Name = "radioFails1";
            this.radioFails1.Size = new System.Drawing.Size(76, 29);
            this.radioFails1.TabIndex = 0;
            this.radioFails1.Text = "1 fail";
            this.radioFails1.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Location = new System.Drawing.Point(453, 363);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(139, 76);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCance
            // 
            this.buttonCance.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCance.Location = new System.Drawing.Point(615, 363);
            this.buttonCance.Name = "buttonCance";
            this.buttonCance.Size = new System.Drawing.Size(132, 76);
            this.buttonCance.TabIndex = 8;
            this.buttonCance.Text = "Cancel";
            this.buttonCance.UseVisualStyleBackColor = false;
            this.buttonCance.Click += new System.EventHandler(this.buttonCance_Click);
            // 
            // panelTranslation
            // 
            this.panelTranslation.BackColor = System.Drawing.Color.Transparent;
            this.panelTranslation.Controls.Add(this.labelTranslation);
            this.panelTranslation.Controls.Add(this.radioRussianEnglish);
            this.panelTranslation.Controls.Add(this.radioEnglishRussian);
            this.panelTranslation.Location = new System.Drawing.Point(453, 206);
            this.panelTranslation.Name = "panelTranslation";
            this.panelTranslation.Size = new System.Drawing.Size(290, 122);
            this.panelTranslation.TabIndex = 9;
            // 
            // labelTranslation
            // 
            this.labelTranslation.AutoSize = true;
            this.labelTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTranslation.Location = new System.Drawing.Point(3, 10);
            this.labelTranslation.Name = "labelTranslation";
            this.labelTranslation.Size = new System.Drawing.Size(125, 25);
            this.labelTranslation.TabIndex = 6;
            this.labelTranslation.Text = "Translation:";
            // 
            // radioRussianEnglish
            // 
            this.radioRussianEnglish.AutoSize = true;
            this.radioRussianEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioRussianEnglish.Location = new System.Drawing.Point(8, 76);
            this.radioRussianEnglish.Name = "radioRussianEnglish";
            this.radioRussianEnglish.Size = new System.Drawing.Size(264, 29);
            this.radioRussianEnglish.TabIndex = 5;
            this.radioRussianEnglish.Text = "From Russian to English";
            this.radioRussianEnglish.UseVisualStyleBackColor = true;
            // 
            // radioEnglishRussian
            // 
            this.radioEnglishRussian.AutoSize = true;
            this.radioEnglishRussian.Checked = true;
            this.radioEnglishRussian.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioEnglishRussian.Location = new System.Drawing.Point(8, 38);
            this.radioEnglishRussian.Name = "radioEnglishRussian";
            this.radioEnglishRussian.Size = new System.Drawing.Size(264, 29);
            this.radioEnglishRussian.TabIndex = 4;
            this.radioEnglishRussian.TabStop = true;
            this.radioEnglishRussian.Text = "From English to Russian";
            this.radioEnglishRussian.UseVisualStyleBackColor = true;
            // 
            // comboBoxDictionary
            // 
            this.comboBoxDictionary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDictionary.FormattingEnabled = true;
            this.comboBoxDictionary.Location = new System.Drawing.Point(12, 406);
            this.comboBoxDictionary.Name = "comboBoxDictionary";
            this.comboBoxDictionary.Size = new System.Drawing.Size(220, 33);
            this.comboBoxDictionary.TabIndex = 10;
            // 
            // labelDictionary
            // 
            this.labelDictionary.AutoSize = true;
            this.labelDictionary.BackColor = System.Drawing.Color.Transparent;
            this.labelDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDictionary.Location = new System.Drawing.Point(12, 378);
            this.labelDictionary.Name = "labelDictionary";
            this.labelDictionary.Size = new System.Drawing.Size(114, 25);
            this.labelDictionary.TabIndex = 11;
            this.labelDictionary.Text = "Dictionary:";
            // 
            // NewGameDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 460);
            this.Controls.Add(this.labelDictionary);
            this.Controls.Add(this.comboBoxDictionary);
            this.Controls.Add(this.panelTranslation);
            this.Controls.Add(this.buttonCance);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.panelFailsToLose);
            this.Controls.Add(this.panelPointsToWin);
            this.Controls.Add(this.panelPlayerNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewGameDialog";
            this.Text = "Start New Game";
            this.panelPlayerNumber.ResumeLayout(false);
            this.panelPlayerNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).EndInit();
            this.panelPointsToWin.ResumeLayout(false);
            this.panelPointsToWin.PerformLayout();
            this.panelFailsToLose.ResumeLayout(false);
            this.panelFailsToLose.PerformLayout();
            this.panelTranslation.ResumeLayout(false);
            this.panelTranslation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPlayerNumber;
        private System.Windows.Forms.RadioButton radioTwoPlayers;
        private System.Windows.Forms.RadioButton radioOnePlayer;
        private System.Windows.Forms.Panel panelPointsToWin;
        private System.Windows.Forms.RadioButton radioPoints3;
        private System.Windows.Forms.RadioButton radioPoints2;
        private System.Windows.Forms.RadioButton radioPoints1;
        private System.Windows.Forms.Label labelPointsToWin;
        private System.Windows.Forms.Label labelPlayerOne;
        private System.Windows.Forms.TextBox textBoxPlayer1Name;
        private System.Windows.Forms.Label labelPlayers;
        private System.Windows.Forms.Label labelPlayerTwo;
        private System.Windows.Forms.TextBox textBoxPlayer2Name;
        private System.Windows.Forms.Panel panelFailsToLose;
        private System.Windows.Forms.Label labelFailCount;
        private System.Windows.Forms.RadioButton radioFails3;
        private System.Windows.Forms.RadioButton radioFails2;
        private System.Windows.Forms.RadioButton radioFails1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCance;
        private System.Windows.Forms.Panel panelTranslation;
        private System.Windows.Forms.Label labelTranslation;
        private System.Windows.Forms.RadioButton radioRussianEnglish;
        private System.Windows.Forms.RadioButton radioEnglishRussian;
        private System.Windows.Forms.ComboBox comboBoxDictionary;
        private System.Windows.Forms.Label labelDictionary;
        private System.Windows.Forms.PictureBox pictureBoxPlayer2;
        private System.Windows.Forms.PictureBox pictureBoxPlayer1;
    }
}