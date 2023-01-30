namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private readonly Player _playerOne;
        private readonly Player _playerTwo;

        public TennisGame3(string player1Name, string player2Name)
        {
            _playerOne = new Player(player1Name);
            _playerTwo = new Player(player2Name);
        }

        public string GetScore()
        {
            string s;
            if ((_playerOne.Points < 4 && _playerTwo.Points < 4) && (_playerOne.Points + _playerTwo.Points < 6))
            {
                string[] p = { "Love", "Fifteen", "Thirty", "Forty" };
                s = p[_playerOne.Points];
                return (_playerOne.Points == _playerTwo.Points) ? s + "-All" : s + "-" + p[_playerTwo.Points];
            }
            else
            {
                if (_playerOne.Points == _playerTwo.Points)
                    return "Deuce";
                s = _playerOne.Points > _playerTwo.Points ? _playerOne.Name : _playerTwo.Name;
                return ((_playerOne.Points - _playerTwo.Points) * (_playerOne.Points - _playerTwo.Points) == 1) ? "Advantage " + s : "Win for " + s;
            }
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                this._playerOne.Points += 1;
            else
                this._playerTwo.Points += 1;
        }

    }
}

