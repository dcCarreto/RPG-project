using Creatures.CombatAttributes;

namespace Creatures
{
    public partial class Creature
    {
        public string? Name { get; set; }
        public Types Type { get; set; }
        public Sizes Size { get; set; }
        public Alignments Alignment { get; set; }
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
        
        // Atributos para a criação do ataque
        public Range Range { get; set; }
        public AttackList AtkName { get; set; }
        public DamageTypes DmgType { get; set; }
        public string DiceDmg {  get; set; }
        public List<Attack> Attacks { get; set; }
        // -------------------------------
    }    
}
