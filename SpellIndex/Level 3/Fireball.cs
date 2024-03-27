using Base;

namespace SpellIndex
{
    internal class Fireball : Spells
    {
        public Fireball()
        {
            Spell = SpellList.Fireball;
            School = SpellSchool.Evocation;
            Level = 3;
            Range = 150;
            CastingTime = "1 Action";
            Duration = "Instantaneous";
            IsConcentration = false;
            IsTouch = false;
            isSelf = false;
            HasAreaDamage = true;
            RadiusEffect = 20;
            DamageOnFail = "8d6";
            DamageOnSave = "8d6 /2";
            Save = AttributeName.Dexterity;
        }
    }
}
