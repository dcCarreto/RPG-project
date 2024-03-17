namespace Creatures.BestiaryC2
{
    internal class OchreJelly : Creature
    {
        public OchreJelly()
        {
            Name = "Ochre Jelly";
            Type = Types.Ooze;
            Size = Sizes.Large;
            Alignment = Alignments.Unaligned;
            HitPoints = 45 + RollMultiple(10, 6) + 12;
            ArmorClass = 8;
            Speed = "10ft, climb 10ft";
            Attributes = [15, 6, 14, 2, 6, 1];
            ChallengeLevel = "2";
            Experience = 450;
            DamageResistances = "acid";
            DamageImmunities = "lightning, slashing";
            ConditionImmunities = "blinded, charmed, deafened, exhaustion, frightened, prone";
            Senses = "blindsight 60ft (blind beyond this raidus), passive Perception 8";
            Actions = [
                @"
Pseudopod. Melee Weapon Attack: +4 to hit, reach 5 ft., one
target. Hit: 9 (2d6 + 2) bludgeoning damage plus 3 (ld6)
acid damage."
                ];
            Reactions = @"
Split. When a jelly that is Medium or larger is subjected to lightning
or slashing damage, it splits into two new jel lies if it has at least 10 hit points.
Each new jelly has hit points equal to half the original jelly's, rounded down.
New jellies are one size smaller than the original jelly.";
            Abilities = [
                @"
Amorphous. The jelly can move through a space as narrow as 1
inch wide without squeezing.",
                @"
Spider Climb. The jelly can climb difficult surfaces, including
upside down on ceilings, without needing to make an
abi lity check."
                ];
        }


    }
}
