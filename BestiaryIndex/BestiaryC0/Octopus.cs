using Base;
namespace BestiaryIndex.BestiaryC0
{
    internal class Octopus : Creature
    {

        public Octopus()
        {
            Name = "Octopus";
            Type = Types.Beast;
            Size = Sizes.Small;
            Alignment = Alignments.Unaligned;
            HitPoints = 3 + Roll(6);
            AttributeValue = [4, 15, 11, 3, 10, 4];
            ArmorClass = 12;
            Speed = "5ft, swim 30ft";
            Experience = 10;
            ChallengeLevel = "0";
            Skills = "Perception +@, Stealth +4";
            Senses = "darkvision 30ft, passive Perception 12";
            Actions = [
            @"
Tentacles. Melee Weapon Attack: +4 to hit, reach 5 ft. , one target.
Hit: 1 bludgeoning damage, and the target is grappled (escape DC 10).
Until this grapple ends, the octopus can 't use its tentacles on another target.",
@"
Ink Cloud (Recharges after a Short or Long Rest). A 5-foot· radius cloud of ink
extends all around the octopus if it is underwater. The area is heavily obscured
for 1 minute, although a significant current can disperse the ink.
After releasing the ink, the octopus can use the Dash action as a bonus action."
            ];
            HasMultiAttack = false;
            HasSaveOnAttack = true;
            Abilities = [
                @"
Hold Breath. While out of water, the octopus can hold its breath for 30 minutes.",
                @"
Underwater Camouflage. The octopus has advantage on Dexterity (Stealth) checks made while underwater.",
                @"
Water Breathing. The octopus can breathe only underwater."
            ];
            Attacks = 
            [
                new ( AttackList.Tentacles, DamageTypes.Bludgeoning, RangeTypes.Melee, "1d1", 4, 5, DamageTypes.Bludgeoning, "1d1", 10, AttributeName.Strenght)
            ];
        }
    }
}