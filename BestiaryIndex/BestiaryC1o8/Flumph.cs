using Base;

namespace BestiaryIndex.BestiaryC1o8
{
    internal class Flumph : Creature
    {

        public Flumph()
        {
            Name = "Flumph";
            Type = Types.Aberration;
            Size = Sizes.Small;
            Alignment = Alignments.LawfulGood;
            HitPoints = 7 + RollMultiple(6, 2);
            AttributeValue = [6, 15, 10, 14, 14, 11];
            ArmorClass = 12;
            Speed = "5ft, fly 30ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            DamageVulnerabilities = "psychic";
            Skills = "Arcana +4, History +4, Religion +4";
            Senses = "darkvision 60ft, passive Perception 12";
            Languages = "understands Undercommon but can't speak, telepathy 60ft";
            Actions = [
                @"
Tendrils. Melee Weapon Attack: +4 to hit, reach 5ft, one creature.
Hit: 4 (1d4 + 2) piercing damage plus 2 (1d4) acid damage.
At the end of each of its turns, the target must make a DC 10 Constitution saving throw,
taking 2 + (1d4) acid damage on a failure or ending the recurring acid damage on a success.
A lesser restoration spell cast on the target also ends the recurring acid damage.",
                @"
Stench Spray (1/Day). Each creature in a 15-foot cone originating from the Flumph must succeed
n a DC 10 Dexterity saving throw or be coated in a foul-smelling liquid.
A coated creature exudes a horrible stench for 1d4(hours).
The coated creature is poisoned as long as the stench lasts, and other creatures are poisoned
while within 5 feet of the coated creature.
A creature can remove the stench on itself by using a short rest to bathe in water, alcohol or vinegar."
                ];
            HasMultiAttack = false;
            HasSaveOnAttack = true;
            Abilities = [
                @"
Advanced Telepathy. The Flumph can perceive the content of any telepathic communication used within 60 feet
of it, and it can`t be surprised by creatures with any form of telepathy.",
                @"
Prone Deficiency. If the Flumph is knocked prone, roll a die.
On an odd result, the Flumph lands upside-down and is incapacitated.
At the end of each of its turns, the Flumph can make a DC 10 Dexterity saving throw, righting itself
and ending the incapacitaded condition if it succeeds.",
                @"
Telepathic Shroud. The Flumph is immune to any effect that would sense its emotions or read its thoughts,
 as well as all divination spells."
                ];
            Attacks =
            [
                new (AttackList.Tendrils, DamageTypes.Piercing,RangeTypes.Melee, "1d4 + 2", 4, 5, DamageTypes.Acid, "1d4", 10, AttributeName.Constitution)
            ];
        }
    }
}