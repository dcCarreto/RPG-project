using Base;

namespace SpellIndex;

internal class AcidSplash : SpellAttributes
{
    public AcidSplash()
    {
        Cantrip = Cantrips.AcidSplash;
        School = SpellSchool.Conjuration;
        DamageType = DamageTypes.Acid;
        Level = 0;
        Range = 60;
        CastCost = CastCost.Action;
        Duration = 0;
        IsConcentration = false;
        IsTouch = false;
        isSelf = false;
        HasAreaDamage = false;
        DamageOnFail = "1d6";
        DamageOnSave = "0";
        Save = AttributeName.Dexterity;


    }
}
