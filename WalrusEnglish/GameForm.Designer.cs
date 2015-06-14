﻿namespace WalrusEnglishGui
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.labelPlayer1Name = new System.Windows.Forms.Label();
            this.labelPlayer2Name = new System.Windows.Forms.Label();
            this.labelPlayer2Points = new System.Windows.Forms.Label();
            this.labelPlayer1Points = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelTheWord = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelVariants = new System.Windows.Forms.Panel();
            this.radioButtonVariant1 = new System.Windows.Forms.RadioButton();
            this.radioButtonVariant2 = new System.Windows.Forms.RadioButton();
            this.radioButtonVariant3 = new System.Windows.Forms.RadioButton();
            this.radioButtonVariant4 = new System.Windows.Forms.RadioButton();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelPlayer1Fails = new System.Windows.Forms.Label();
            this.labelPlayer2Fails = new System.Windows.Forms.Label();
            this.labelFails = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.pictureBoxPlayer2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer1 = new System.Windows.Forms.PictureBox();
            this.labelDictionary = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.panelVariants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPlayer1Name
            // 
            this.labelPlayer1Name.AutoEllipsis = true;
            this.labelPlayer1Name.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer1Name.Location = new System.Drawing.Point(7, 137);
            this.labelPlayer1Name.Name = "labelPlayer1Name";
            this.labelPlayer1Name.Size = new System.Drawing.Size(150, 65);
            this.labelPlayer1Name.TabIndex = 0;
            this.labelPlayer1Name.Text = "Player1Player1dddd";
            // 
            // labelPlayer2Name
            // 
            this.labelPlayer2Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlayer2Name.AutoEllipsis = true;
            this.labelPlayer2Name.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer2Name.Location = new System.Drawing.Point(621, 137);
            this.labelPlayer2Name.Name = "labelPlayer2Name";
            this.labelPlayer2Name.Size = new System.Drawing.Size(145, 65);
            this.labelPlayer2Name.TabIndex = 1;
            this.labelPlayer2Name.Text = "Player2Player2dddd";
            this.labelPlayer2Name.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPlayer2Points
            // 
            this.labelPlayer2Points.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlayer2Points.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer2Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer2Points.Location = new System.Drawing.Point(707, 202);
            this.labelPlayer2Points.Name = "labelPlayer2Points";
            this.labelPlayer2Points.Size = new System.Drawing.Size(59, 25);
            this.labelPlayer2Points.TabIndex = 2;
            this.labelPlayer2Points.Text = "0";
            this.labelPlayer2Points.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPlayer1Points
            // 
            this.labelPlayer1Points.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer1Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer1Points.Location = new System.Drawing.Point(7, 202);
            this.labelPlayer1Points.Name = "labelPlayer1Points";
            this.labelPlayer1Points.Size = new System.Drawing.Size(69, 25);
            this.labelPlayer1Points.TabIndex = 3;
            this.labelPlayer1Points.Text = "0";
            // 
            // labelMessage
            // 
            this.labelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMessage.AutoEllipsis = true;
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMessage.Location = new System.Drawing.Point(163, 137);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(452, 227);
            this.labelMessage.TabIndex = 4;
            this.labelMessage.Text = "Hello";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTheWord
            // 
            this.labelTheWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTheWord.BackColor = System.Drawing.Color.Transparent;
            this.labelTheWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTheWord.Location = new System.Drawing.Point(12, 400);
            this.labelTheWord.Name = "labelTheWord";
            this.labelTheWord.Size = new System.Drawing.Size(268, 84);
            this.labelTheWord.TabIndex = 6;
            this.labelTheWord.Text = "THE WORD";
            this.labelTheWord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem1});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu.Size = new System.Drawing.Size(778, 24);
            this.menu.TabIndex = 7;
            this.menu.Text = "Меню";
            // 
            // newGameToolStripMenuItem1
            // 
            this.newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
            this.newGameToolStripMenuItem1.Size = new System.Drawing.Size(81, 20);
            this.newGameToolStripMenuItem1.Text = "New game...";
            this.newGameToolStripMenuItem1.Click += new System.EventHandler(this.newGameToolStripMenuItem1_Click);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.newGameToolStripMenuItem.Text = "New game...";
            // 
            // panelVariants
            // 
            this.panelVariants.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVariants.BackColor = System.Drawing.Color.Transparent;
            this.panelVariants.Controls.Add(this.radioButtonVariant1);
            this.panelVariants.Controls.Add(this.radioButtonVariant2);
            this.panelVariants.Controls.Add(this.radioButtonVariant3);
            this.panelVariants.Controls.Add(this.radioButtonVariant4);
            this.panelVariants.Location = new System.Drawing.Point(286, 367);
            this.panelVariants.Name = "panelVariants";
            this.panelVariants.Size = new System.Drawing.Size(360, 153);
            this.panelVariants.TabIndex = 99;
            // 
            // radioButtonVariant1
            // 
            this.radioButtonVariant1.AutoSize = true;
            this.radioButtonVariant1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonVariant1.Location = new System.Drawing.Point(10, 8);
            this.radioButtonVariant1.Name = "radioButtonVariant1";
            this.radioButtonVariant1.Size = new System.Drawing.Size(134, 29);
            this.radioButtonVariant1.TabIndex = 0;
            this.radioButtonVariant1.TabStop = true;
            this.radioButtonVariant1.Text = "Перевод 1";
            this.radioButtonVariant1.UseVisualStyleBackColor = true;
            // 
            // radioButtonVariant2
            // 
            this.radioButtonVariant2.AutoSize = true;
            this.radioButtonVariant2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonVariant2.Location = new System.Drawing.Point(10, 43);
            this.radioButtonVariant2.Name = "radioButtonVariant2";
            this.radioButtonVariant2.Size = new System.Drawing.Size(134, 29);
            this.radioButtonVariant2.TabIndex = 1;
            this.radioButtonVariant2.TabStop = true;
            this.radioButtonVariant2.Text = "Перевод 2";
            this.radioButtonVariant2.UseVisualStyleBackColor = true;
            // 
            // radioButtonVariant3
            // 
            this.radioButtonVariant3.AutoSize = true;
            this.radioButtonVariant3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonVariant3.Location = new System.Drawing.Point(10, 78);
            this.radioButtonVariant3.Name = "radioButtonVariant3";
            this.radioButtonVariant3.Size = new System.Drawing.Size(134, 29);
            this.radioButtonVariant3.TabIndex = 2;
            this.radioButtonVariant3.TabStop = true;
            this.radioButtonVariant3.Text = "Перевод 3";
            this.radioButtonVariant3.UseVisualStyleBackColor = true;
            // 
            // radioButtonVariant4
            // 
            this.radioButtonVariant4.AutoSize = true;
            this.radioButtonVariant4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonVariant4.Location = new System.Drawing.Point(10, 113);
            this.radioButtonVariant4.Name = "radioButtonVariant4";
            this.radioButtonVariant4.Size = new System.Drawing.Size(134, 29);
            this.radioButtonVariant4.TabIndex = 3;
            this.radioButtonVariant4.TabStop = true;
            this.radioButtonVariant4.Text = "Перевод 4";
            this.radioButtonVariant4.UseVisualStyleBackColor = true;
            // 
            // buttonYes
            // 
            this.buttonYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonYes.BackColor = System.Drawing.SystemColors.Control;
            this.buttonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonYes.Location = new System.Drawing.Point(653, 367);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(113, 153);
            this.buttonYes.TabIndex = 9;
            this.buttonYes.Text = "Да!";
            this.buttonYes.UseVisualStyleBackColor = false;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.BackColor = System.Drawing.SystemColors.Control;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(555, 431);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(211, 89);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start game";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelPlayer1Fails
            // 
            this.labelPlayer1Fails.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer1Fails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer1Fails.ForeColor = System.Drawing.Color.Red;
            this.labelPlayer1Fails.Location = new System.Drawing.Point(7, 227);
            this.labelPlayer1Fails.Name = "labelPlayer1Fails";
            this.labelPlayer1Fails.Size = new System.Drawing.Size(104, 25);
            this.labelPlayer1Fails.TabIndex = 11;
            this.labelPlayer1Fails.Text = "XXX";
            // 
            // labelPlayer2Fails
            // 
            this.labelPlayer2Fails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlayer2Fails.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer2Fails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer2Fails.ForeColor = System.Drawing.Color.Red;
            this.labelPlayer2Fails.Location = new System.Drawing.Point(654, 227);
            this.labelPlayer2Fails.Name = "labelPlayer2Fails";
            this.labelPlayer2Fails.Size = new System.Drawing.Size(112, 25);
            this.labelPlayer2Fails.TabIndex = 12;
            this.labelPlayer2Fails.Text = "XXX";
            this.labelPlayer2Fails.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelFails
            // 
            this.labelFails.AutoSize = true;
            this.labelFails.BackColor = System.Drawing.Color.Transparent;
            this.labelFails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFails.Location = new System.Drawing.Point(265, 64);
            this.labelFails.Name = "labelFails";
            this.labelFails.Size = new System.Drawing.Size(237, 25);
            this.labelFails.TabIndex = 13;
            this.labelFails.Text = "Играем до 0 промахов";
            this.labelFails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.BackColor = System.Drawing.Color.Transparent;
            this.labelPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoints.Location = new System.Drawing.Point(281, 39);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(197, 25);
            this.labelPoints.TabIndex = 14;
            this.labelPoints.Text = "Играем до 0 очков";
            this.labelPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxPlayer2
            // 
            this.pictureBoxPlayer2.Image = global::WalrusEnglishGui.Properties.Resources.avatar01;
            this.pictureBoxPlayer2.Location = new System.Drawing.Point(621, 34);
            this.pictureBoxPlayer2.Name = "pictureBoxPlayer2";
            this.pictureBoxPlayer2.Size = new System.Drawing.Size(145, 100);
            this.pictureBoxPlayer2.TabIndex = 101;
            this.pictureBoxPlayer2.TabStop = false;
            // 
            // pictureBoxPlayer1
            // 
            this.pictureBoxPlayer1.Image = global::WalrusEnglishGui.Properties.Resources.avatar01;
            this.pictureBoxPlayer1.Location = new System.Drawing.Point(12, 34);
            this.pictureBoxPlayer1.Name = "pictureBoxPlayer1";
            this.pictureBoxPlayer1.Size = new System.Drawing.Size(145, 100);
            this.pictureBoxPlayer1.TabIndex = 100;
            this.pictureBoxPlayer1.TabStop = false;
            // 
            // labelDictionary
            // 
            this.labelDictionary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDictionary.AutoSize = true;
            this.labelDictionary.BackColor = System.Drawing.Color.Transparent;
            this.labelDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDictionary.Location = new System.Drawing.Point(281, 89);
            this.labelDictionary.Name = "labelDictionary";
            this.labelDictionary.Size = new System.Drawing.Size(109, 25);
            this.labelDictionary.TabIndex = 102;
            this.labelDictionary.Text = "Словарь: ";
            this.labelDictionary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(778, 532);
            this.Controls.Add(this.labelDictionary);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pictureBoxPlayer2);
            this.Controls.Add(this.pictureBoxPlayer1);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.labelFails);
            this.Controls.Add(this.labelPlayer2Fails);
            this.Controls.Add(this.labelPlayer1Fails);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelPlayer1Points);
            this.Controls.Add(this.labelPlayer2Points);
            this.Controls.Add(this.labelPlayer2Name);
            this.Controls.Add(this.labelPlayer1Name);
            this.Controls.Add(this.panelVariants);
            this.Controls.Add(this.labelTheWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.Text = "English Question";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panelVariants.ResumeLayout(false);
            this.panelVariants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayer1Name;
        private System.Windows.Forms.Label labelPlayer2Name;
        private System.Windows.Forms.Label labelPlayer2Points;
        private System.Windows.Forms.Label labelPlayer1Points;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelTheWord;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Panel panelVariants;
        private System.Windows.Forms.RadioButton radioButtonVariant4;
        private System.Windows.Forms.RadioButton radioButtonVariant3;
        private System.Windows.Forms.RadioButton radioButtonVariant2;
        private System.Windows.Forms.RadioButton radioButtonVariant1;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelPlayer1Fails;
        private System.Windows.Forms.Label labelPlayer2Fails;
        private System.Windows.Forms.Label labelFails;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxPlayer1;
        private System.Windows.Forms.PictureBox pictureBoxPlayer2;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem1;
        private System.Windows.Forms.Label labelDictionary;
    }
}

