namespace GildedRose;
public class BackstagePass : Item, IUpdateable{

    public override void UpdateItem(){
        //My suggestion for avoiding a double-nested condition statement
        // if (Quality > 50) 
        // {
        //     return;
        // }

        // if (SellIn <= 10 && SellIn > 5)
        // {
        //     Quality += 2;
        // }
        // if (SellIn <= 5 && SellIn > 0)
        // {
        //     Quality += 3;
        // }
        // if (SellIn <= 0)
        // {
        //     Quality = 0;
        // }


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
                } else {
                    Quality = 0;
                }
            }
        }
        SellIn--;
    }
}