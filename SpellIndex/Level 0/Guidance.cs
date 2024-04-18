using Base;
using Creatures.Base.Spells;

namespace SpellIndex;

public class Guidance : SpellAttributes
{
    public Guidance()
    {
        Cantrip = Cantrips.Guidance;
        School = SpellSchool.Divination;
        Level = 0;
        Range = 0;
        Duration = 10;
        IsConcentration = true;
        IsTouch = true;
        IsSelf = false;
        IsSupport = true;
        IsAttack = false;
        IsCondition = false;
        IsDisable = false;
        HasAreaDamage = false;
    }
}