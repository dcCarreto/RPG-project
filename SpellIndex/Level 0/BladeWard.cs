using Creatures.Base.Spells;

namespace SpellIndex;

public class BladeWard : SpellAttributes
{
    public BladeWard()
    {
        Cantrip = Cantrips.BladeWard;
        School = SpellSchool.Abjuration;
        Level = 0;
        Range = 0;
        CastCost = CastCost.Action;
        Duration = 1;
        IsConcentration = false;
        IsTouch = false;
        isSelf = true;
        isSupport = true;
    }
    //elaborar melhor como os buffs e heals vão funcionar
}
