namespace GildedRose;
public class Brie : Item
{

    public override void UpdateItem(){
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