using NUnit.Framework;

namespace OpenPath.Utility.Parser.Test {

    public class CaseParserTest {

        [SetUp]
        public void Setup() {
            // empty
        }

        [Test]
        [TestCase(null, null, false, "en-US")]
        [TestCase("", "", false, "en-US")]
        [TestCase("a", "A", false, "en-US")]
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
        [TestCase("", "", false, "en-US")]
        [TestCase("a", "A", false, "en-US")]
        [TestCase("should title case everything", "Should Title Case Everything", false, "en-US")]
        [TestCase("should title everthing and not and", "Should Title Everthing and not and", false, "en-US")]
        [TestCase("i am going to the store!", "I am Going to the Store!", false, "en-US")]
        [TestCase("lOts OF craZy stuff here, let US see WHAT HAPPens!", "Lots of Crazy Stuff Here, let us see What Happens!", false, "en-US")]
        [TestCase("we    should maintain   spacing", "We    Should Maintain   Spacing", false, "en-US")]
        [TestCase("   what if there is spacing before and after?    ", "   What if There is Spacing Before and After?    ", false, "en-US")]
        [TestCase("Ok,  let's   trim out the       extra space!", "Ok, Let's Trim out the Extra Space!", true, "en-US")]
        public void ReturnsTextAsProperTitleCase_FromString(string validate, string validation, bool removeWhitespace, string culture) {

            // act
            var validateResult = validate.ToProperTitleCase(removeWhitespace, culture);

            // assert
            Assert.AreEqual(validation, validateResult);
            
        }

        [Test]
        [TestCase(null, null)]
        [TestCase("", "")]
        [TestCase("a", "A")]
        [TestCase("this is pascal case", "ThisIsPascalCase")]
        [TestCase("I WANT  this to-be PasCal CASEd!", "IWantThisToBePascalCased")]
        [TestCase("from_json_cased", "FromJsonCased")]
        [TestCase("from-html-cased", "FromHtmlCased")]
        [TestCase("from--azure--cased", "FromAzureCased")]
        [TestCase("From.Namespace.Cased", "FromNamespaceCased")]
        [TestCase("fromCamelCased", "FromCamelCased")]
        [TestCase("  spacing in front with 2 spaces at the end  ", "SpacingInFrontWith2SpacesAtTheEnd")]
        [TestCase("Let's do this!", "LetsDoThis")]
        public void ReturnsTextAsPascalCase_FromString(string validate, string validation) {

            // act
            var validateResult = validate.ToPascalCase();

            // assert
            Assert.AreEqual(validation, validateResult);
            
        }

        [Test]
        [TestCase(null, null, false)]
        [TestCase("", "", false)]
        [TestCase("a", "A", false)]
        [TestCase("This is sentence cased", "This is sentence cased", false)]
        [TestCase("this is Mixed cased", "This is mixed cased", false)]
        [TestCase("This has    extra  spaces  ", "This has extra spaces", false)]
        [TestCase("ThisIsPascalCase", "This is pascal case", false)]
        [TestCase("thisIsCamelCase", "This is camel case", false)]
        [TestCase("this_is_json_cased", "This is json cased", false)]
        [TestCase("this-is-html-cased", "This is html cased", false)]
        [TestCase("this--is--azure--cased", "This is azure cased", false)]
        [TestCase("This.Is.Namespace.Cased", "This.is.namespace.cased", false)]
        [TestCase("This.Is.Namespace.Cased", "This is namespace cased", true)]
        public void ReturnsTextAsSentenceCase_FromString(string validate, string validation, bool acceptNamespaceCase) {

            // act
            var validateResult = validate.ToSentenceCase(acceptNamespaceCase);

            // assert
            Assert.AreEqual(validation, validateResult);
            
        }

    }

}