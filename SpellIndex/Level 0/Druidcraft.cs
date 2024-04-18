using Creatures.Base.Spells;

namespace SpellIndex
{
    public class Druidcraft : SpellAttributes
    {
        public Druidcraft() 
        {
            Cantrip = Cantrips.DruidCraft;
            School = SpellSchool.Transmutation;
            EffectDescription = [
                @"
Whispering to the spirits of nature, you create one of the following
effects within range:",
@"
You create a tiny, harmless sensory effect that predicts what the
weather will be at your location for the next 24 hours. The effect
might manifest as a golden orb for clear skies, a cloud of rain for
rain, falling snowflakes for snow, and so on. This effect persists,
a seed pod open or a leaf bud bloom.",
@"
You create an instantaneous, harmless sensory effect, such as falling
leaves, a puff of wind, the sound of a small animal, or the faint odor
of skunk. The effect must fit in a 5-foot cube.",
@"
You instantly light or snuff out a candle, a torch, or a small campfire"
                ];
            Level = 0;
            Range = 30;
            CastCost = CastCost.Action;
            Duration = 1;
            IsConcentration = false;
            IsTouch = false;
            IsSelf = false;
            IsSupport = true;
            IsAttack = false;
            IsCondition = false;
            HasAreaDamage = false;

        }
    }
}
