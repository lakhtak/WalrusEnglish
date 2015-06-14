namespace WalrusEngishLogic
{
    public static class Game
    {
        public static Player PlayerOne;
        public static Player PlayerTwo;
        public static Player CurrentPlayer;
        public static int FailsToLose;
        public static int PointsToWin;

        public static TheDictionary WordDictionary;

        public static void StartNew(Player playerOne, Player playerTwo, bool englishRussian, string dictionaryName, int failsToLose, int pointsToWin)
        {
            WordDictionary = new TheDictionary(dictionaryName, englishRussian);
            FailsToLose = failsToLose;
            PointsToWin = pointsToWin;
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
            CurrentPlayer = PlayerOne;
        }

        public static void SwitchTurn()
        {
            if (PlayerTwo == null) return;

            CurrentPlayer = CurrentPlayer.Equals(PlayerOne) ? PlayerTwo : PlayerOne;
        }

        public static Player OppositePlayer
        {
            get
            {
                return CurrentPlayer.Equals(PlayerOne) ? PlayerTwo : PlayerOne;
            }
        }

        public static bool Over()
        {
            if (PlayerOne.Winner)
            {
                if (PlayerTwo != null && PlayerTwo.LastChance)
                {
                    PlayerTwo.UseLastChance();
                    return false;
                }
                return true;
            }

            return PlayerOne.Loser || (PlayerTwo != null && (PlayerTwo.Loser || PlayerTwo.Winner));
        }
    }
}
