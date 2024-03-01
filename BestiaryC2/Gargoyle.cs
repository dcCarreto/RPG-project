namespace Creatures.BestiaryC2
{
    internal class Gargoyle : Creatures
    {

        public Gargoyle()
        {
            Name = "Gargoyle";
            Type = el;
            Size = m;
            Alignment = ce;
            HitPoints = 52 + RollMultiple(8, 7) + 21;
            ArmorClass = 15;
            Speed = "30ft, fly 60ft";
            Attributes = [15, 11, 16, 6, 11, 7];
            ChallengeLevel = "2";
            Experience = 450;
            DamageResistances = "bludgeoning, piercing, and slashing from nonmagical weapons that aren`t adamantine";
            DamageImmunities = "poison";
            ConditionImmunities = "exhaustion, petrified, poisoned";
            Senses = "darkvision 60ft, passive Perception 10";
            Languages = "Terran";
            Actions = [
                @"
Multiattack. The gargoyle makes two attacks: one with its bite
and one with its claws.",
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
Hit: 5 (1d6 + 2) piercing damage.",
                @"
Claws. Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
Hit: 5 (1d6 + 2) slashing damage."
                ];
            Abilities = [
                @"
False Appearance. While the gargoyle remains motion less, it is
indistinguishable from an inanimate statue."
                ];
        }
    }
}
