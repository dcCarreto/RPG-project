namespace Creatures.BestiaryC2
{
    internal class RugOfSmothering : Creature
    {

        public RugOfSmothering()
        {
            Name = "Rug of Smothering";
            Type = co;
            Size = l;
            Alignment = ud;
            HitPoints = 33 + RollMultiple(10, 6);
            ArmorClass = 12;
            Speed = "10ft";
            Attributes = [17, 14, 10, 1, 3, 1];
            ChallengeLevel = "2";
            Experience = 450;
            DamageImmunities = "poison";
            ConditionImmunities = "blinded, charmed, deafened, frightened, paralyzed, petrified, poisoned";
            Senses = "blindsight 60ft (blind beyond this radius), passive Perception 6";
            Actions = [
                @"
Smother. Melee Weapon Attack: +S to hit, reach S ft ., one
Medium or smaller creature. Hit: The creature is grappled
(escape DC 13). Until this grapple ends, the target is restrai ned,
blinded, and at risk of suffocating, and the rug can't smother
another target. In addition, at the start of each of the target's
turns, the target takes 10 (2d6 + 3) bludgeoning damage."
                ];
            Abilities = [
                @"
Antimagic Susceptibility. The rug is incapacitated while in
the area of an anti magic field. If targeted by dispel magic, the
rug must succeed on a Constitution saving throw against the
caster's spell save DC or fall unconscious for 1 minute.",
                @"
Damage Transfer. While it is grappl ing a creature, the rug takes
only half the damage dealt to it, and the creature grappled by
the rug takes the other half.",
                @"
False Appearance. While the rug remains motionless, it is
indistinguishable from a normal rug."
                ];
        }
    }
}
