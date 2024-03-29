using System.Reflection;
using Creatures.Base.Spells;
using CombatAttributes;

namespace Base
{
    public class Creature
    {        
        public List<SpellAttributes> MagicalAbilities { get; private set; } = new List<SpellAttributes>();
        public string? Name { get; set; }
        public Types Type { get; set; }
        public Sizes Size { get; set; }
        public Alignments Alignment { get; set; }
        public int HitPoints { get; set; }
        public int ArmorClass { get; set; }
        public string? Speed { get; set; }
        private readonly string[] AttributeName = ["Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma"];
        public int[]? AttributeValue { get; set; }
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
        public bool HasMultiAttack { get; set; }
        public bool HasSaveOnAttack { get; set; }

        // Atributos para a criação do ataque
        public Range Range { get; set; }
        public ActionList AtkName { get; set; }
        public DamageTypes DmgType { get; set; }
        public string? DiceDmg { get; set; }
        public List<Attack>? Attacks { get; set; }
        // -------------------------------

        public Creature()
        {
            InitializeMagicalAbilities();
        }

        // Imported codes

        // Dices
        private Random numberGen = new Random();
        public int Roll(int dice)
        {
            return numberGen.Next(1, dice + 1);
        }
        public int RollMultiple(int dice, int numRolls)
        {
            int totalResult = 0;
            for (int i = 0; i < numRolls; i++)
            {
                totalResult += Roll(dice);
            }
            return totalResult;
        }
        //-----------------------------------------------

        // Modifiers
        static int CalculateModifier(int attributeValue)
        {
            return (attributeValue - 10) / 2;
        }
        //-----------------------------------------------

        // Spell check
        public bool CanCastSpell(SpellList spell)
        {
            return MagicalAbilities.Any(magic => magic.Spell == spell);

        }

        private void InitializeMagicalAbilities()
        {
            var spellClasses = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => type.IsSubclassOf(typeof(SpellAttributes)));

            foreach (var spellClass in spellClasses)
            {
                var spellInstance = Activator.CreateInstance(spellClass) as SpellAttributes;
                if (spellInstance != null)
                {
                    MagicalAbilities.Add(spellInstance);
                }
            }
        }
    }    
}
