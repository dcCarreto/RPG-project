namespace Creatures.BestiaryC1o4
{
    internal class SteamMephit : Creatures
    {
        readonly Dices dice = new();
        public SteamMephit()
        {
            Name = "Steam Mephit";
            Type = el;
            Size = s;
            Alignment = ne;
            HitPoints = 21 + dice.RollMultiple(dice.d6, 6);
            ArmorClass = 10;
            Speed = "30ft, fly 30ft";
            Attributes = [5, 11, 10, 11, 10, 12];
            ChallengeLevel = "1/4";
            Experience = 50;
            DamageImmunities = "fire, poison";
            ConditionImmunities = "poisoned";
            Senses = "darkvision 60ft, passive Perception 10";
            Languages = "Aquan, Ignan";
            Actions = [
                @"
Claws. Melee Weapon Attack: +2 to hit, reach 5 ft, one creature.
Hit: 2 (ld4) slashing damage plus 2 (1d4) fire damage.",
                @"
Steam Breath (Recharge 6). The mephit exhales a 15foot cone
of scalding steam. Each creature in that area must succeed on
a DC 10 Dexterity saving throw, taking 4 (1d8) fire damage on
a failed save, or half as much damage on a successful one."];
            Abilities = [
                @"
Death Burst. When the mephit dies, it explodes in a cloud of
steam. Each creature within 5 feet of the mephit must succeed
on a DC 10 Dexterity saving throw or take 4 (ld8) fire damage.",
                @"
Innate Spellcasting (1/Day). The mephit can innately cast blur,
requiring no material components. Its innate spellcasting
ability is Charisma."
                ];
        }
    }
}
