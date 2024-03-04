namespace Creatures.BestiaryC1
{
    internal class ThriKreen : CreatureAttributes
    {

        public ThriKreen()
        {
            Name = "Thri-Kreen";
            Type = hu;
            Size = m;
            Alignment = cn;
            HitPoints = 33 + RollMultiple(8, 6) + 6;
            ArmorClass = 15;
            Speed = "40ft";
            Attributes = [12, 15, 13, 8, 12, 7];
            ChallengeLevel = "1";
            Experience = 200;
            Skills = "Perception +3, Stealth +4, Survival +3";
            Senses = "darkvision 60ft, passive Perception 13";
            Languages = "Thri-Kreen";
            Actions = [
                @"
Multiattack. The thri-kreen makes two attacks: one with its
bite and one with its claws.",
                @"
Bite. Melee Weapon Attack: +3 to hit, reach 5 ft., one creature.
Hit: 4 (1d6 + 1) piercing damage, and the target must succeed
on a DC 11 Constitution saving throw or be poisoned for 1
minute. lfthe saving throw fails by 5 or more, the target is also
paralyzed while poisoned in this way. The poisoned target can
repeat the saving throw on each of its turns , ending the effect
on itself on a success.",
                @"
Claws. Melee Weapon Attack: +3 to hit, reach 5 ft. , one target.
Hit: 6 (2d4 + 1) slashing damage."
                ];
            Abilities = [
                @"
Chameleon Carapace. The thri-kreen can change the color of
its carapace to match the color and texture of its surroundings.
As a r""esult, it has advantage on Dexterity (Stealth) checks
made to hide.",
                @"
Standing Leap. The thri-kreen's long jump is up to 30 feet and
its high jump is up to 15 feet, with or without a running start."
                ];
        }
    }
}
