using Base;
namespace BestiaryIndex.BestiaryC1
{
    internal class QuaggothSporeServant : Creature
    {

        public QuaggothSporeServant()
        {
            Name = "Quaggoth Spore Servant";
            Type = CreatureTypes.Plant;
            Size = Sizes.Medium;
            Alignment = Alignments.Unaligned;
            HitPoints = 45 + RollMultiple(8, 6) + 18;
            ArmorClass = 13;
            Speed = "20ft, climb 20ft";
            AttributeValue = [17, 12, 16, 2, 6, 1];
            ChallengeLevel = "1";
            Experience = 200;
            DamageImmunities = "poison";
            ConditionImmunities = "blinded, charmed, frightened, paralyzed, poisoned";
            Senses = "blindsight 30ft (blind beyond this radius), passive Perception 8";
            Actions = [
                @"
Multiattack. The spore servant makes two claw attacks.",
                @"
Claw. Melee Weapon Attack: +5 to hit, reach 5 ft., one target.
Hit: 6 (1d6 + 3) slashing damage."
                ];
        }
    }
}
