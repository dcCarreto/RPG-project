namespace Creatures.BestiaryC2
{
    internal class Nothic : Creatures
    {
        public Nothic()
        {
            Name = "Nothic";
            Type = ab;
            Size = m;
            Alignment = ne;
            HitPoints = 45 + RollMultiple(8, 5) + 18;
            // continuar
        }
    }
}
