namespace Base;

public class Spells
{
    public SpellList Spell { get; set; }
    public SpellSchool School { get; set; }
    public int Level { get; set; }
    public int Range {  get; set; } //feets
    public string? CastingTime { get; set; }
    public string? Duration { get; set; }
    public bool IsConcentration { get; set; }
    public bool IsTouch { get; set; }
    public bool isSelf { get; set; }
    public bool HasAreaDamage { get; set; }
    public int RadiusEffect { get; set; }
    public string? DamageOnFail { get; set; }
    public string? DamageOnSave { get; set; }
    public AttributeName Save { get; set; }
}
