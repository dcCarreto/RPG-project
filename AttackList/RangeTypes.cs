namespace Creatures
{
    public class RangeTypes
    {
        public string Melee {get;}  = "Melee";
        public string Ranged {get;}  = "Ranged";

        public RangeTypes() 
        {
            
        }

        public string GetRangeTypes(string range)
        {
            switch (range)
            {
                case "Melee":
                case "Ranged":
                    return range;
                default:
                    return "Unknown";
            }
        }
    }
}