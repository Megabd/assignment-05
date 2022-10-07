namespace GildedRose.Tests;

public class ProgramTests
{
    [Fact]
    public void TestTheTruth()
    {
        true.Should().BeTrue();
    }


    [Fact]
    public void AgedBrie_updates_correct(){
        //Arrange
        Program program = new Program();

        program.Items = new List<Item>{ new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 }};
        //Act
        program.UpdateQuality();
        //Assert
        program.Items[0].SellIn.Should().Be(1);
        program.Items[0].Quality.Should().Be(1);
    }


    [Fact]
    public void AgedBrie_updates_twiceSpeed_after_SellIn(){
        //Arrange
        Program program = new Program();

        program.Items = new List<Item>{ new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 }};
        //Act
        program.UpdateQuality();
        program.UpdateQuality();
        program.UpdateQuality();
        program.UpdateQuality();
        //Assert
        program.Items[0].SellIn.Should().Be(-2);
        program.Items[0].Quality.Should().Be(6);
    }

    [Fact]
    public void ItemSlashAgedBrie_cannot_have_Quality_above_50(){
        //Arrange
        Program program = new Program();

        program.Items = new List<Item>{ new Item { Name = "Aged Brie", SellIn = 2, Quality = 49 }};
        //Act
        program.UpdateQuality();
        program.UpdateQuality();
        program.UpdateQuality();
        program.UpdateQuality();
        //Assert
        program.Items[0].SellIn.Should().Be(-2);
        program.Items[0].Quality.Should().Be(50);
    }

    [Fact]
    public void Item_Update_correct(){
        //Arrange
        Program program = new Program();

        program.Items = new List<Item>{ new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20}};
        //Act
        program.UpdateQuality();
        
        //Assert
        program.Items[0].SellIn.Should().Be(9);
        program.Items[0].Quality.Should().Be(19);
    }

    [Fact]
    public void Item_Degrades_twiceSpeed_after_SellIn(){
        //Arrange
        Program program = new Program();

        program.Items = new List<Item>{ new Item { Name = "+5 Dexterity Vest", SellIn = 1, Quality = 10}};
        //Act
        program.UpdateQuality();
        program.UpdateQuality();
        program.UpdateQuality();
        
        //Assert
        program.Items[0].SellIn.Should().Be(-2);
        program.Items[0].Quality.Should().Be(5);
    }



    [Fact]
    public void Update_should_increase_3times_quality_if_sellIn_under_5_of_backstagepass()
    {
        //arrange
        Program program = new Program();
        program.Items = new List<Item>{ new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 2, Quality = 0 }};

        //act
        program.UpdateQuality();

        //assert
        program.Items[0].Quality.Should().Be(3);
    }

    [Fact]
    public void Update_should_increase_2times_quality_if_sellIn_under_10_of_backstagepass()
    {
        //arrange
        Program program = new Program();
        program.Items = new List<Item>{ new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 0 }};

        //act
        program.UpdateQuality();

        //assert
        program.Items[0].Quality.Should().Be(2);
    }

     [Fact]
    public void Update_should_set_quality_to_zero_after_concert()
    {
        //arrange
        Program program = new Program();
        program.Items = new List<Item>{ new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 0 }};

        //act
        program.UpdateQuality();

        //assert
        program.Items[0].Quality.Should().Be(0);
    }

    [Fact]
    public void Update_backstage_pass_should_have_maximum_quality_50()
    {
        Program program = new Program();
        program.Items = new List<Item>{ new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 50 }};

        //act
        program.UpdateQuality();

        //assert
        program.Items[0].Quality.Should().Be(50);
    }

    [Fact]
    public void Update_once_should_never_increase_nor_decrease_quality_of_Sulfaras(){
        //Arrange
        Program program = new Program();

        program.Items = new List<Item>{ new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 }};
        //Act
        program.UpdateQuality();
        //Assert
        program.Items[0].SellIn.Should().Be(0);
        program.Items[0].Quality.Should().Be(80);
    }

    [Fact]
    public void Update_dozen_should_never_increase_nor_decrease_quality_of_Sulfaras(){
        //Arrange
        Program program = new Program();

        program.Items = new List<Item>{ new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 }};
        //Act
        for (int i = 0; i <= 12; i++) program.UpdateQuality();
        //Assert
        program.Items[0].SellIn.Should().Be(0);
        program.Items[0].Quality.Should().Be(80);
    }

   
    
}