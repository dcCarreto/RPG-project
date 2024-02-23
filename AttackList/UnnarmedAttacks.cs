namespace Creatures
{
    public class UnnarmedAttacks
    {
        public string Beak {get;} = "Beak";
        public string Bite {get;} = "Bite";
        public string Claw {get;} = "Claw";
        public string Talons {get;} = "Talons";
        public string Ram {get;} = "Ram";
        public string Rake {get;} = "Rake";
        public string Tentacles {get;} = "Tentacles";

        public UnnarmedAttacks() 
        {
            
        }

        public string GetAttackName(string attack)
        {
            switch (attack)
            {
                case "Beak":
                case "Bite":
                case "Claw":
                case "Talons":
                case "Ram":
                case "Rake":
                case "Tentacles":
                    return attack;
                default:
                    return "Unknown";
            }
        }
    }
}

//ongoing