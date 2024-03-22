using System.Reflection;
using Base;
namespace Combat;

public class CombatStarter
{    
    //Instanciamento do método Random para utilização.
    private static readonly Random random = new();
    // Função base para iniciar o combate com um atacante e um alvo
    public static void Combat()
    {
        Console.WriteLine("Creature list available @ README");
        Console.Write("Enter Attacker name: ");

        //Input do nome da criatura
        string attackerClassName = Console.ReadLine()!;

        //Verificação se o nome inserido está presente em alguma subclasse de Creature
        Type[] types = Assembly.GetExecutingAssembly().GetTypes();
        //Variável recebe o Tipo com o nome correspondente e atribui a varíavel creatureTypes
        var creatureTypes = types.Where(t => t.IsSubclassOf(typeof(Creature)));

        //Retorna o primeiro elemento que corresponda a variável creatureTypes e atribui a variável attackerType que armazena o nome e tipo do atacante
        Type? attackerType = creatureTypes.FirstOrDefault(t => t.Name == attackerClassName);

        Console.Write("Enter Target name: ");
        //Recebe o nome do alvo
        string targetClassName = Console.ReadLine()!;

        //Retorna o mesmo porém atribuindo á varíavel targetType o alvo
        Type? targetType = creatureTypes.FirstOrDefault(t => t.Name == targetClassName);

        //Contador para os rounds
        int rounds = 1;

        //Primeira condição para iniciar o combate, tanto a criatura que ataca quanto o alvo devem ser nomes válidos
        if (attackerType != null && targetType != null)
        {
            //Cria uma instancia de attackerType e atribui a "attacker"
            Creature attacker = (Creature)Activator.CreateInstance(attackerType);
            //Cria uma instancia de targetType e atribui a "target"
            Creature target = (Creature)Activator.CreateInstance(targetType);

            //Imprime dados das criaturas em combate
            DisplayCreatureInfo(attacker);
            DisplayCreatureInfo(target);

            //Loop para rodar o combate enquanto uma das criaturas ainda está viva
            while (attacker.HitPoints > 0 && target.HitPoints > 0)
            {
                Console.WriteLine($"\n--- Round {rounds} ---");
                rounds++;

                //Chama a função AttackRound para executar o round do atacante
                AttackRound(attacker, target);
                //Verifica se as criaturas ainda estão vivas no round to atacante
                if (target.HitPoints <= 0 || attacker.HitPoints <= 0)
                {
                    break;
                }

                Console.WriteLine($"\n--- Round {rounds} ---");
                rounds++;

                //Chama a função AttackRound para executar o round do alvo
                AttackRound(target, attacker);
                //Verifica se as criaturas ainda estão vivas no round to alvo
                if (attacker.HitPoints <= 0 || target.HitPoints <= 0)
                {
                    break;
                }
            }
        }
        //Caso o nome inserido nos campos das criaturas não sejam válidos.
        else
        {
            Console.WriteLine("Invalid creature types. Please enter valid attacker and target names.");
            Combat();
        }
        //Fim da função Combat()
    }

    //Função para criar modificadores em string
    private static string Modifiers(int attribute)
    {
        int modifier = (attribute - 10) / 2;
        return (modifier >= 0) ? $"+{modifier}" : modifier.ToString();
    }

