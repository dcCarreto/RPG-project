using Creatures.Main;

namespace Creatures.BestiaryC1o4
{
    internal class SmokeMephit : Creatures
    {
        readonly Dices dice = new();
        public SmokeMephit()
        {
            Name = "Smoke Mephit";
            Type = el;
            Size = s;
            Alignment = ne;
            HitPoints = 22 + dice.RollMultiple(6, 5) + 5;
            ArmorClass = 12;
            Speed = "30ft, fly 30ft";
            Attributes = [6, 14, 12, 10, 10, 11];
            ChallengeLevel = "1/4";
            Experience = 50;
            DamageImmunities = "fire, poison";
            ConditionImmunities = "poisoned";
            Skills = "Perception +2, Stealth +4";
            Senses = "darkvision 60ft, passive Perception 12";
            Languages = "Aquan, Ignan";
            Actions = [
                @"
Claws. Melee Weapon Attack: +4 to hit, reach 5 ft, one
creature. Hit: 4 (1d4 + 2) slashing damage.",
                @"
Cinder Breath (Recharge 6). The mephit exhales a 15-foot cone
of smoldering ash. Each creature in that area must succeed on
a DC 10 Dexterity saving throw or be blinded until the end of
the mephit's next turn ."];
            Abilities = [
                @"
Death Burst. When the mephit dies, it leaves behind a cloud
of smoke that fills a 5ft radius sphere centered on its space.
The sphere is heavily obscured. Wind disperses the cloud,
which otherwise lasts for 1 minute.",
                @"
Innate Spellcasting (1/Day). The mephit can innately cast
dancing lights, requiring no material components. Its innate
spellcasting ability is Charisma."
                ];


        }
    }
}
