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
        public void CaimanCanEat()
        {
            Assert.Equal("nom nom nom", CaimanEat());
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
        public void JackdawCanEat()
        {
            Assert.Equal("nom nom nom", JackdawEat());
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
        public void CaimanCanSleep()
        {
            Assert.Equal("zzz", CaimanSleep());
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
        public void JackdawCanSleep()
        {
            Assert.Equal("zzz", JackdawSleep());
        }
    }
}
