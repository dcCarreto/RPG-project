namespace Creatures.BestiaryC1o4
{
    internal class FlyingSword : Creatures
    {
        readonly Dices dice = new();
        public FlyingSword()
        {
            Name = "Flying Sword";
            Type = co;
            Size = s;
            Alignment = ud;
            HitPoints = 17 + dice.RollMultiple(dice.d6, 5);
            Attributes = [12, 15, 11, 1, 5, 1];
            ArmorClass = 17;
            Speed = "0ft, fly 50ft";
            Experience = 50;
            ChallengeLevel = "1/4";
            SavingThrows = "Dex +4";
            DamageImmunities = "poison, psychic";
            ConditionImmunities = "blinded, charmed, deafened, frightened, paralyzed, petrified, poisoned.";
            Senses = "blindsight 60ft, (blind beyond this radius)";
            Actions = [@"Longsword. Melee Weapon Attack: +3 to hit, reach 5ft, one target. Hit: 5 (1d8 +1) slashing damage."];
            Abilities = [
                @"

Antimagic Susceptibility. The sword is incapacitated while in the
area of an antimagic field. If targeted by dispel magic, the sword
must succeed on a Constitution saving throw against the caster`s
spell save DC or fall unconscious for 1 minute.",
@"
False Appearance. While the sword remains motionless and isn`t flying,
it is indistinghishable from a normal sword.
"
            ];
        }
    }
}
