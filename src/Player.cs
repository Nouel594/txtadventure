using System.Dynamic;

class Player
{
    // Auto-property
    public Room CurrentRoom { get; set; }

    // Fields
    private int health;

    public int Health
    {
    get {return health;}
    private set {health = value;}
    }

    // Single constructor
    public Player() 
    {
        CurrentRoom = null;
      Health = 100;


    }


}







