// One item on the shopping list.
class Item
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Item(string name, int price)
    {
        ValidateName(name);
        Name = name;
        Price = price;
    }

    internal static void ValidateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Varans namn får inte vara tomt.");
        }
    }

    public override string ToString()
    {
        return $"{Name} - {Price} kr";
    }
}
