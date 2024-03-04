namespace Creatures.BestiaryC2
{
    internal class GithzeraiMonk : CreatureAttributes
    {

        public GithzeraiMonk()
        {
            Name = "Githzerai Monk";
            Type = hu;
            Size = m;
            Alignment = ln;
            HitPoints = 38 + RollMultiple(8, 7) + 7;
            ArmorClass = 14;
            Speed = "30ft";
            Attributes = [12, 15, 12, 13, 14, 10];
            ChallengeLevel = "2";
            Experience = 450;
            SavingThrows = "Strength +3, Dexterity +4, Intelligence +3, Wisdom +4";
            Skills = "Insight +4, Perception +4";
            Senses = "passive Perception 14";
            Languages = "Gith";
            Actions = [
                @"
Multiattack. The githzerai makes two unarmed strikes.",
                @"
Unarmed Strike. Melee Weapon Attack: +4 to hit, reach 5 ft. ,
one target. Hit: 6 (1d8 + 2) bludgeoning damage plus 9 (2d8)
psychic damage. This is a magic weapon attack."
                ];
            Abilities = [
                @"
Innate Spellcasting (Psionics). The githzerai's innate
spellcasting ability is Wisdom. It can innately cast the following
spells, requiring no components:
At will : mage hand (the hand is invisible)
3Jday each: f eather fall, jump, see invisibility, shield",
                @"
Psychic Defense. While the githzerai is wearing no armor and
wielding no shield , its AC includes its Wisdom modifier."
                ];
        }
    }
}
