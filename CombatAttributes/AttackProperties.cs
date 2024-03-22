using Combat;
using Base;
namespace CombatAttributes;

public class Attack
{
    public AttackList AtkName { get; set; }
    public DamageTypes Types { get; set; }
    public RangeTypes Range { get; set; }
    public string Dice { get; set; }
    public int ToHitBonus { get; set; }
    public int Reach { get; set; }
    public DamageTypes ElementAplied { get; set; }
    public int DamageOnFail { get; set; }
    public int SaveDC { get; set; }
    public AttributeName AttributeSave {  get; set; }

                

    public Attack(AttackList atkName, DamageTypes types, RangeTypes range, string dice,
                    int toHitBonus = 0, int reach = 0, DamageTypes element = 0, string diceDamageOnFail = "", int saveDC = 0, AttributeName attributeSave = 0)
    {
        Random rd = new();
        AtkName = atkName;
        Types = types;
        Range = range;
        Dice = dice;
        ToHitBonus = toHitBonus;
        Reach = reach;
        ElementAplied = element;
        //int newDice = CombatBase.RollDice("3d4");
        DamageOnFail = CombatStarter.RollDice(diceDamageOnFail);
        //DamageOnFail = rd.Next(1, damageOnFail + 1);
        SaveDC = saveDC;
        AttributeSave = attributeSave;
    }
}
