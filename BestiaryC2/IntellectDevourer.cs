namespace Creatures.BestiaryC2
{
    internal class IntellectDevourer : Creature
    {

        public IntellectDevourer()
        {
            Name = "Intellect Devourer";
            Type = Types.Aberration;
            Size = Sizes.Tiny;
            Alignment = Alignments.LawfulEvil;
            HitPoints = 21 + RollMultiple(4, 6) + 6;
            ArmorClass = 12;
            Speed = "40ft";
            Attributes = [6, 14, 13, 12, 11, 10];
            ChallengeLevel = "2";
            Experience = 450;
            DamageResistances = "bludgeoning, piercing and slashing from nonmagical weapons";
            ConditionImmunities = "blinded";
            Skills = "Perception +2, Stealth +4";
            Senses = "blindsight 60ft (blind beyond this radius), passive Perception 12";
            Languages = "understands Deep Speech but can`t speak, telepathy 60ft";
            Actions = [
                @"
Multiattack. The intellect devourer makes one attack with its
claws and uses Devour Intellect.",
@"
Claws. Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
Hit: 7 (2d4 + 2) slashing damage.",
@"
Devour Intellect. The intellect devourer targets one creature
it can see within 10 feet of it that has a brain. The target must
succeed on a DC 12 Intelligence saving throw aga inst this
magic or take 11 (2d10) psychic damage. Also on a failure,
roll3d6: If the total equals or exceeds the target's Intelligence
score, that score is reduced to 0. The target is stunned until it
regains at least one point of Intelligence.",
@"
Body Thief. The intellect devourer initiates an Intelligence
contest with an incapacitated humanoid within 5 feet of it. If
it wins the contest, the intellect devourer magically consumes
the target's brain, teleports into the target's skull, and takes
control of the target's body. While inside a creature, the
intellect devourer has total cover against attacks and other
effects originating outs ide its host. The intellect devourer
retains its Intelligence, Wisdom, and Charisma scores, as
wel l as its understanding of Deep Speech, its telepathy, and
its traits. It otherwise adopts the target's statistics. It knows
everyth ing the creature knew, including spel ls and languages.
If the host body drops to 0 hit points, the intellect devourer
must leave it. A protection from evil and good spell cast on the
body drives the intellect devourer out. The intellect devourer
is also forced out if the target regains its devoured brain by
means of a wish. By spending 5 feet of its movement, the
intellect devourer can voluntarily leave the body, teleporting to
the nearest unoccupied space within 5 feet of it. The body then
dies, unless its brain is restored within 1 round."
                ];
            Abilities = [
                @"
Detect Sentience. The intellect devourer can sense the
presence and location of any creature within 300 feet of it that
has an Intelligence of 3 or higher, regardless of interposing
barriers, unless the creature is public by a mind blank spell."
                ];
        }
    }
}
