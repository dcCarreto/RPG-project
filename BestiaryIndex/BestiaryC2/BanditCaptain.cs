using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;

namespace BestiaryIndex.BestiaryC2
{
    internal class BanditCaptain : Creature
    {
        public BanditCaptain()
        {
            Name = "Bandit Captain";
            Type = Types.Humanoid;
            Size = Sizes.Medium;
            Alignment = Alignments.AnyNonGoodAlignment;
            HitPoints = 65 + RollMultiple(8, 10) + 20;
            ArmorClass = 15;
            Speed = "30ft";
            AttributeValue = [15, 16, 14, 14, 11, 14];
            ChallengeLevel = "2";
            Experience = 450;
            SavingThrows = "Strength +4, Dexterity +5, Wisdom +2";
            Skills = "Athletics +4, Deception +4";
            Senses = "passive Perception 10";
            Languages = "any two languages";
            Actions = [
                @"
Multiattack. The captain makes three melee attacks: two with
its scimitar and one with its dagger. Or the captain makes two
ranged attacks with its daggers.",
@"
Scimitar. Melee Weapon Attack: +5 to hit, reac h 5 ft., one
target. Hit: 6 (ld6 + 3) slash ing damage.",
@"
Dagger. Melee or Ranged Weapon Attack: +5 to hit, reach 5 ft.
or range 20/60 ft., one target. Hit: 5 (1d4 + 3) piercing damage."
                ];
            Reactions =
                @"
Parry. The captain adds 2 to its AC against one melee attack
that would hit it. To do so, the captain must see the attacker
and be wielding a melee weapon.";
        }
    }
}
