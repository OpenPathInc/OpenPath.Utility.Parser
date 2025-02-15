﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

namespace OpenPath.Utility.Parser {
    
    /// <summary>
    /// The case parser does different casing options for strings. For example, it can title case,
    /// Pascal case and camel.
    /// </summary>
    public static class CaseParser {

        /// <summary>
        /// Converts a string to title case, captilizing every first word in string.
        /// </summary>
        /// <param name="value">The value of the string you want to convert to title case.</param>
        /// <param name="removeWhitespace">If true, will remove extra whitespace (Default: fault).</param>
        /// <param name="culture">Sets the local culture to base the conversion on (Default: "en-US", English).</param>
        /// <returns>The string converted to title case.</returns>
        public static string ToTitleCase(
            this string value,
            bool removeWhitespace = false,
            string culture = "en-US"
        ) {

            // validate
            if (value == null) return value;

            // set defult variables
            var textInfo = new CultureInfo(culture, false).TextInfo;

            // remove whitespace if specified
            if(removeWhitespace) {
                value = value.ReplaceWhitespace();
            }

            // convert to title case
            var result = textInfo.ToTitleCase(value.ToLower()); 

            return result;

        }

        /// <summary>
        /// Converts a string to title case, captilizing words over three characters and I.
        /// </summary>
        /// <param name="value">The value of the string you want to convert to title case.</param>
        /// <param name="removeWhitespace">If true, will remove extra whitespace (Default: fault).</param>
        /// <param name="culture">Sets the local culture to base the conversion on (Default: "en-US", English).</param>
        /// <returns>The string converted to title case.</returns>
        public static string ToProperTitleCase(
            this string value,
            bool removeWhitespace = false,
            string culture = "en-US"
        ) {

            // validate
            if (value == null) return value;

            // first title case
            var result = value.ToTitleCase(removeWhitespace, culture);

            // build a list of ending characters
            var endingCharacters = new List<string> {
                ".", ",", ";", "?", "!", ";", ")", "'", "\"", ":", ">", "}", "]", " "
            };

            // get all the words three letters or less
            var words = result
                .Split(
                    new char[] { },
                    StringSplitOptions.RemoveEmptyEntries
                )
                .Where(
                    w =>
                    w.Length <= 3 &&
                    w != "I"
                );

            // lower case the three letter words
            foreach(var word in words) {
                foreach(var endingCharacter in endingCharacters) {

                    // lower case the word if they start with a space and end with an ending character
                    result = result.Replace($" {word}{endingCharacter}", $" {word.ToLower()}{endingCharacter}");

                    // lower case the word if the string ends with this word
                    if(result.EndsWith($" {word}")) result = $"{result.Substring(0, (result.Length - word.Length))}{word.ToLower()}";

                }
            }


            

            // retrun result
            return result;

        }

        /// <summary>
        /// Converts a string to a valid Pascal Cased code representation.
        /// </summary>
        /// <param name="value">The string to convert to Pascal Case.</param>
        /// <returns>Returns string as Pascal Case.</returns>
        public static string ToPascalCase(this string value) {

            // validate
            if (value == null) return value;
            
            // cleanup whitespace
            var result = value.ReplaceWhitespace(" ", true);

            // if there are spaces title case the result
            if(result.Contains(" ")) { 

                result = result.ToTitleCase();

            }
            // if there are no spaces, capitize the first character
            else {

                if(result.Length >= 1) result = result.Substring(0, 1).ToUpper() + result.Substring(1);

            }

            // use only letters and numbers
            result = result.ToLettersAndNumbers(true);

            // return final results
            return result;

        }

        /// <summary>
        /// Converts a string to format like JSON keys.
        /// (Example: This is my text converts to this_is_my_text)
        /// </summary>
        /// <param name="value">A string</param>
        /// <returns>A Json cased string</returns>
        public static string ToJsonCase(this string value) {

            // validate
            if(value == null) return value;
            
            // convert value to jason type vaule
            var result = value
                .ToLettersAndNumbers()
                .ToTitleCase()
                .Replace(" ", "_")
                .ToLower();

            return result;

        }

        /// <summary>
        /// Converts a string to format like url links.
        /// (Example: This is my text converts to this-is-my-text)
        /// </summary>
        /// <param name="value">A string</param>
        /// <returns>A JSON cased string</returns>
        public static string ToUrlCase(this string value) {

            // validate
            if(value == null) return value;
            
            // convert value to jason type vaule
            var result = value
                .ToLettersAndNumbers()
                .ToTitleCase()
                .Replace(" ", "-")
                .ToLower();

            return result;

        }

        /// <summary>
        /// The first letter of each word in a compound word is capitalized, except for the first
        /// word.
        /// </summary>
        /// <param name="value">A string</param>
        /// <returns>A camel cased string</returns>
        public static string ToCamelCase(this string value)
        {
            // validate
            if (value == null || value.Length < 2) return value;

            // Split the string into words.
            var words = value.Split(
                new char[] { },
                StringSplitOptions.RemoveEmptyEntries);

            // Combine the words.
            string result = words[0].ToLower();
            for (int i = 1; i < words.Length; i++)
            {
                result +=
                    words[i].Substring(0, 1).ToUpper() +
                    words[i].Substring(1);
            }

            return result;
        }

        /// <summary>
        /// Converts a string with no spaces to a sentence styled case. For example: PascalCase
        /// would return Pascal case and javascript_notation would return Javascript notation.
        /// </summary>
        /// <param name="value">The string you want to sentence case.</param>
        /// <param name="acceptNamespaceCase">If set to true will replace '.' with spaces (Default: False).</param>
        /// <returns>A sentence cased string.</returns>
        public static string ToSentenceCase(this string value, bool acceptNamespaceCase = false) {

            // validate
            if(value == null) return value;

            // define variables
            var result = string.Empty;

            // remove whitespace
            result = value.ReplaceWhitespace(" ", true);

            // if accept namespace cased remove '.' characters
            if(acceptNamespaceCase) result = result.Replace(".", " ");

            // upper case the first character
            if(result.Length > 0) result = $"{result.Substring(0, 1).ToUpper()}{result.Substring(1)}";

            // add spaces via regular expressions
            result = Regex.Replace(result, "[a-z][A-Z]", m => $"{m.Value[0]} {char.ToLower(m.Value[1])}");

            // make sure the sentence starts with uppercase and the test is lower case
            if(result.Length > 0) result = $"{result.Substring(0, 1).ToUpper()}{result.Substring(1).ToLower()}";

            return result;

        }

    }

}
