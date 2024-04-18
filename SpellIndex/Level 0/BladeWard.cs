using Creatures.Base.Spells;

namespace SpellIndex;

public class BladeWard : SpellAttributes
{
    public BladeWard()
    {
        Cantrip = Cantrips.BladeWard;
        School = SpellSchool.Abjuration;
        EffectDescription = [
            @"
You extend your hand and trace a sigil of warding in the
air. Until the end of your next turn, you have resistance
against bludgeoning, piercing, and slashing damage dealt
by weapon attacks."
            ];
        Level = 0;
        Range = 0;
        CastCost = CastCost.Action;
        Duration = 1;
        IsConcentration = false;
        IsTouch = false;
        IsSelf = true;
        IsSupport = true;
    }
    //elaborar melhor como os buffs e heals vão funcionar
}
