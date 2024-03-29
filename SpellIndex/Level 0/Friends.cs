using Creatures.Base.Spells;

namespace SpellIndex;

internal class Friends : SpellAttributes
{
    public Friends()
    {
        Cantrip = Cantrips.Friends;
        School = SpellSchool.Enchantment;
        Level = 0;
        CastCost = CastCost.Action;
        Duration = 1;
        IsConcentration = true;
        IsTouch = false;
        isSelf = true;
        isSupport = true;
        isAttack = false;
        isCondition = true;
        isDisable = false;
        NumberOfTargets = 1;
    }
}