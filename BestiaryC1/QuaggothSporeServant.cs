namespace Creatures.BestiaryC1
{
    internal class QuaggothSporeServant : Creatures
    {
        readonly Dices dice = new();
        public QuaggothSporeServant()
        {
            Name = "Quaggoth Spore Servant";
            Type = pl;
            Size = m;
            Alignment = ud;
            HitPoints = 45 + dice.RollMultiple(dice.d8, 6) + 18;
            ArmorClass = 13;
            Speed = "20ft, climb 20ft";
            Attributes = [17, 12, 16, 2, 6, 1];
            ChallengeLevel = "1";
            Experience = 200;
            DamageImmunities = "poison";
            ConditionImmunities = "blinded, charmed, frightened, paralyzed, poisoned";
            Senses = "blindsight 30ft (blind beyond this radius), passive Perception 8";
            Actions = [
                @"
Multiattack. The spore servant makes two claw attacks.",
                @"
Claw. Melee Weapon Attack: +5 to hit, reach 5 ft., one target.
Hit: 6 (1d6 + 3) slashing damage."
                ];
        }
    }
}