    //Função que imprime os status das criaturas envolvidas no combate
    private static void DisplayCreatureInfo(Creature creature)
    {
        Console.WriteLine($@"
Name: {creature.Name}
HP: {creature.HitPoints}
CA: {creature.ArmorClass}
Str: {creature.AttributeValue[0]} {Modifiers(creature.AttributeValue[0])} 
Dex: {creature.AttributeValue[1]} {Modifiers(creature.AttributeValue[1])} 
Con: {creature.AttributeValue[2]} {Modifiers(creature.AttributeValue[2])} 
Int: {creature.AttributeValue[3]} {Modifiers(creature.AttributeValue[3])} 
Wis: {creature.AttributeValue[4]} {Modifiers(creature.AttributeValue[4])} 
Cha: {creature.AttributeValue[5]} {Modifiers(creature.AttributeValue[5])} 
");
    }
    
    

    //Função para executar os rounds de cada criatura
    private static void AttackRound(Creature attacker, Creature target)
    {    

        Console.WriteLine($"\n{attacker.Name}'s Turn:");
        //Executa o método AttackTarget
        AttackTarget(attacker, target);
        //Verifica se o alvo ainda está vivo
        if (target.HitPoints > 0)
        {
            Console.WriteLine($"\n{target.Name}'s Turn:");
            //Ataca se ainda estiver vivo
            //Executa o método AttackTarget
            AttackTarget(target, attacker);
        }
    }

    //Função para interpretar dados em string e executar os rolls
    public static int RollDice(string diceNotation)
    {
        //Divide a string, Ex. 2d6 em 2 e 6 => parts[0] = 2, parts[1] = 6
        string[] parts = diceNotation.Split('d');

        //Verifica se os dados foram dividido em duas partes, caso não, retorna 0
        if (parts.Length < 2)
        {
            //Console.WriteLine($"Invalid dice notation: {diceNotation}");
            return 0;
        }

        //Recebe a primeira parte do dado Ex. 2d6, numberOfDice = 2
        int numberOfDice = int.Parse(parts[0]);

        //Divide a segunda parte da array parts, ou seja "2d6 + 1", 6 + 1 dividido pelo "+", modifierParts = [6, 1] 
        string[] modifierParts = parts[1].Split('+');

        //Verifica se o modificador é válido, Ex. 2d6 + => inválido, 2d6 + 1 => válido
        if (modifierParts.Length < 1)
        {
            //Console.WriteLine($"Invalid dice notation: {diceNotation}");
            return 0;
        }

        //Recebe índice 0 da array modifierParts
        int numberOfSides = int.Parse(modifierParts[0]);

        //Inicializa o modificador
        int modifier = 0;

        //Aplica o valor correto ao modificador caso exista
        if (modifierParts.Length > 1)
        {
            modifier = int.Parse(modifierParts[1]);
        }

        //Inicializa o resultado
        int result = 0;

        //Loop para calcular o resultado dos dados utilizando também a quantidade de dados a serem rolados
        for (int i = 0; i < numberOfDice; i++)
        {
            result = +random.Next(1, numberOfSides + 1);
        }

        //Soma o resultado dos dados ao modificador
        result += modifier;

        return result;
        //Fim do método de cálculo de dados
    }

    //Função que executa os ataques e ações das criaturas
    private static void AttackTarget(Creature attacker, Creature target)
    {
        Console.WriteLine("Attack!\n");

        //Verifica quantos ataques a criatura possui e determina aleatóriamente qual utilizar em seu turno
        var selectedAttack = attacker.Attacks[random.Next(attacker.Attacks.Count)];

        //Imprime a ação realizada e dano causado
        Console.WriteLine($"--- {attacker.Name} used {selectedAttack.AtkName}! ---");
        Console.WriteLine($"{selectedAttack.Types}, {selectedAttack.Range}, Damage: {selectedAttack.Dice}");

        //Inicializa o d20
        int d20 = random.Next(1, 21);
        Console.WriteLine($"Attack Roll: {d20}");

        //Inicializa o booleano que é true caso d20 for maior que a armor class do alvo
        bool successfulAttack = d20 >= target.ArmorClass;

        //Se o successfulAttack for true passa para as condições secundarias do dano
        if (successfulAttack)
        {
            //Damage recebe o valor dos dados rolados, o dado a ser rolado é recebi da classe de criatura e depois passa pela conversão de string para int
            int damage = RollDice(selectedAttack.Dice);
            //Se o d20 for = 20, é aplicado o double damage
            if (d20 == 20)
            {
                Console.WriteLine("Double Damage!");
                damage *= 2;
            }

            //Inicializa o modificador dos atributos da criatura ou personagem
            int attributeModifier = 0;
            //Atribui o atributo requerido para o save para a variável creatureAttribute
            int creatureAttribute = target.AttributeValue[(int)selectedAttack.AttributeSave];

            //Caso o atributo escolhido não seja None ou não haja, o modificador será calculado.
            if (selectedAttack.AttributeSave != 0 && selectedAttack.AttributeSave != null)
            {
                attributeModifier = (creatureAttribute - 10) / 2;
            }

            //Rola os dados para o save
            int attributeTestResult = RollDice("1d20");

            //Teste para o save padrão de 10
            if (attacker.HasSaveOnAttack != false)
            {
                if (attributeTestResult + attributeModifier >= 10)
                {
                    //Aplica o dano extra se passar
                    Console.WriteLine($"{target.Name} Passed {selectedAttack.AttributeSave} test with roll of {attributeTestResult + attributeModifier}!");
                }
                else
                {
                    //Não aplica o dano se o teste falhar
                    Console.WriteLine($"{target.Name} Failed {selectedAttack.AttributeSave} test! Taking {selectedAttack.DamageOnFail} {selectedAttack.ElementAplied} damage.");
                    damage += selectedAttack.DamageOnFail;
                }
            }

            //Aplica modificador de força caso o dano seja Melee, (AttributeValue[0] = Strength)
            if (selectedAttack.Range == RangeTypes.Melee)
            {
                damage += (attacker.AttributeValue[0] - 10 / 2);
            }
            //Aplica modificador de destreza caso o dano seja Ranged. (AttributeValue[1] = Dexterity)
            else if (selectedAttack.Range == RangeTypes.Ranged)
            {
                damage += (attacker.AttributeValue[1] - 10 / 2);
            }

            //Aplica dano 0 para não aplicar dano negativo caso o modificador retire
            if (damage < 0)
            {
                damage = 0;
            }

            //Imprime o dano causado e atualiza o valor do HP do alvo
            Console.WriteLine($"Hit! Dealing {damage} damage to {target.Name}!");
            target.HitPoints -= damage;
            Console.WriteLine($"{target.Name}'s remaining HP: {target.HitPoints}");

            //Verifica se as criaturas ainda estão vivas e imprime o vitorioso
            if (target.HitPoints <= 0)
            {
                Console.WriteLine($"{target.Name} has been defeated! {attacker.Name} is victorious!");
            }
            else if (attacker.HitPoints <= 0)
            {
                Console.WriteLine($"{attacker.Name} has been defeated! {target.Name} is victorious!");
            }
        }

        //Condição final para o ataque caso a criatura não acerte o ataque
        else
        {
            Console.WriteLine("Miss! No damage dealt.");
        }
    }
}