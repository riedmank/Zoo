using System;
using Xunit;
using static Zoo.Program;
using Zoo.Classes;

namespace ZooTests
{
    public class UnitTest1
    {
        [Fact]
        public void AlligatorCanEat()
        {
            Assert.Equal("nom nom nom", AlligatorEat());
        }

        [Fact]
        public void CrocodileCanEat()
        {
            Assert.Equal("nom nom nom", CrocodileEat());
        }

        [Fact]
        public void KangarooCanEat()
        {
            Assert.Equal("nom nom nom", KangarooEat());
        }

        [Fact]
        public void CrowCanEat()
        {
            Assert.Equal("nom nom nom", CrowEat());
        }

        [Fact]
        public void RavenCanEat()
        {
            Assert.Equal("nom nom nom", RavenEat());
        }

        [Fact]
        public void AlligatorCanSleep()
        {
            Assert.Equal("zzz", AlligatorSleep());
        }

        [Fact]
        public void CrocodileCanSleep()
        {
            Assert.Equal("zzz", CrocodileSleep());
        }

        [Fact]
        public void KangarooCanSleep()
        {
            Assert.Equal("zzz", KangarooSleep());
        }

        [Fact]
        public void CrowCanSleep()
        {
            Assert.Equal("zzz", CrowSleep());
        }

        [Fact]
        public void RavenCanSleep()
        {
            Assert.Equal("zzz", RavenSleep());
        }

        [Fact]
        public void KangarooCanHop()
        {
            Assert.Equal("Hop Hop Hop", KangarooHop());
        }

        [Fact]
        public void WallabyCanHop()
        {
            Assert.Equal("Hop Hop Hop", WallabyHop());
        }
    }
}
