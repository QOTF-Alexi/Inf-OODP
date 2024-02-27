public static class GameTools
{
    public static bool ReturnCount = true;
    public static Random ranNumGen = new();

    public static string CoinFlip(int numOfFlips)
    {
        List<string> flippedCoins = new();
        
        for (int i = 0; i < numOfFlips; i++)
        {
            int flipNum = ranNumGen.Next(1, 3);
            if (flipNum == 1)
            {
                flippedCoins.Add("Heads");
            }
            else flippedCoins.Add("Tails");
        }

        if (ReturnCount)
        {
            int numHeads = 0;
            int numTails = 0;
            foreach (string flip in flippedCoins)
            {
                switch (flip)
                {
                    case "Heads":
                        numHeads += 1;
                        break;
                    default:
                        numTails += 1;
                        break;
                }
            }

            return $"Heads: {numHeads}\nTails: {numTails}";
        }
        else
        {
            string returnString = "";
            foreach (string flip in flippedCoins)
            {
                returnString += $"{flip}\n";
            }

            return returnString;
        }
    }

    public static string DiceRoll(int sides, int numOfRolls)
    {
        if (sides < 3) return "Invalid number of die sides.";
        else
        {
            List<int> rolledDice = new();
            for (int i = 0; i < numOfRolls; i++)
            {
                int rollNum = ranNumGen.Next(1, sides + 1);
                rolledDice.Add(rollNum);
            }

            if (ReturnCount)
            {
                return null;
            }

            else
            {
                string returnString = "";
                int count = 1;
                foreach (int roll in rolledDice)
                {
                    returnString += $"Roll {count}: {roll}\n";
                    count += 1;
                }

                return returnString;
            }
        }
    }
}