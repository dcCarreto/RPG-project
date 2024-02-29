using Creatures.Main;

namespace Creatures
{
    public class EAttack
    {
        Random numberGen = new();
        Dices dice = new();
        ConditionTypes condition = new();
        DamageTypes damageTypes = new();
        RangeTypes rangeTypes = new();
        AttackList attackList = new();

        private int GetSides(int side)
        {
            return numberGen.Next(1, side + 1); ;
        }

        public void PerformAttack(AttackList attackName, DamageTypes type, RangeTypes range, int dice)
        {
            string result = $"Attack: {attackName}, Type: {type}, Range: {range}, Attack dice.Roll - D{dice}: {GetSides(dice)}";

            Console.WriteLine(result);
        }

        public void SetCondition()
        {
            //roll
            //condição
            //turnos
            //dano
        }
    }
}

