using System;
using System.Linq;
using System.Windows.Forms;
using WalrusEngishLogic;

namespace WalrusEnglishGui
{
    public partial class NewGameDialog : Form
    {
        private int _playerOneAvatarNumber = 1;
        private int _playerTwoAvatarNumber = 1;

        public NewGameDialog()
        {
            InitializeComponent();
            Shown += InitializeControls;
        }

        private void InitializeControls(object sender, EventArgs e)
        {
            FillFailsToLose();
            FillPointsToWin();
            FillPlayerNames();
            FillPlayerAvatars();
            FillDictionaries();
        }

        private void FillPlayerAvatars()
        {
            _playerOneAvatarNumber = Game.PlayerOne == null ? 1 : Game.PlayerOne.Avatar;
            pictureBoxPlayer1.Image = AvatarManager.GetAvatarByNumber(_playerOneAvatarNumber);

            _playerTwoAvatarNumber = Game.PlayerTwo == null ? 1 : Game.PlayerTwo.Avatar;
            pictureBoxPlayer2.Image = AvatarManager.GetAvatarByNumber(_playerTwoAvatarNumber, flip: true);
        }

        private void FillDictionaries()
        {
            comboBoxDictionary.DataSource = TheDictionary.GetAvailableDictionaries();
            if (Game.WordDictionary == null) return;

            comboBoxDictionary.Text = Game.WordDictionary.DictionaryFileName;
            if (Game.WordDictionary.EnglishRussian)
                radioEnglishRussian.Checked = true;
            else
                radioRussianEnglish.Checked = true;
        }

        private void FillPlayerNames()
        {
            if (Game.PlayerOne == null) return;

            textBoxPlayer1Name.Text = Game.PlayerOne.Name;

            if (Game.PlayerTwo != null)
            {
                radioTwoPlayers.Checked = true;
                textBoxPlayer2Name.Text = Game.PlayerTwo.Name;
            }
            else
            {
                radioTwoPlayers.Checked = false;
            }
        }

        private void FillPointsToWin()
        {
            radioPoints1.Text = Constants.PointsToWin[0] + " point(s)";
            radioPoints2.Text = Constants.PointsToWin[1] + " point(s)";
            radioPoints3.Text = Constants.PointsToWin[2] + " point(s)";
            
            if (Game.PointsToWin == 0) return;

            for (var i = 0; i < Constants.PointsToWin.Count(); i++)
            {
                if (Constants.PointsToWin[i] != Game.PointsToWin) continue;

                panelPointsToWin.Controls.OfType<RadioButton>().First(radio => radio.TabIndex == i).Checked = true;
            }
        }

        private void FillFailsToLose()
        {
            radioFails1.Text = Constants.FailsCount[0] + " fail(s)";
            radioFails2.Text = Constants.FailsCount[1] + " fail(s)";
            radioFails3.Text = Constants.FailsCount[2] + " fail(s)";
            
            if (Game.FailsToLose == 0) return;
            
            for (var i = 0; i < Constants.FailsCount.Count(); i++)
            {
                if (Constants.FailsCount[i] != Game.FailsToLose) continue;

                panelFailsToLose.Controls.OfType<RadioButton>().First(radio => radio.TabIndex == i).Checked = true;
            }
        }

        private void buttonCance_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!ValidateControls()) return;

            var playerOne = new Player(textBoxPlayer1Name.Text, _playerOneAvatarNumber);
            var playerTwo = radioTwoPlayers.Checked
                ? new Player(textBoxPlayer2Name.Text, _playerTwoAvatarNumber, lastChance: true)
                : null;
            
            Game.StartNew(playerOne, playerTwo, radioEnglishRussian.Checked, comboBoxDictionary.Text, ReadFailsToLose(), ReadPointsToWin());
            
            Close();
            
            Program.TheGameForm.SetStartMessage();
            Program.TheGameForm.Redraw();
        }

        private int ReadPointsToWin()
        {
            var pointsToWin = 0;
            foreach (var radioPointsToWin in panelPointsToWin.Controls.OfType<RadioButton>().Where(radioPointsToWin => radioPointsToWin.Checked))
            {
                pointsToWin = Constants.PointsToWin[radioPointsToWin.TabIndex];
            }

            if (pointsToWin == 0)
                throw new InvalidOperationException("pointsToWin = 0!");

            return pointsToWin;
        }

        private int ReadFailsToLose()
        {
            var failsToLose = 0;
            foreach (var radioFailsToLose in panelFailsToLose.Controls.OfType<RadioButton>().Where(radioFailsToLose => radioFailsToLose.Checked))
            {
                failsToLose = Constants.FailsCount[radioFailsToLose.TabIndex];
            }

            if (failsToLose == 0)
                throw new InvalidOperationException("failsToLose = 0!");

            return failsToLose;
        }

        private bool ValidateControls()
        {
            if (!string.IsNullOrWhiteSpace(textBoxPlayer1Name.Text)) return true;

            MessageBox.Show("Please enter the name of player one. Пожалуйста введите имя первого игрока.",
                "Error. Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        private void radioOnePlayer_CheckedChanged(object sender, EventArgs e)
        {
            labelPlayerTwo.Visible = !radioOnePlayer.Checked;
            textBoxPlayer2Name.Visible = !radioOnePlayer.Checked;
            pictureBoxPlayer2.Visible = !radioOnePlayer.Checked;
        }

        private void pictureBoxPlayer1_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer1.Image = AvatarManager.GetNextAvatar(ref _playerOneAvatarNumber);
        }

        private void pictureBoxPlayer2_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer2.Image = AvatarManager.GetNextAvatar(ref _playerTwoAvatarNumber, flip: true);
        }
    }
}
