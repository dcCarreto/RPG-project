class Dices
{
    public int d4 = 4;
    public int d6 = 6;
    public int d8 = 8;
    public int d10 = 10;
    public int d12 = 12;
    public int d20 = 20;

    public int Roll(int dice)
    {
        Random numberGen = new Random();
        int result = numberGen.Next(1, dice + 1);
        return result;
    }
}

// 0.0.4
// Na versão anterior (0.0.3), o numberGen estava sendo executado diretamente no atributo da classe.
// Como consequência, numberGen só era executado na criação de uma instância. isso tornava, para as futuras chamadas da instância, os valores dos atributos em valores fixos.
// Para gerar um novo valor, seria necessário criar uma nova instância.
// Para solucionar esse problema, criei a função Roll().
// --
// Exemplo de uso:
// Dices dice = new Dices();
// dice.Roll(dice.d4);