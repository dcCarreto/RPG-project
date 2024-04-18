using Creatures.Base.Spells;

namespace SpellIndex;

public class DancingLights : SpellAttributes
{
    public DancingLights()
    {
        Cantrip = Cantrips.DancingLights;
        School = SpellSchool.Evocation;
        EffectDescription = [
            @"
Vou create up to four torch-sized lights within range,
making them appear as torches, lanterns, or glowing
orbs that hover in the air for the duration. Vou can
also combine the four Iights into one glowing vaguely
humanoid form of Medium size. Whichever form you
choose, each light sheds dim light in a 1O-foot radius.
As a bonus action on your turn, you can move the
lights up to 60 feet to a new spot within range. A Iight
must be within 20 feet of another light created by this
spell, and a light winks out if it exceeds the spell's range."
            ];
        Level = 0;
        Range = 120;
        CastCost = CastCost.Action;
        Duration = 1;
        IsConcentration = true;
        IsTouch = false;
        IsSelf = false;
        IsAttack = false;
        IsSupport = true;
        IsCondition = false;
        IsDisable = false;
        HasAreaDamage = false;
        RadiusEffect = 10;
    }
}