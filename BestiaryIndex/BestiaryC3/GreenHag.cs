using Base;

namespace BestiaryIndex.BestiaryC3
{
    internal class GreenHag : Creature
    {
        public GreenHag() 
        {
            Name = "Green Hag";
            Type = CreatureTypes.Fey;
            Size = Sizes.Medium;
            Alignment = Alignments.NeutralEvil;
            HitPoints = 82 + RollMultiple(8, 11) + 33;
            AttributeValue = [18, 12, 16, 13, 14, 14];
            ArmorClass = 17;
            Speed = "30ft";
            Experience = 700;
            ChallengeLevel = "3";
            Skills = "Arcana +3, Deception +4, Perception +4, Stealth +3";
            Senses = "darkvision 60ft, passive Perception 14";
            Languages = "Common, Draconic, Sylvan";
            HasMultiAttack = false;
            HasSaveOnAttack = true;
            Abilities =
                [
                @"
Amphibious. The hag can breath air and water.",
                @"
Innate Spellcasting. The hag`s innate spellcasting ability is Charisma (spell save DC 12).
She can innately cast the following spells, requiring no material components:
At will: dancing lights, minor illusion, vicious mockery.",
                @"
Mimicry. The hag can mimic animal sounds and humanoid voices. A creature that hears the
sounds can tell they are imitations with a successful DC 14 Wisdom (Insight) check."
                ];
            Actions =
                [
                @"
Claws. Melee Weapon Attacks: +6 to hit, reach 5ft, one target.
Hit: 13 (2d8 + 4) slashing damage",
                @"
Illusory Appearence. The hag covers herself and anuthing she is wearing or carrying with
a magical illusion that makes her look like another creature of her general size and
humanoid shape.
The illusion ends if the hag takes a bonus action to end it or if she dies.
The changes wrought by this effect fail to hold up to physical
inspection. For example, the hag could appear to have smooth
skin, but someone touching her would feel her rough flesh.
Otherwise, a creature must take an action to visually inspect
the illusion and succeed on a DC 20 Intelligence (Investigation)
check to discern that the hag is disguised.",
                @"
invisible Passage. The hag magically turns invisible until she attacks or casts a spell,
or until her concentration ends (as if concentrating on a spell). While invisible, she
leaves no physical evidence of her passage, so she can be tracked only by magic.
Any equipment she wears or carries is invisible with her."
                ];
            Attacks =
                [
                new(ActionList.Claws, DamageTypes.Slashing, RangeTypes.Melee, "2d8 + 4")
                ];
        }
    }
}
