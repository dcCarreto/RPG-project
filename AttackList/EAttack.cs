namespace Creatures
{
    public class EAttack
    {
        Random numberGen = new();
        int d20;
        
        private int AttackRoll()
        {
            d20 = GetSides(20);
            return d20;
        }

        private int GetSides(int side)
        {
            return numberGen.Next(1, side + 1); ;
        }

        private int Damage(int dice)
        {
            AttackRoll();

            int damage = GetSides(dice);

            if (d20 == 20)
            {
                return damage * 2;
            } else if(d20 == 1)
            {
                return damage * 0;             
            }
            else
            {
                return damage;
            }
            // Condição para acertar baseado na CA do alvo
        }

        public void PerformAttack(AttackListing attackName, DamageTypes type, RangeTypes range, int dice)
        {                    
            string result = $"Attack: {attackName}, Type: {type}, Range: {range}, Attack  Roll - D{dice}: {Damage(dice)}";
            //fazer condição para double damage
            Console.WriteLine($"Attack Roll: {d20}! \nDamage:{result}");
        }        
    }
}

