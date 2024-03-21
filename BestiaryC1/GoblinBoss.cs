namespace Base.BestiaryC1
{
    internal class GoblinBoss : Creature
    {

        public GoblinBoss()
        {
            Name = "Goblin Boss";
            Type = Types.Humanoid;
            Size = Sizes.Small;
            Alignment = Alignments.NeutralEvil;
            HitPoints = 21 + RollMultiple(6, 6);
            ArmorClass = 17;
            Speed = "30ft";
            Attributes = [10, 14, 10, 10, 8, 10];
            ChallengeLevel = "1";
            Experience = 200;
            Actions = [
                @"
Multiattack. The goblin makes two attacks with its scimitar.
The second attack has disadvantage.",
@"
Scimitar. Melee Weapon Attack: +4 to hit, reach 5 ft., one
target. Hit: 5 (1d6 + 2) slashing damage.",
@"
javelin. Melee or Ranged Weapon Attack: +4 to hit, reach 5 ft. or
range 30/120 ft., one target. Hit: 5 (1d6 + 2) piercing damage."
                ];
            Reactions = @"
Redirect Attack. When a creature the goblin can see targets
it with an attack, the goblin chooses another goblin within 5
feet of it. The two goblins swap places, and the chosen goblin
becomes the target instead.";
            Abilities = [
                @"
Nimble Escape. The goblin can take the Disengage or Hide
action as a bonus action on each of its turns."
                ];
        }
    }
}
