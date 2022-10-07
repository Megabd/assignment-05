namespace GildedRose;
public class Item : IUpdateable
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public virtual void UpdateItem(){
            if (SellIn > 0){
            SellIn--;
            Quality--;
            }
            else {
                SellIn--;
                Quality = Quality-2;
            }
        }
    }
