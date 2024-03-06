namespace Creatures.BestiaryC1o8
{
    internal class TribalWarrior : Creature
    {

        public TribalWarrior()
        {
            Name = "Tribal Warrior";
            Type = hu;
            Size = m;
            Alignment = aa;
            HitPoints = 11 + (Roll(8 + 2)) + (Roll(8 + 2));
            Attributes = [13, 11, 12, 8, 11, 8];
            ArmorClass = 12;
            Speed = "30ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            Senses = "passive Perception 10";
            Languages = "any one language";
            Actions = [
                @"
Spear. Melee or Ranged Weapon Attack: + 3 to hit, reach 5ft or
ranged 20/60ft, one target.
Hit: 4 (1d6 +1) piercing damage, or 5 (1d8 + 1) piercing damage
if used with two hands to make a melee attack."
                ];
            Abilities = [
                @"                
                Pack Tactics. The warrior has advantage on an attack roll against
                a creature if at least one of the warrior's allies is within 5 ft
                of the creature and the ally isn't incapacitated.
                Senses. passive Perception 10.
                Languages. any one language."
            ];
        }
    }
}