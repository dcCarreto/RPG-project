namespace Creatures
{

    public partial class Creature
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

        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Size { get; set; }
        public string? Alignment { get; set; }
        public int HitPoints { get; set; }
        public int ArmorClass { get; set; }
        public string? Speed { get; set; }
        private readonly string[] AttributeName = ["Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma"];
        public int[]? Attributes { get; set; }
        public string? ChallengeLevel { get; set; }
        public int Experience { get; set; }
        public string? SavingThrows { get; set; }
        public string? DamageImmunities { get; set; }
        public string? DamageResistances { get; set; }
        public string? DamageVulnerabilities { get; set; }
        public string? ConditionImmunities { get; set; }
        public string? ConditionResistances { get; set; }
        public string? Skills { get; set; }
        public string? Senses { get; set; }
        public string? Languages { get; set; }
        public string[]? Actions { get; set; }
        public string? Reactions { get; set; }
        public string[]? Abilities { get; set; }
       // é usado na criação das criaturas
        public RangeTypes Range { get; set; }
        public AttackList AtkName { get; set; }
        public DamageTypes DmgType { get; set; }
        public string DiceDmg {  get; set; }
        public List<Attack> Attacks { get; set; }
        // -------------------------------

    }
    public class Attack
    {
        // futuramente será usado no combate
        public AttackList AtkName { get; set; }
        public RangeTypes Range { get; set; }        
        public DamageTypes Types { get; set; }
        public string Dice { get; set; }
        // -------------------------------
    }
}
