namespace Creatures
{
    public partial class CreatureAttributes
    {
        // Dices
        private Random numberGen = new Random();
        public int Roll(int dice)
        {
            return numberGen.Next(1, dice + 1);
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
        //-----------------------------------------------

        // Modifiers
        static int CalculateModifier(int attributeValue)
        {
            return (attributeValue - 10) / 2;
        }
    }
}
