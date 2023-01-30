namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private readonly Player _playerOne;
        private readonly Player _playerTwo;

        private readonly string[] _scores = { "Love", "Fifteen", "Thirty", "Forty" };
        public TennisGame3(string player1Name, string player2Name)
        {
            _playerOne = new Player(player1Name);  // ideally we would have a repository that handles creating new instances of the Player class
            _playerTwo = new Player(player2Name);
        }

        public string GetScore()
        {
            if (IsPlayerPointsLessThanFour() && IsSumPlayerPointsLessThanSix())
            {
                return GetGameScore();
            }
            else
            {
                return DecideGame();
            }
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                this._playerOne.Points += 1;
            else
                this._playerTwo.Points += 1;
        }

        private string GetPlayerScore(int playerPoints)
        {            
            return _scores[playerPoints];
        }

        private bool IsPlayerPointsLessThanFour()
        {
            return _playerOne.Points < 4 && _playerTwo.Points < 4;
        }
        private bool IsSumPlayerPointsLessThanSix()
        {
            return _playerOne.Points + _playerTwo.Points < 6;
        }

        private string DecideGame()
        {
            if (_playerOne.Points == _playerTwo.Points)
                return "Deuce";
            string leader = _playerOne.Points > _playerTwo.Points ? _playerOne.Name : _playerTwo.Name;
            return ((_playerOne.Points - _playerTwo.Points) * (_playerOne.Points - _playerTwo.Points) == 1) ? "Advantage " + leader : "Win for " + leader;
        }

        private string GetGameScore()
        {
            var playerOneScore = GetPlayerScore(_playerOne.Points);
            var score = _playerOne.Points == _playerTwo.Points ? playerOneScore + "-All" : playerOneScore + "-" + GetPlayerScore(_playerTwo.Points);
            return score;
        }

    }
}

