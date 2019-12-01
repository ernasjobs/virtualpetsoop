namespace virtualpetsoop
{
    public class LaserPointer : Toy
    {
        public int Uses {get;set;}
        public LaserPointer(string name, int benefit) : base(name, benefit)
        {
            Uses=5;
        }
    }
}