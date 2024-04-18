using Base;
using Creatures.Base.Spells;

namespace SpellIndex;

public class AcidSplash : SpellAttributes
{
    public AcidSplash()
    {
        Cantrip = Cantrips.AcidSplash;
        School = SpellSchool.Conjuration;
        DamageType = DamageTypes.Acid;
        EffectDescription = [
            @"
You hurl a bubble of acid. Choose one creature within range,
or choose two creatures within range that are within 5 ft of
each other. A target must succeed on a Dexterity saving throw
or take 1d6 acid damage.
This spell`s damage increases by 1d6 when you reach 5th level
(2d6), 11th level (3d6), and 17th level (4d6)."
];
        Level = 0;
        Range = 60;
        CastCost = CastCost.Action;
        Duration = 0;
        IsConcentration = false;
        IsTouch = false;
        IsSelf = false;
        IsAttack = true;
        IsSupport = false;
        NumberOfTargets = 2;
        HasAreaDamage = false;
        DamageOnFail = "1d6";
        DamageOnSave = "0";
        Save = AttributeName.Dexterity;


    }
}
