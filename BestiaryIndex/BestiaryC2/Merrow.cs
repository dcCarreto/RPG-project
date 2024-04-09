using Base;

namespace BestiaryIndex.BestiaryC2
{
    internal class Merrow : Creature
    {

        public Merrow()
        {
            Name = "Merrow";
            Type = CreatureTypes.Monstruosity;
            Size = Sizes.Large;
            Alignment = Alignments.ChaoticEvil;
            HitPoints = 45 + RollMultiple(10, 6) + 12;
            ArmorClass = 13;
            Speed = "10ft, swim 40ft";
            Senses = "darkvision 60ft, passive Perception 12";
            Languages = "Abyssal, Aquan";
            Actions = [
                @"
Multiattack. The merrow makes two attacks: one with its bite
and one with its claws or harpoon.",
                @"
Bite. Melee Weapon Attack: +6 to hit, reach 5 ft ., one target.
Hit: 8 (1d8 + 4) piercing damage.",
                @"
Claws. Melee Weapon Attack: +6 to hit, reach 5 ft., one target.
Hit: 9 (2d4 + 4) slashing damage.",
                @"
Harpoon. Melee or Ranged Weapon Attack: +6 to hit, reach
5 ft. or range 20/60 ft., one target. Hit: 11 (2d6 + 4) piercing
damage. If the target is a Huge or smaller creature, it must
succeed on a Strength contest against the merrow or be pulled
up to 20 feet toward the merrow."
                ];
            Abilities = [
                @"
Amphibious. The merrow can breathe air and water."
                ];
        }
    }
}
