using Base;
using Creatures.Base.Spells;

namespace SpellIndex;

public class BoomingBlade : SpellAttributes
{
    public BoomingBlade()
    {
        Cantrip = Cantrips.BoomingBlade;
        School = SpellSchool.Evocation;
        DamageType = DamageTypes.Thunder;
        Level = 0;
        Range = 0;
        CastCost = CastCost.Action;
        Duration = 1;
        IsConcentration = false;
        IsTouch = false;
        IsSelf = true;
        IsSupport = false;
        IsAttack = true;
        IsCondition = false;
        IsDisable = false;
        NumberOfTargets = 1;
        RadiusEffect = 5;
    }
}
