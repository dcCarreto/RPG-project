namespace Creatures.BestiaryC1
{
    internal class FaerieDragon : Creature
    {

        public FaerieDragon()
        {
            Name = "Faerie Dragon";
            Type = dr;
            Size = t;
            Alignment = cg;
            HitPoints = 14 + RollMultiple(4, 4) + 4;
            ArmorClass = 15;
            Speed = "10ft, fly 60ft";
            Attributes = [3, 20, 13, 14, 12, 16];
            ChallengeLevel = "1";
            Experience = 200;
            Skills = "Arcana +4, Perception +#, Stealth +7";
            Senses = "darkvision 60ft, passive Perception 13";
            Languages = "Draconic, Sylvan";
            Actions = [
                @"
Bite. Melee Weapon Attack: +7 to hit, reach 5 ft ., one creature.
Hit: 1 piercing damage.",
@"
Euphoria Breath (Recharge 5-6). The dragon exhales a puff of
euphoria gas at one creature within 5 feet of it. The target must
succeed on a DC 11 Wisdom saving throw, or for 1 minute, the
target can't take reactions and must roll a 6 at the start of
each of its turns to determine its behavior during the turn:
1-4. The target takes no action or bonus action and uses all
of its movement to move in a random direction.
5- 6. The target doesn't move, and the only thing it can do
on its turn is make a DC 11 Wisdom saving throw, ending the
effect on itself on a success."
                ];
            Abilities = [
                @"
Superior Invisibility. As a bonus action, the dragon can
magically turn invi si ble until its concentration ends (as if
concentrating on a spell). Any equipment the dragon wears or
carries is invisible with it.",
@"
Limited Telepathy. Using telepathy, the dragon can magically
communicate with any other faerie dragon within 60 feet of it.",
@"
Magic Resistance. The dragon has advantage on saving throws
against spells and other magical effects.",
@"
Innate Spellcasting. The dragon's innate spellcasting ability is
Charisma (spell save DC 13). It can innately cast a number of
spells, requiring no material components. As the dragon ages
and changes color, it gains additional spells as shown below.
Red, ljday each: dancing lights, mage hand, minor illusion
Orange, lfday: color spray
Yellow, ljday: mirror image
Green, ljday: suggestion
Blue, ljday: major image
Indigo, ljday: hallucinatory terrain
Violet, ljday: polymorph"
                ];
        }
    }
}
