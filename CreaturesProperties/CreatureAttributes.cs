namespace Creatures
{

    public partial class CreatureAttributes
    {
        public string
        // Sizes
        t = "Tiny", s = "Small", m = "Medium",
        l = "Large", h = "Huge", g = "Gargantuan",

        // Alignments    
        lg = "Lawful Good", ng = "Neutral Good", cg = "Chaotic Good",
        ln = "Lawful Neutral", n = "Neutral", cn = "Chaotic Neutral",
        le = "Lawful Evil", ne = "Neutral Evil", ce = "Chaotic Evil",
        aa = "Any Alignment", ud = "Unaligned", ana = "Any non-good alignment",
        aca = "Any Chaotic Alignment",

        // Types
        ab = "Aberration", ba = "Beast", cl = "Celestial",
        co = "Construct", dr = "Dragon", el = "Elemental",
        fy = "Fey", fi = "Fiend", gi = "Giant",
        hu = "Humanoid", mo = "Monstruosity", oo = "Ooze",
        pl = "Plant", un = "Undead";

        protected string? Name { get; set; }
        protected string? Type { get; set; }
        protected string? Size { get; set; }
        protected string? Alignment { get; set; }
        protected int HitPoints { get; set; }
        protected int ArmorClass { get; set; }
        protected string? Speed { get; set; }
        private readonly string[] AttributeName = ["Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma"];
        protected int[]? Attributes { get; set; }
        protected string? ChallengeLevel { get; set; }
        protected int Experience { get; set; }
        protected string? SavingThrows { get; set; }
        protected string? DamageImmunities { get; set; }
        protected string? DamageResistances { get; set; }
        protected string? DamageVulnerabilities { get; set; }
        protected string? ConditionImmunities { get; set; }
        protected string? ConditionResistances { get; set; }
        protected string? Skills { get; set; }
        protected string? Senses { get; set; }
        protected string? Languages { get; set; }
        protected string[]? Actions { get; set; }
        protected string? Reactions { get; set; }
        protected string[]? Abilities { get; set; }
    }
}
