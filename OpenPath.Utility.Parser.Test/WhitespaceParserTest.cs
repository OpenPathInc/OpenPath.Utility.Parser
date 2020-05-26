using NUnit.Framework;

namespace OpenPath.Utility.Parser.Test {

    public class WhitespaceParserTest {

        [SetUp]
        public void Setup() {
            // empty
        }

        [Test]
        [TestCase(null, null, " ", false)]
        [TestCase("One space", "One space", " ", false)]
        [TestCase("Two  spaces", "Two spaces", " ", false)]
        [TestCase("Three   spaces", "Three spaces", " ", false)]
        [TestCase(" This is     all mixed  Up with    lots of Things  ", "This is all mixed Up with lots of Things"," ", false)]
        [TestCase("One-dash", "One dash", " ", true)]
        [TestCase("Two--dashes", "Two dashes", " ", true)]
        [TestCase("Three---dashes", "Three dashes", " ", true)]
        [TestCase("One_underscore", "One underscore", " ", true)]
        [TestCase("Two__underscores", "Two underscores", " ", true)]
        [TestCase("Three__underscores", "Three underscores", " ", true)]
        [TestCase("This  one--is_all     messed____up_- with-a-combination", "This one is all messed up with a combination", " ", true)]
        [TestCase("Replace  white-space   only ", "Replace white-space only", " ", false)]
        [TestCase(" Replace   whitespace with    dashes  ", "Replace-whitespace-with-dashes", "-", false)]
        public void ReturnsTextWitReplacedWhitespace_FromString(string validate, string validation, string replaceValue, bool includeRepresentations) {

            // act
            var validateResult = validate.ReplaceWhitespace(replaceValue, includeRepresentations);

            // assert
            Assert.AreEqual(validation, validateResult);
            
        }

        [Test]
        [TestCase(null, null, false)]
        [TestCase("One space", "Onespace", false)]
        [TestCase("Two  spaces", "Twospaces", false)]
        [TestCase("Three   spaces", "Threespaces", false)]
        [TestCase(" This is     all mixed  Up with    lots of Things  ", "ThisisallmixedUpwithlotsofThings",false)]
        [TestCase("One-dash", "Onedash", true)]
        [TestCase("Two--dashes", "Twodashes", true)]
        [TestCase("Three---dashes", "Threedashes", true)]
        [TestCase("One_underscore", "Oneunderscore", true)]
        [TestCase("Two__underscores", "Twounderscores", true)]
        [TestCase("Three__underscores", "Threeunderscores", true)]
        [TestCase("This  one--is_all     messed____up_- with-a-combination", "Thisoneisallmessedupwithacombination", true)]
        [TestCase("Replace  white-space   only ", "Replacewhite-spaceonly", false)]
        public void ReturnsTextWitRemovedWhitespace_FromString(string validate, string validation, bool includeRepresentations) {

            // act
            var validateResult = validate.RemoveWhitespace(includeRepresentations);

            // assert
            Assert.AreEqual(validation, validateResult);
            
        }

    }

}