namespace Creatures.BestiaryC1o2
{
    internal class GasSpore : Creature
    {

        public GasSpore()
        {
            Name = "Gas Spore";
            Type = Types.Plant;
            Size = Sizes.Large;
            Alignment = Alignments.Unaligned;
            HitPoints = 1 + Roll(10) - 4;
            ArmorClass = 5;
            Speed = "0ft, fly 10ft (hover)";
            Attributes = [5, 1, 3, 1, 1, 1];
            ChallengeLevel = "1/2";
            Experience = 100;
            DamageImmunities = "poison";
            ConditionImmunities = "blinded, deafened, frightened, paralyzed, poisoned, prone";
            Senses = "blindsight 30ft (blind beyond this radius), passive Perception 5";
            Actions = [
                @"
Touch. Melee Weapon Attack: +0 to hit, reach 5 ft. , one
creature. Hit: 1 poison damage, and th e creature must succeed
on a DC 10 Constitution saving throw or become infected with
the disease described in the Death Burst trait."
                ];
            Abilities = [
                @"
Death Burst. The gas spore explodes when it drops to 0 hit
points. Each creature within 20 feet of it must succeed on a DC
15 Constitution saving throw or take 10 (3d6) poison damage
and become infected with a disease on a failed save. Creatures
immune to the poisoned condition are immune to this disease.
Spores invade an infected creature's system, killing the
creature in a number of hours equal to 1d12 +the creature's
Constitution score, unless the disease is removed. In half
that time, the creature becomes poisoned for the rest of the
duration. After the creature dies, it sprouts 2d4 Tiny gas spores
that grow to full s ize in 7 days.",
                @"
Eerie Resemblance. The gas spore resembles a beholder. A
creature that can see the gas spore can discern its true nature
with a successful DC 15 Intell igence (Nature) check."
                ];
        }
    }
}
