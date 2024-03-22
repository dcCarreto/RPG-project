using Base;

namespace BestiaryIndex.BestiaryC1o2
{
    internal class DustMephit : Creature
    {

        public DustMephit()
        {
            Name = "Dust Mephit";
            Type = Types.Elemental;
            Size = Sizes.Small;
            Alignment = Alignments.NeutralEvil;
            HitPoints = 17 + RollMultiple(6, 5);
            ArmorClass = 12;
            Speed = "30ft, fly 30ft";
            AttributeValue = [5, 14, 10, 9, 11, 10];
            ChallengeLevel = "1/2";
            Experience = 100;
            DamageVulnerabilities = "fire";
            DamageImmunities = "poison";
            ConditionImmunities = "poisoned";
            Skills = "Perception + 2, Stealth +4";
            Senses = "darkvision 60ft, passive Perception 12";
            Languages = "Auran, Terran";
            Actions = [
                @"
Claws. Melee Weapon Attack: +4 to hit, reach 5 ft. , one
creature. Hit: 4 (1d4 + 2) slashing damage.",
                @"
Blinding Breath (Recharge 6). The mephit exhales a 15-foot
cone of blinding dust. Each creature in that area must succeed
on a DC 10 Dexterity saving throw or be blinded for 1 minute.
A creature can repeat the saving throw at the end of each of its
turns, ending the effect on itself on a success."
                ];
            Abilities = [
                @"
Death Burst. When the mephit dies, it explodes in a burst of
dust. Each creature within 5 feet of it must then succeed on a
DC 10 Constitution saving throw or be blinded for 1 minute.
A blinded creature can repeat the saving throw on each of its
turns, ending the effect on itself on a success.",
                @"
Innate Spe/lcasting (1jDay). The mephit can innately cast sleep,
requiring no material components. Its innate spellcasting
ability is Charisma."
                ];
        }
    }
}
