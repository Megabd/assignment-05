namespace GildedRose;
public class Legendary : Item, IUpdateable
{

    public void UpdateItem() 
    {
        SellIn = SellIn;
        Quality = Quality;
    }
}