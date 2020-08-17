using System;
using Xunit;
using MaxCoinValue;

namespace MaxCoinValue.Tests
{
    public class CoinGameTests
    {
        [Fact]
        public void CoinGame_GetP1MaxValue_GivenOrderedListAsc()
        {
            int[] coins = new int[6] {1,2,3,4,5,6};
            CoinGame game = new CoinGame(coins);
            
            int expectedResult = 12;

            game.SimulateCompleteGame_Player1First();

            int actualResult = game.Player1;

            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void CoinGame_GetP1MaxValue_GivenOrderedListDesc()
        {
            int[] coins = new int[6] {6,5,4,3,2,1};
            CoinGame game = new CoinGame(coins);
            
            int expectedResult = 12;

            game.SimulateCompleteGame_Player1First();

            int actualResult = game.Player1;

            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void CoinGame_GetP1MaxValue_GivenUnorderedList()
        {
            int[] coins = new int[6] {6,3,4,2,1,5};
            CoinGame game = new CoinGame(coins);
            
            int expectedResult = 11;

            game.SimulateCompleteGame_Player1First();

            int actualResult = game.Player1;

            Assert.Equal(expectedResult, actualResult);

        }
    }
}
