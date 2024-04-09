using Base;

namespace BestiaryIndex.BestiaryC2
{
    internal class WillOWisp : Creature
    {
        public WillOWisp()
        {
            Name = "Will-o`-Wisp";
            Type = CreatureTypes.Undead;
            Size = Sizes.Tiny;
            Alignment = Alignments.ChaoticEvil;
            HitPoints = 22 + RollMultiple(4, 9);
            ArmorClass = 19;
            Speed = "0ft, fly 50ft (hover)";
            AttributeValue = [1, 28, 10, 13, 14, 11];
            ChallengeLevel = "2";
            Experience = 450;
            DamageResistances = "acid, cold, fire, necrotic, thunder, bludgeoning, piercing, slashing from nonmagical weapons";
            DamageImmunities = "lightning, poison";
            ConditionImmunities = "exhaustion, grappled, paralyzed, poisoned, prone, restrained, unconscious";
            Senses = "darkvision 120ft, passive Perception 12";
            Languages = "the languages it knew in life";
            Actions = [
                @"
Shock. Melee Spell Attack: +4 to hit, reach 5 ft., one creature.
Hit: 9 (2d8) lightning damage.",
                @"
Invisibility. The will -o'-wisp and its light magical ly become
invisible until it attacks or uses its Life Drai n, or until its
concentration ends (as if concentrating on a spell)."
                ];
            Abilities = [
                @"
Consume Life. As a bonus action, the will-o'-wisp can target
one creature it can see within 5 feet of it that has 0 hit
points and is still alive. The target must succeed on a DC 10
Constitution saving throw against this magic or die. If the
target dies, the will-o'-wisp regains 10 (3d6) hit points.",
                @"
Ephemeral. The will-o'-wisp can't wear or carry anything.",
                @"
Incorporeal Movement. The will-o'-wisp can move through
other creatures and objects as if they were difficu lt terrain. It
takes 5 (1d10) force damage if it ends its turn inside an object.",
                @"
Variable Illumination. The will-o'-wisp sheds bright light in a 5-
to 20-foot radius and dim light for an additional number offeet
equal to the chosen radius. The wil l-o'-wisp can alter the radius
as a bonus action."
                ];

        }
    }
}
