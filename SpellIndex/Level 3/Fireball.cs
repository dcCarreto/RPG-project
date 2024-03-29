using Base;
using Creatures.Base.Spells;

namespace SpellIndex;

internal class Fireball : SpellAttributes
{
    public Fireball()
    {
        Spell = SpellList.Fireball;
        School = SpellSchool.Evocation;
        DamageType = DamageTypes.Fire;
        Level = 3;
        Range = 150;
        CastCost = CastCost.Action;
        Duration = 1;
        IsConcentration = false;
        IsTouch = false;
        isSelf = false;
        isSupport = false;
        isAttack = true;
        isCondition = false;
        isDisable = false;
        HasAreaDamage = true;
        RadiusEffect = 20;
        DamageOnFail = "8d6";
        DamageOnSave = "8d6 /2";
        Save = AttributeName.Dexterity;
    }
}
