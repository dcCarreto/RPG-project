 

namespace Base.BestiaryC0
{
    internal class Homunculus : Creature
    {

        public Homunculus()
        {
            Name = "Homunculus";
            Type = Types.Construct;
            Size = Sizes.Tiny;
            Alignment = Alignments.Neutral;
            HitPoints = 5 + RollMultiple(4, 2);
            Attributes = [4, 15, 11, 10, 10, 10];
            ArmorClass = 13;
            Speed = "20ft, fly 40ft";
            Experience = 10;
            ChallengeLevel = "0";
            DamageImmunities = "poison";
            ConditionImmunities = "charmed, poisoned";
            Senses = "darkvision 60ft, passive Perception 10";
            Languages = "understands the languages of its creator but can't speak.";
            Actions = [
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft., one creature. Hit: 1 piercing damage,
and the target must succeed on a DC 10 Constitution saving th row or be poisoned for 1 minute.
If the saving throw fails by 5 or more, the target is instead poisoned for 5 (1d10), minutes
and unconscious while poisoned in this way.
"
];
            Abilities = [
                @"
Telepathic Bond. While the homunculus is on the same plane of existence as its master,
it can magically convey what it senses to its master, and the two can communicate telepathically."
            ];
            Attacks = new List<Attack>
            {
                new Attack ( AttackList.Bite, DamageTypes.Slashing, RangeTypes.Melee, "1d2")
            };
        }
    }
}
