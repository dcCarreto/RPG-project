namespace Creatures
{
    public class DamageTypes
    {
           public string Blundgeoning {get;}  = "Blundgeoning";
            public string Piercing {get;}  = "Piercing";
            public string Slashing {get;}  = "Slashing";            
            public string Acid {get;}  = "Acid";
            public string Cold {get;}  = "Cold";
            public string Fire {get;}  = "Fire";
            public string Force {get;}  = "Force";
            public string Lightning {get;}  = "Lightning";
            public string Necrotic {get;}  = "Necrotic";
            public string Poison {get;}  = "Poison";
            public string Psychic {get;}  = "Psychic";
            public string Radiant {get;}  = "Radiant";
            public string Thunder {get;}  = "Thunder";


            public DamageTypes() 
        {
            
        }

        public string GetDamageTypes(string type)
        {
            switch (type)
            {
                case "Blundgeoning":
                case "Piercing":
                case "Slashing":
                case "Acid":
                case "Cold":
                case "Fire":
                case "Force":
                case "Lightning":
                case "Necrotic":
                case "Poison":
                case "Psychic":
                case "Radiant":
                case "Thunder":            
                    return type;
                default:
                    return "Unknown";
            }
        }
    }
}