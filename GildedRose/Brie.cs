namespace GildedRose;
public class Brie : Item, IUpdateable
{

    public void UpdateItem(){
            if (SellIn > 0){
                Quality++;
            }
            else {
                Quality = Quality+2;
            }
            SellIn--;
            if (Quality >50){
                Quality = 50;
            }
        }
}