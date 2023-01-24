using ConsoleApp1;
namespace ZioCane
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Biglietto a = new Biglietto("Catania", 1000);
            Biglietto b = new Biglietto("Presezzo", 3000);
            Assert.True(a.ConfrontaBiglietti(b) == -1);

        }

        [Fact]
        public void Test2()
        {
            Biglietto a = new Biglietto("Catania", 1000);
            
            Assert.True(a.VisualizzaSeVincente() == true);

        }

        [Fact]
        public void Test3()
        {
            Biglietto a = new Biglietto("Catania", 1000);
            Biglietto b = new Biglietto("Presezzo", 3000);
            Assert.True(a.ControllaAppartenenzaSerie(b) == false);

        }

        [Fact]

        public void Test4()
        {
            Biglietto a = new Biglietto("Catania", 1000);
            Biglietto b = new Biglietto("Presezzo", 3000);
            Assert.False(a.ConfrontaNumeri(b) == true);

        }

        [Fact]
        public void Test5()
        {
            Biglietto a = new Biglietto("Catania", 1000);
            a.ModDati("Bologna", 4000);
            Assert.True(a.Citta == "Bologna" && a.Premio == 4000);
            
        }




    }
}