namespace Creatures
{
    class Dices
    {
        private Random numberGen = new Random();
        public int d4 = 4;
        public int d6 = 6;
        public int d8 = 8;
        public int d10 = 10;
        public int d12 = 12;
        public int d20 = 20;

        public int Roll(int dice)
        {
            int result = numberGen.Next(1, dice + 1);
            return result;
        }

        public int RollMultiple(int dice, int numRolls)
        {
            int totalResult = 0;
            for (int i = 0; i < numRolls; i++)
            {
                totalResult += Roll(dice);
            }
            return totalResult;
        }
    }
}
