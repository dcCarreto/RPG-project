class Dices
{
    public int d4;
    public int d6;
    public int d8;
    public int d12;
    public int d10;
    public int d20;

    public Dices()
    {
        Random numberGen = new Random();
        d4 = numberGen.Next(1, 5);
        d6 = numberGen.Next(1, 7);
        d8 = numberGen.Next(1, 9);
        d10 = numberGen.Next(1, 11);
        d12 = numberGen.Next(1, 13);
        d20 = numberGen.Next(1, 21);
    }
}