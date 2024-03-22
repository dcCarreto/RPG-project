using Base;

namespace BestiaryIndex.BestiaryC2
{
    internal class Wererat : Creature
    {

        public Wererat()
        {
            Name = "Wererat";
            Type = Types.Humanoid;
            Size = Sizes.Medium;
            Alignment = Alignments.LawfulEvil;
            HitPoints = 33 + RollMultiple(8, 6) + 6;
            ArmorClass = 12;
            Speed = "30ft";
            AttributeValue = [10, 15, 12, 11, 10, 8];
            ChallengeLevel = "2";
            Experience = 450;
            DamageImmunities = "bludgeoning, piercing and slashing from nonmagical weapons that aren`t silvered";
            Skills = "Perception +2, Stealth +4";
            Senses = "darkvision 60ft (rat form), passive Perception 12";
            Languages = "Common (can`t speak in rat form)";
            Actions = [
                @"
Multiattack (Humanoid or Hybrid Form Only). The were rat
makes two attacks, only one of which can be a bite.",
                @"
Bite (Rat or Hybrid Form Only). Melee Weapon Attack:
+4 to hit, reach 5 ft., one target. Hit: 4 (1 d4 + 2) piercing
damage. If the target is a humanoid, it must succeed on a
DC 11 Constitution saving throw or be cursed with were rat
lycanthropy.",
                @"
Shortsword (Humanoid or Hybrid Form Only). Melee Weapon
Attack: +4 to hit, reach 5 ft., one target. Hit: 5 (1d6 + 2)
piercing damage.",
                @"
Hand Crossbow (Humanoid or Hybrid Form Only). Ranged
Weapon Attack: +4 to hit, range 30/120 ft., one target. Hit: 5
(1d6 + 2) piercing damage."
                ];
            Abilities = [
                @"
Shapechanger. The wererat can use its action to polymorph
into a rat-humanoid hybrid or into a giant rat, or back into its
true form, which is humanoid. Its statistics, other than its
size, are the same in each form. Any equipment it is wearing or
carrying isn't transformed. It reverts to its true form if it dies.",
@"
Keen Smell. The were rat has advantage on Wisdom
(Perception) checks that rely on smell."
                ];
        }
    }
}
