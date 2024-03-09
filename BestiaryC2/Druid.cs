namespace Creatures.BestiaryC2
{
    internal class Druid : Creature
    {
        public Druid() 
        {
            Name = "Druid";
            Type = Types.Humanoid;
            Size = Sizes.Medium;
            Alignment = Alignments.AnyAlignment;
            HitPoints = 27 + RollMultiple(8, 5) + 5;
            ArmorClass = 11;
            Speed = "30ft";
            Attributes = [10, 12, 13, 12, 15, 11];
            ChallengeLevel = "2";
            Experience = 450;
            Skills = "Medicide +4, Nature +3, Perception +4";
            Senses = "passive Perception 14";
            Languages = "Druidic plus any two languages";
            Actions = [
                @"
Quarterstaff. Melee Weapon Attack: +2 to hit (+4 to hit with
shillelagh), reach 5 ft ., one target. Hit: 3 (1d6) bludgeoning
damage, or 4 (1d8) bludgeoning damage with shillelagh or if
wielded with two hands."
                ];
            Abilities = [
                @"
Spellcasting. The druid is a 4th-level spellcaster. Its
spellcasting ability is Wisdom (spell save DC 12, +4 to hit with
spell attacks). It has the following druid spells prepared:
Cantrips (at will): druidcraft, produce flame, shillelagh
1st level (4 slots): entangle, longstrider, speak with
animals, thunderwave
2nd level (3 slots): animal messenger, barkskin"
                ];
        }
    }
}
