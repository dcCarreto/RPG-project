using Creatures.Base.Spells;

namespace SpellIndex;

public class DancingLights : SpellAttributes
{
    public DancingLights()
    {
        Cantrip = Cantrips.DancingLights;
        School = SpellSchool.Evocation;
        Level = 0;
        Range = 120;
        CastCost = CastCost.Action;
        Duration = 1;
        IsConcentration = true;
        IsTouch = false;
        isSelf = false;
        isAttack = false;
        isSupport = true;
        isCondition = false;
        isDisable = false;
        HasAreaDamage = false;
        RadiusEffect = 10;
    }
}