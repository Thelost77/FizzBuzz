using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame.UnitTests
{
    public class FizzBuzzTests
    {
        [Test]
        public void Game_WhenInputIsDivisibleOnlyBy3_ShouldReturnFizz()
        {
            //Arrange
            var fizzBuzz = new FizzBuzz();

            //Act
            var result = fizzBuzz.Game(3);

            //Assert
            Assert.That(result, Is.EqualTo("Fizz"));
        }
        [Test]
        public void Game_WhenInputIsDivisibleOnlyBy5_ShouldReturnBuzz()
        {
            //Arrange
            var fizzBuzz = new FizzBuzz();

            //Act
            var result = fizzBuzz.Game(5);

            //Assert
            Assert.That(result, Is.EqualTo("Buzz"));
        }
        [Test]
        public void Game_WhenInputIsDivisibleOnlyBy15_ShouldReturnFizzBuzz()
        {
            //Arrange
            var fizzBuzz = new FizzBuzz();

            //Act
            var result = fizzBuzz.Game(15);

            //Assert
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
        [Test]
        public void Game_WhenInputIsnNotDivisibleBy3or5_ShouldReturnGivenNumber()
        {
            //Arrange
            var fizzBuzz = new FizzBuzz();

            //Act
            var result = fizzBuzz.Game(7);

            //Assert
            Assert.That(result, Is.EqualTo("7"));
        }
    }
}
