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
        isSelf = false;
        isSupport = true;
        isAttack = false;
        isCondition = false;
        isDisable = false;
        HasAreaDamage = false;
    }
}