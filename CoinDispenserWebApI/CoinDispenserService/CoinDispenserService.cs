namespace CoinDispenserWebApI.CoinDispenserService
{
    public class CoinDispenserService : ICoinDispenserService
    {

        /// <summary>
        /// This method finds the minimum number of coins needed for a given amount.
        /// </summary>
        /// <param name="coins"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public int MinCombination(int [] coins, int amount)
        {
            if (amount == 0) return 0;

            // Initializing the  result
            int result = int.MaxValue;

            // Try every coin that has
            // smaller value than amount
            for (int i = 0; i < coins.Length; i++)
            {
                if (coins[i] <= amount)
                {
                    int sub_res = MinCombination(coins,
                                      amount - coins[i]);

                    // Checking for INT_MAX to
                    // avoid overflow and see
                    // if result can minimized
                    if (sub_res != int.MaxValue &&
                                sub_res + 1 < result)
                        result = sub_res + 1;
                }
            }
            return result;
        }
    }
}
