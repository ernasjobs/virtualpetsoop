namespace virtualpetsoop
{
    public class Ball : Toy
    {
        
        private int numOfUses;
        private string action;
        private int cost;
        public int Uses 
        { 
            get{return numOfUses;}
            set{numOfUses=value;}
        }
        public int Cost 
        { 
            get{return cost;}
            set{cost=value;}
        }
         public string Action 
        { 
            get{return action;}
            set{action=value;}
        }
        public Ball(string name, int benefit) : base(name, benefit)
        {
            numOfUses=10;
            action="Chasing";
            cost=200;
        }
    }
}