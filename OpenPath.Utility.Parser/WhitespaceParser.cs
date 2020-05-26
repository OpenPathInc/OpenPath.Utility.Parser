using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace OpenPath.Utility.Parser {

    /// <summary>
    /// Extension methods for parsing whitespace from text.
    /// </summary>
    public static class WhitespaceParser {

        /// <summary>
        /// Replaces all types of whitespace in a string and replaces them with a replacement value.
        /// </summary>
        /// <param name="value">The string you want to remove and replace whitespace from.</param>
        /// <param name="replacementValue">The value you want to replace the whitespace with (Default: " ").</param>
        /// <param name="includeSpaceRepresentations">Include representations like '-' and '_' (Default: false).</param>
        /// <returns>A string with no whitespace.</returns>
        public static string ReplaceWhitespace(
            this string value,
            string replacementValue = " ",
            bool includeSpaceRepresentations = false
        ) {

            // validation
            if (value == null) return value;

            // replace representations
            if(includeSpaceRepresentations) {
                value = value
                    .Replace("-", " ")
                    .Replace("_", " ");
            }

            // trim and split string by whitespace
            var stringArray = value
                .Trim()
                .Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);

            // put it back together
            var result = string.Empty;
            foreach(var stringItem in stringArray) {
                result += $"{stringItem}{replacementValue}";
            }

            // trim space representations
            result = result.Trim();
            if(result.EndsWith(replacementValue) && replacementValue != string.Empty) result = result.Substring(0, result.Length -1);

            // return result
            return result;

        }

        /// <summary>
        /// Removes all types of whitespace in a string.
        /// </summary>
        /// <param name="value">The string you want to remove whitespace from.</param>
        /// <param name="includeSpaceRepresentations">Include representations like '-' and '_' (Default: false).</param>
        /// <returns></returns>
        public static string RemoveWhitespace(
            this string value,
            bool includeSpaceRepresentations = false
        ) {

            return value.ReplaceWhitespace(string.Empty, includeSpaceRepresentations);

        }

    }

}