using System;
using Xunit;

namespace Animals.Tests
{
    public class AnimalShould
    {

        private Animal _animal;
        private Dog _doge;

        public AnimalShould()                      // think of as setup code - constructor will always run first in this case
        {
            _animal = new Animal("George");        // okay to change later, but this test code is to help design what the program should do
            _doge = new Dog("Lunchbox");
        }

        [Fact]
        public void HaveCorrectNamePropertyValue()  // good name for a unit test. be explicit!
        {
            Assert.Equal(_animal.Name, "George");
        }

        [Fact]
        public void SetSpeciesMethodShoulSetSpeciesProperty()       // signature of the test has nothign to do with code within
        {

            // string species = _animal.SetSpecies("German Shepherd"); // this would be useful to test the output
            // Assert.Equal(species, "German Shepherd");

            // Setting the species will be defined on Animall class and inherited by derived class
            _animal.SetSpecies("German Shepherd");
            Assert.Equal(_animal.Species, "German Shepherd");

            _doge.SetSpecies("Carolina Labrador");                  // checking a side effect in testing is fine
            Assert.Equal(_doge.Species, "Carolina Labrador");
        }
    }
}
