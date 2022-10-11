namespace GildedRose;
public class Conjured : Item, IUpdateable
{

    public void UpdateItem()
    {
        if (SellIn > 0) 
        {
            SellIn --;
            Quality -= 2;
        }
        else 
        {
            SellIn--;
            Quality -= 4;
        }
    }
}