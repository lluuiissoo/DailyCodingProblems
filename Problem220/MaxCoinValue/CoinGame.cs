using System;

namespace MaxCoinValue
{
    public class CoinGame
    {
        private int[] _Coins;
        private int _Left = 0;
        private int _Right = 0; //It will be the size of array once intilized in constructor
        private int _Turn = 0;

        public int Player1 {get; private set;}

        public int Player2 {get; private set;}
        
        public CoinGame(int[] coins)
        {
            if (coins != null)
            {
                _Coins = coins;
                ResetGame();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public int PlayOptimal()
        {
            _Turn++;
            int optimalValue = 0;

            if (_Coins[_Left] > _Coins[_Right])
            {
                optimalValue = _Coins[_Left];
                _Left++;
            }
            else
            {
                optimalValue = _Coins[_Right];
                _Right--;
            }

            return optimalValue;
        }

        public void SimulateCompleteGame_Player1First()
        {
            ResetGame();
            while (_Left <= _Right)
            {
                int nextTurn = _Turn+1;
                
                if (nextTurn % 2 == 1)  //Odd, P1's turn
                {
                    Player1 += PlayOptimal();
                }
                else                    //Even, P2's turn
                {
                    Player2 += PlayOptimal();
                }
            }
        }

        private void ResetGame()
        {
            _Left = 0;
            _Right = _Coins.Length-1;
            _Turn = 0;
            Player1 = Player2 = 0;
        }
    }
}
