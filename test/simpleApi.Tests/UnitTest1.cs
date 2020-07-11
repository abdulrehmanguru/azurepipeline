using System;
using Xunit;
using simpleApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace simpleApi.Tests
{
    public class UnitTest1
    {
    
        [Fact]
        public void TestController()
        {
            var cont = new ValuesController();
            Assert.Equal("returned value is 1", cont.Get(1).Value);
        }
    }
}
