namespace GildedRose;
public class BackstagePass : Item, IUpdateable{

    public void UpdateItem(){
       { 
        if (Quality >= 50) 
        {
            return;
        }

        if (SellIn <= 10 && SellIn > 5)
        {
            Quality += 2;
        }
        if (SellIn <= 5 && SellIn > 0)
        {
            Quality += 3;
        }
        if (SellIn <= 0)
        {
            Quality = 0;
        }}

    }
}