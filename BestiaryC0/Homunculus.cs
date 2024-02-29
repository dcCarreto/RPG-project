using Creatures.Main;

namespace Creatures.BestiaryC0
{
    internal class Homunculus : Creatures
    {
        readonly Dices dice = new();
        public Homunculus()
        {
            Name = "Homunculus";
            Type = co;
            Size = t;
            Alignment = n;
            HitPoints = 5 + dice.RollMultiple(4, 2);
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
        }
    }
}
