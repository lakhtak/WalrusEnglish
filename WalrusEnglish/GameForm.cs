﻿using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using WalrusEngishLogic;

namespace WalrusEnglishGui
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            labelMessage.Text = GameMessage.Text(MessageType.Hello);
            labelMessage.Text = GameMessage.Text(MessageType.Hello);
            
            labelPlayer1Name.Visible = false;
            pictureBoxPlayer1.Visible = false;
            labelPlayer1Points.Visible = false;
            labelPlayer1Fails.Visible = false;

            labelPlayer2Name.Visible = false;
            pictureBoxPlayer2.Visible = false;
            labelPlayer2Points.Visible = false;
            labelPlayer2Fails.Visible = false;

            labelTheWord.Visible = false;
            buttonYes.Visible = false;
            panelVariants.Visible = false;

            labelFails.Visible = false;
            labelPoints.Visible = false;
            labelDictionary.Visible = false;

            panelVariants.Visible = false;
            buttonStart.Visible = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            var startDialog = new NewGameDialog();
            startDialog.ShowDialog();
        }

        public void Redraw()
        {
            labelPlayer1Name.Text = Game.PlayerOne.Name;
            labelPlayer1Name.ForeColor = Game.CurrentPlayer.Name.Equals(Game.PlayerOne.Name)
                ? Color.Red
                : Color.Black;
            labelPlayer1Name.Visible = true;
            pictureBoxPlayer1.Image = AvatarManager.GetAvatarByNumber(Game.PlayerOne.Avatar);
            pictureBoxPlayer1.Visible = true;
            labelPlayer1Points.Text = Game.PlayerOne.Points.ToString(CultureInfo.InvariantCulture);
            labelPlayer1Points.Visible = true;
            labelPlayer1Fails.Text = new String('X', Game.PlayerOne.Fails);
            labelPlayer1Fails.Visible = true;

            foreach (var radio in panelVariants.Controls.OfType<RadioButton>())
                radio.Checked = false;
            
            if (Game.PlayerTwo != null)
            {
                labelPlayer2Name.Text = Game.PlayerTwo.Name;
                pictureBoxPlayer2.Image = AvatarManager.GetAvatarByNumber(Game.PlayerTwo.Avatar, flip: true);
                labelPlayer2Name.ForeColor = Game.CurrentPlayer.Name.Equals(Game.PlayerTwo.Name)
                    ? Color.Red
                    : Color.Black;
                labelPlayer2Points.Text = Game.PlayerTwo.Points.ToString(CultureInfo.InvariantCulture);
                labelPlayer2Fails.Text = new String('X', Game.PlayerTwo.Fails);
            }
            labelPlayer2Name.Visible = Game.PlayerTwo != null;
            pictureBoxPlayer2.Visible = Game.PlayerTwo != null;
            labelPlayer2Points.Visible = Game.PlayerTwo != null;
            labelPlayer2Fails.Visible = Game.PlayerTwo != null;

            buttonYes.Visible = true;
            panelVariants.Visible = true;

            labelFails.Text = string.Format("Играем до {0} промахов.", Game.FailsToLose.ToString(CultureInfo.InvariantCulture));
            labelFails.Visible = true;

            labelPoints.Text = string.Format("Играем до {0} очков.", Game.PointsToWin.ToString(CultureInfo.InvariantCulture));
            labelPoints.Visible = true;

            labelDictionary.Text = string.Format("Словарь: {0}.", Game.WordDictionary.DictionaryFileName);
            labelDictionary.Visible = true;

            buttonStart.Visible = false;
            panelVariants.Visible = true;

            labelTheWord.Text = Game.WordDictionary.GetNextWord();
            labelTheWord.Visible = true;

            var variants = Game.WordDictionary.GetVariants();
            foreach (var radioVariant in panelVariants.Controls.OfType<RadioButton>())
            {
                radioVariant.Text = variants[radioVariant.TabIndex];
            }
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            if (!panelVariants.Controls.OfType<RadioButton>().Any(radioVariant => radioVariant.Checked))
            {
                MessageBox.Show("Please choose correct word translation. Пожалуйста выберите правильный перевод слова.",
                "Error. Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var correctAnswer =
                Game.WordDictionary.IsAnswerCorrect(
                    panelVariants.Controls.OfType<RadioButton>().First(radioVariant => radioVariant.Checked).Text);

            if (correctAnswer)
            {
                Game.CurrentPlayer.IncreasePoints();
                labelMessage.Text =
                string.Format(
                    GameMessage.Text(MessageType.CorrectAnswer),
                    Game.CurrentPlayer.Name, Constants.OneSuccessCost);
            }
            else
            {
                Game.CurrentPlayer.IncreaseFails();
                labelMessage.Text =
                    string.Format(
                        GameMessage.Text(MessageType.IncorrectAnswer),
                        Game.CurrentPlayer.Name, Game.CurrentPlayer.Fails, Game.WordDictionary.CorrectAnswer);
            }

            if (Game.Over())
            {
                ShowWinningState();
                return;
            }
            
            Game.SwitchTurn();

            labelMessage.Text = labelMessage.Text + Environment.NewLine + Environment.NewLine + string.Format(GameMessage.Text(MessageType.MakeMove), Game.CurrentPlayer.Name);
            Redraw();
        }

        private void ShowWinningState()
        {
            Redraw();
            buttonYes.Visible = false;
            panelVariants.Visible = false;
            labelTheWord.Visible = false;
            labelFails.Visible = false;
            labelPoints.Visible = false;
            buttonStart.Visible = true;
            var messageForPlayerOne =
                string.Format(GameMessage.Text(Game.PlayerOne.Winner || (Game.PlayerTwo != null && Game.PlayerTwo.Loser) ? MessageType.Win : MessageType.Lose),
                    Game.PlayerOne.Name);
            var messageForPlayerTwo =
                Game.PlayerTwo == null ? "" : string.Format(GameMessage.Text(Game.PlayerTwo.Winner || Game.PlayerOne.Loser ? MessageType.Win : MessageType.Lose),
                    Game.PlayerTwo.Name);
            labelMessage.Text = messageForPlayerOne + Environment.NewLine + Environment.NewLine + messageForPlayerTwo;
            Refresh();
        }

        public void SetStartMessage()
        {
            labelMessage.Text = string.Format(GameMessage.Text(MessageType.MakeMove), Game.CurrentPlayer.Name);
        }

        private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var startDialog = new NewGameDialog();
            startDialog.ShowDialog();
        }
    }
}
