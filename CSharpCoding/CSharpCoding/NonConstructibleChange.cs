namespace CSharpCoding
{
    public static class NonConstructibleChange
    {
        public static int NonConstructiveChange(int[] coins)
        {
            var leastAmount = 0;
            if (!coins.Any())
            {
                return 1;
            }

            if (coins.Length == 1 && coins[0] != 1)
            {
                return 1;
            }

            if (coins.Length == 1 && coins[0] == 1)
            {
                return 2;
            }


            foreach (var coin in coins.OrderBy(x => x))
            {
                if (coin > leastAmount + 1 && leastAmount != 0)
                {
                    return leastAmount + 1;
                }

                leastAmount += coin;
            }

            return leastAmount + 1;
        }
    }
}
