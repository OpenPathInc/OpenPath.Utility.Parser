using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenPath.Utility.Parser {

    /// <summary>
    /// The CharacterParser contains extension methods for manipluating the characters in a string,
    /// such as removing all numbers or letters or punctuation from a string.
    /// </summary>
    public static class CharacterParser {

        /// <summary>
        /// Removes all puctuation and numbers from a string.
        /// </summary>
        /// <param name="value">String to remove numbers and puctuation from.</param>
        /// <param name="removeSpaces">Remove whitespace from result.</param>
        /// <returns>Returns letters only.</returns>
        public static string ToLetters(this string value, bool removeSpaces = false) {

            // validate
            if(value == null) return value;

            // define the string builder
            var stringBuilder = new StringBuilder();

            // add only if the character is no a punctuation
            foreach (var character in value) {

               if (
                    (char.IsWhiteSpace(character) && !removeSpaces) ||
                    char.IsLetter(character)
               ) {
                    stringBuilder.Append(character);
               }

            }

            // return the results
            return stringBuilder.ToString().ReplaceWhitespace(" ");

        }

        /// <summary>
        /// Removes all puctuation and letters from a string.
        /// </summary>
        /// <param name="value">String to remove letters and puctuation from.</param>
        /// /// <param name="removeSpaces">Remove whitespace from result.</param>
        /// <returns>Returns numbers only.</returns>
        public static string ToNumbers(this string value, bool removeSpaces = false) {

            // validate
            if(value == null) return value;

            // define the string builder
            var stringBuilder = new StringBuilder();

            // add only if the character is no a punctuation
            foreach (var character in value) {

               if (
                    (char.IsWhiteSpace(character) && !removeSpaces) ||
                    char.IsNumber(character)
               ) {
                    stringBuilder.Append(character);
               }

            }

            // return the results
            return stringBuilder.ToString().ReplaceWhitespace(" ");

        }

        /// <summary>
        /// Removes all puctuation from a string.
        /// </summary>
        /// <param name="value">String to puctuation from.</param>
        /// <param name="removeSpaces">Remove whitespace from result.</param>
        /// <returns>Returns letters numbers only.</returns>
        public static string ToLettersAndNumbers(this string value, bool removeSpaces = false) {

            // validate
            if(value == null) return value;

            // define the string builder
            var stringBuilder = new StringBuilder();

            // add only if the character is no a punctuation
            foreach (var character in value) {

               if (!char.IsPunctuation(character)) stringBuilder.Append(character);

            }

            var result = stringBuilder
                .ToString();

            // remove whitepsaces
            if(removeSpaces) result = result.RemoveWhitespace();

            // return the results
            return result;

        }

    }

}
