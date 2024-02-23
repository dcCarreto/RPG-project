using static System.Net.Mime.MediaTypeNames;
using System;

namespace Creatures.BestiaryC1o4
{
    internal class Bullywug : Creatures
    {
        readonly Dices dice = new();
        public Bullywug()
        {
            Name = "Bullywug";
            Type = hu;
            Size = m;
            Alignment = ne;
            HitPoints = 11 + dice.RollMultiple(dice.d8, 2 + 2);
            Attributes = [12, 12, 13, 7, 10, 7];
            ArmorClass = 15;
            Speed = "20ft, swim 40ft";
            Experience = 50;
            ChallengeLevel = "1/4";
            Skills = "Stealth +3";
            Senses = "passive Perception 10";
            Languages = "Bullywug";
            Actions = [
                @"
Bite.Melee Weapon Attack: +3 to hit, reach 5ft, one target.
Hit: 3(1d4 + 1) bludgeoning damage.",
@"
Spear.Melee or Ranged Weapon Attack: +3 to hit, reach 5ft
or ranged 20 / 60ft, one target.
Hit: 4(1d6 + 1), piercing damage, or 5(1d8 + 1) piercing
damage if used with two hands to make a melee attack.",
@"
Multiattack.The bullywug makes two melee attacks: one
with its bite and one with its spear."
];
            Abilities = [
                @"
Amphibious. The bullywug can breath air and water.
Speak with Frogs and Toads. The bullywug can communicate
simple concepts to frogs and toads when it speaks in Bullywug.",
@"
Swamp Camouflage. The bullywug had advantage on Dexterity
(Stealth) checks made to hide in swampy terrain.",
@"Standing Leap. The bullywug`s long jump is up to 20 feet
and its high jump is up to 10 feet, with or without a
running start."
            ];

                
        }
    }
}
