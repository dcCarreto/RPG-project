using Creatures.Main;

namespace Creatures.BestiaryC1o4
{
    internal class MudMephit : Creatures
    {
        readonly Dices dice = new();
        public MudMephit()
        {
            Name = "Mud Mephit";
            Type = el;
            Size = s;
            Alignment = ne;
            HitPoints = 27 + dice.RollMultiple(6, 6) + 6;
            ArmorClass = 11;
            Speed = "20ft, fly 20ft, swim 20ft";
            Attributes = [8, 12, 12, 9, 11, 7];
            ChallengeLevel = "1/4";
            Experience = 50;
            DamageImmunities = "poison";
            ConditionImmunities = "poisoned";
            Skills = "Stealth +3";
            Senses = "darkvision 60ft, passive Perception 10";
            Languages = "Aquan, Terran";
            Actions = [
                @"
Fists. Melee Weapon Attack: +3 to hit, reach 5ft, one creature.
Hit: 4 (1d6 +1) bludgeoning damage.",
                @"
Mud Breath (Recharge 6): The mephit belches viscid mud onto one
creature within 5ft of it. If the target is Medium or smaller,
it must succeed on a DC 11 Dexterity saving throw or be restrained
for 1 minute. A creature can repeat the saving throw at the end
of its turns, ending the effect on itself on a success."
                ];
            Abilities = [
                @"
Death Burst. When the mephit dies, it explodes in a burst of sticky
mud. Each Medium or smaller creature within 5ft of it must succeed
on a DC 11 Dexterity saving throw or be restrained until the end
of the creature's next turn.",
                @"
False Appearence. While the mephit reamins motionless, it is
indistinguishable from an ordinary mound of mud."
                ];

        }
    }
}
