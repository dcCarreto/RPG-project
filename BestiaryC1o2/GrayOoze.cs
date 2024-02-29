using Creatures.Main;

namespace Creatures.BestiaryC1o2
{
    internal class GrayOoze : Creatures
    {
        readonly Dices dice = new();
        public GrayOoze()
        {
            Name = "Gray Ooze";
            Type = oo;
            Size = m;
            Alignment = ud;
            HitPoints = 22 + dice.RollMultiple(8, 3) + 9;
            ArmorClass = 8;
            Speed = "10ft, climb 10ft";
            Attributes = [12, 6, 16, 1, 6, 2];
            ChallengeLevel = "1/2";
            Experience = 100;
            DamageResistances = "acid, cold, fire";
            ConditionImmunities = "blinded, charmed, deafened, exhaustion, fightened, prone";
            Skills = "Stealth +2";
            Senses = "blindsight 60ft (blind beyond this radius), passive Perception 8";
            Actions = [
                @"
Pseudopod. Melee Weapon Attack: +3 to hit, reach 5 ft., one
target. Hit: 4 (1d6 + 1) bludgeoning damage plus 7 (2d6)
acid damage, and if the target is wearing non magical metal
armor, its armor is partly corroded and takes a permanent
and cumulative -1 penalty to the AC it offers. The armor is
destroyed if the penalty reduces its ACto 10."
                ];
            Abilities = [
                @"
Amorphous. The ooze can move through a space as narrow as
1 inch wide without squeezing.",
                @"
Corrode Metal. Any non magical weapon made of metal that
hits the ooze corrodes. After dealing damage, the weapon
takes a permanent and cumulative -1 penalty to damage roll s.
If its penalty drops to -5, the weapon is destroyed. Non magical
ammunition made of metal that hits the ooze is destroyed after
dealing damage.
The ooze can eat through 2-inch-thick, non magical metal
in 1 round.",
                @"
False Appearance. Whi le the ooze remains motionless, it is
indistinguishable from an oily pool or wet rock."
                ];
        }
    }
}
