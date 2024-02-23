namespace Creatures
{
    public class EAttack
    {
        
        Random numberGen = new();
        Dices dice = new();
        ConditionTypes condition = new();
        DamageTypes damageTypes = new();
        RangeTypes rangeTypes = new();
        UnnarmedAttacks unnarmedAttacks = new();

        public int GetSides(int side)
        {
            return numberGen.Next(1, side + 1); ;
        }



        public void PerformAttack(string attackName, string damageType, string range, int damage)
        {
            
            int d20 = dice.Roll(dice.d20);
            string aName = unnarmedAttacks.GetAttackName(attackName);
            string dType = damageTypes.GetDamageTypes(damageType);
            string rType = rangeTypes.GetRangeTypes(range);
            int damageOutput = GetSides(damage);
            
            Console.WriteLine($"Roll: {d20}, Attack: {aName}, Type: {dType}, Range: {rType}, Damage: {damageOutput}");
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

