namespace Creatures
{
    public class Combat
    {
        public static void CombatMain()
        {
            EAttack attack = new();
            attack.PerformAttack(AttackListing.Bite, DamageTypes.Piercing, RangeTypes.Melee, 10);
        }
    }
}
