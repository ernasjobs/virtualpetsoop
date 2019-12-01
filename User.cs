namespace virtualpetsoop
{
    public class User
    {
        string name;
        public string Name
        {
            get{return name;}
            set{name=value;}
        }
        decimal balance;
        public decimal Balance
        {
            get{return balance;}
            set{if(value<0) balance=0; balance=value;}
        }
        public User(string fname,decimal ubalance)
        {
            name=fname;
            balance=ubalance;
        }
    }
}