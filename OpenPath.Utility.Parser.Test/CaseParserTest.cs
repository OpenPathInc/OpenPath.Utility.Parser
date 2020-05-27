using NUnit.Framework;

namespace OpenPath.Utility.Parser.Test {

    public class CaseParserTest {

        [SetUp]
        public void Setup() {
            // empty
        }

        [Test]
        [TestCase(null, null, false, "en-US")]
        [TestCase("should title case everything", "Should Title Case Everything", false, "en-US")]
        [TestCase("Should title  case Everything with   Extra spaces", "Should Title  Case Everything With   Extra Spaces", false, "en-US")]
        [TestCase("Should title  case Everything without   Extra spaces", "Should Title Case Everything Without Extra Spaces", true, "en-US")]
        public void ReturnsTextAsTitleCase_FromString(string validate, string validation, bool removeWhitespace, string culture) {

            // act
            var validateResult = validate.ToTitleCase(removeWhitespace, culture);

            // assert
            Assert.AreEqual(validation, validateResult);
            
        }

        [Test]
        [TestCase(null, null, false, "en-US")]
        [TestCase("should title case everything", "Should Title Case Everything", false, "en-US")]
        [TestCase("should title everthing and not", "Should Title Everthing and Not", false, "en-US")]
        public void ReturnsTextAsProperTitleCase_FromString(string validate, string validation, bool removeWhitespace, string culture) {

            // act
            var validateResult = validate.ToProperTitleCase(removeWhitespace, culture);

            // assert
            Assert.AreEqual(validation, validateResult);
            
        }

    }

}