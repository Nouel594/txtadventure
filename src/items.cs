class Item
{
    private string v;

    // fields
    public int Weight { get; }
public string Description { get; }
// constructor
public Item(int weight, string description)
{
Weight = weight;
Description = description;
}

    public Item(string v)
    {
        this.v = v;
    }
}
