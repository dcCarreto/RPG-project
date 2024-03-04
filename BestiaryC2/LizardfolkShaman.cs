namespace Creatures.BestiaryC2
{
    internal class LizardfolkShaman : CreatureAttributes
    {

        public LizardfolkShaman()
        {
            Name = "Lizardfolk Shaman";
            Type = hu;
            Size = m;
            Alignment = n;
            HitPoints = 27 + RollMultiple(8, 5) + 5;
            ArmorClass = 13;
            Speed = "30ft, swim 30ft";
            Attributes = [15, 10, 13, 10, 15, 8];
            ChallengeLevel = "2";
            Experience = 450;
            Skills = "Perception +4, Stealth +4, Survival +6";
            Senses = "passive Perception 14";
            Languages = "Draconic";
            Actions = [
                @"
Multiattack (Lizardfolk Form Only). The lizardfolk makes two
attacks: one with its bite and one with its claws.",
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
Hit: 5 (1d6 + 2) piercing damage, or 7 (ld10 + 2) piercing
damage in crocodile form. If the lizardfolk is in crocod ile form
and the target is a Large or smaller creature, the target is
grappled (escape DC 12). Until this grapple ends, the target is
restrained, and the li zardfolk can't bite another target. If the
lizardfolk reverts to its true form, the grapple ends.",
                @"
Claws (Lizardfolk Form Only). Melee Weapon Attack: +4 to hit,
reach 5 ft., one target. Hit: 4 (1d4 + 2) slash ing damage.",
                @"
Change Shape (Recharges after a Short or Long Rest). The
lizardfolk magical ly polymorphs into a crocodile, remaining
in that form for up to 1 hour. It can revert to its true form as
a bonus action. Its statistics, other than its size, are the same
in each form. Any equipment it is wearing or carrying isn't
transformed. It reverts to its true form if it dies."
                ];
            Abilities = [
                @"
Hold Breath. The lizardfolk can hold its breath for 15 minutes.",
@"
Spellcasting (Lizardfolk Form Only). The lizardfolk is a 5th-level
spellcaster. Its spellcasting abi lity is Wisdom (spell save DC
12, +4 to hit with s pell attacks). The lizardfolk has the following
druid spells prepared:
Can trips (at will) : druidcraft, produce flame, thorn whip
1st Level (4 slots): entangle ,fog cloud
2nd Level (3 slots): heat metal, spike growth
3rd Level (2 slots): conjure animals (reptiles only) , plant growth"
                ];
        }
    }
}
