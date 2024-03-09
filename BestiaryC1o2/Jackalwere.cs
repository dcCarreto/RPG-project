namespace Creatures.BestiaryC1o2
{
    internal class Jackalwere : Creature
    {

        public Jackalwere()
        {
            Name = "Jackalwere";
            Type = Types.Humanoid;
            Size = Sizes.Medium;
            Alignment = Alignments.ChaoticEvil;
            HitPoints = 18 + RollMultiple(8, 4);
            ArmorClass = 12;
            Speed = "40ft";
            Attributes = [11, 15, 11, 13, 11, 10];
            ChallengeLevel = "1/2";
            Experience = 100;
            DamageImmunities = "bludgeoning, piercing, and slashing damage from nonmagical weapons that aren't silvered";
            Skills = "Deception +4, Perception +2, Stealth +4";
            Senses = "passive Perception 12";
            Languages = "Common (can't speak in jackal form";
            Actions = [
                @"
Bite ljackal or Hybrid Form Only). Melee Weapon Attack: +4 to
hit, reach 5 ft., one target. Hit: 4 (1d4 + 2) piercing damage .",
                @"
Bite ljackal or Hybrid Form Only). Melee Weapon Attack: +4 to
hit, reach 5 ft., one target. Hit: 4 (1d4 + 2) piercing damage .",
                @"
Sleep Gaze. The jackalwere gazes at one creature it can see
within 30 feet of it. The target must make a DC 10 Wisdom
saving throw. On a failed save, the target succumbs to a
magical slumber, falling unconscious for 10 minutes or until
someone uses an action to shake the target awake. A creature
that successfully saves against the effect is immune to this
jacka lwere's gaze for the next 24 hours. Undead and creatures
immune to being charmed aren't affected by it."
                ];
            Abilities = [
                @"
Shapechanger. The jackalwere can use its action to polymorph
into a specific Medium human or a jackal-humanoid hybrid, or
back into its true form (that of a Small jackal). Other than its
size, its statistics are the same in each form . Any equipment
it is wearing or carrying isn 't transformed . It reverts to its true
form if it dies.",
                @"
Keen Hearing and Smell. The jackalwere has advantage on
Wisdom (Perception) checks that rely on hearing or smell.",
                @"
Pack Tactics. The jacka lwere has advantage on an attack roll
against a creature if at least one of the jackalwere's allies is
within 5 feet of the creature and the ally isn 't incapacitated."
                ];
        }
    }
}
