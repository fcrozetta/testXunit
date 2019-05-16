using System;
using Xunit;
using Program.Models;

namespace Program.Tests
{
    public class DogTest1
    {
        [Fact]
        public void canDogBark()
        {
            // Dummy test to check if dog barks
            Animal a = new Dog();
            Assert.Equal("Woof Woof!", a.bark());
        }

    }
}
