namespace GildedRose;
public class Conjured : Item 
{

    public override void UpdateItem()
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