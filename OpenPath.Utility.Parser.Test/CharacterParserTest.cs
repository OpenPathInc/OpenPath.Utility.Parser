using NUnit.Framework;

namespace OpenPath.Utility.Parser.Test {

    public class CharacterParserTest {

        [SetUp]
        public void Setup() {
            // empty
        }

        [Test]
        [TestCase(null, null, false)]
        [TestCase("My phone number is (949) 867-5309", "949 8675309", false)]
        [TestCase("I have 3 cars, 4 houses and 1 dog.", "3 4 1", false)]
        [TestCase("My phone number is (949) 867-5309", "9498675309", true)]
        [TestCase("I have 3 cars, 4 houses and 1 dog.", "341", true)]
        public void ReturnsNumbers_FromString(string validate, string validation, bool removeSpaces) {

            // act
            var validateResult = validate.ToNumbers(removeSpaces);

            // assert
            Assert.AreEqual(validation, validateResult);
            
        }

        [Test]
        [TestCase(null, null, false)]
        [TestCase("My phone number is (949) 867-5309", "My phone number is", false)]
        [TestCase("I have 3 cars, 4 houses and 1 dog.", "I have cars houses and dog", false)]
        [TestCase("My phone number is (949) 867-5309", "Myphonenumberis", true)]
        [TestCase("I have 3 cars, 4 houses and 1 dog.", "Ihavecarshousesanddog", true)]
        public void ReturnsLetters_FromString(string validate, string validation, bool removeSpaces) {

            // act
            var validateResult = validate.ToLetters(removeSpaces);

            // assert
            Assert.AreEqual(validation, validateResult);
            
        }

        [Test]
        [TestCase(null, null, false)]
        [TestCase("My phone number is (949) 867-5309", "My phone number is 949 8675309", false)]
        [TestCase("I have 3 cars, 4 houses and 1 dog.", "I have 3 cars 4 houses and 1 dog", false)]
        [TestCase("I'll head over to John's house at Apt #5", "Ill head over to Johns house at Apt 5", false)]
        [TestCase("My phone number is (949) 867-5309", "Myphonenumberis9498675309", true)]
        [TestCase("I have 3 cars, 4 houses and 1 dog.", "Ihave3cars4housesand1dog", true)]
        public void ReturnsLettersAndNumbers_FromString(string validate, string validation, bool removeSpaces) {

            // act
            var validateResult = validate.ToLettersAndNumbers(removeSpaces);

            // assert
            Assert.AreEqual(validation, validateResult);
            
        }

    }

}