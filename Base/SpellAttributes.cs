namespace Base;

public class SpellAttributes
{
    public SpellList Spell { get; set; }
    public Cantrips Cantrip { get; set; }
    public SpellSchool School { get; set; }
    public DamageTypes DamageType { get; set; }
    public int Level { get; set; }
    public int Range {  get; set; } //feets
    public CastCost CastCost { get; set; }
    public int Duration { get; set; } //rounds
    public bool IsConcentration { get; set; }
    public bool IsTouch { get; set; }
    public bool isSelf { get; set; }
    public bool isSupport { get; set; }
    public bool HasAreaDamage { get; set; }
    public int RadiusEffect { get; set; }
    public string? DamageOnFail { get; set; }
    public string? DamageOnSave { get; set; }
    public AttributeName Save { get; set; }
}
