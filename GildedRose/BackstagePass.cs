namespace GildedRose;
public class BackstagePass : Item, IUpdateable{

    public void UpdateItem(){
        if(Quality<50){
            if(SellIn > 10){
                Quality++;
            } else {
                if(SellIn > 0){
                    if(SellIn<=5){
                        Quality = Quality+3;
                    } else {
                        Quality = Quality+2;
                    }
                } else {
                    Quality = 0;
                }
            }
        }
        SellIn--;
    }
}