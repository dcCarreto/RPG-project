namespace Creatures.BestiaryC1o4
{
    internal class PseudoDragon : Creature
    {

        public PseudoDragon()
        {
            Name = "Pseudodragon";
            Type = Types.Dragon;
            Size = Sizes.Tiny;
            Alignment = Alignments.NeutralGood;
            HitPoints = 7 + RollMultiple(4, 2) + 2;
            ArmorClass = 13;
            Speed = "15ft, fly 60ft";
            Attributes = [6, 15, 13, 10, 12, 10];
            ChallengeLevel = "1/4";
            Experience = 50;
            Skills = "Perception +3, Stealth +4";
            Senses = "blindsight 10ft, darkvision 60ft, passive Perception 13";
            Languages = "understands Common and Draconic but can't speak";
            Actions = [
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
Hit: 4 (1d4 + 2) piercing damage.",
@"
Sting. Melee Weapon Attack: +4 to hit, reach 5 ft, one creature.
Hit: 4 (1d4 + 2) piercing damage, and the target must succeed
on a DC 11 Constitution saving throw or become poisoned for
1 hour. If the saving throw fails by 5 or more, the target falls
unconscious for the same duration, or until it takes damage or
another creature uses an action to shake it awake."
                ];
            Abilities = [
                @"
Keen Senses. The pseudodragon has advantage on Wisdom
(Perception) checks that rely on sight, hearing, or smell.",
                @"
Magic Resistance. The pseudodragon has advantage on saving
throws against spells and other magical effects.",
                @"
Limited Telepathy. The pseudodragon can magically
communicate simple ideas, emotions, and images
telepathically with any creature within 100 feet of it that can
understand a language."
                ];
        }
    }
}
