using System;
using System.Collections.Generic;
using System.Text;

namespace OpenPath.Utility.Parser {

    /// <summary>
    /// Extension methods for parsing whitespace from text.
    /// </summary>
    public static class WhitespaceParser {

        /// <summary>
        /// Removes as types of whitespace in a string.
        /// </summary>
        /// <param name="text">The string you want to remove whitespace from.</param>
        /// <param name="includeSpaceRepresentations">Include representations like '-' and '_'.</param>
        /// <returns>A string with no whitespace.</returns>
        public static string RemoveWhitespace(
            this string text,
            bool includeSpaceRepresentations = false
        ) {

            // define base values
            var length = text.Length;
            var index = 0;
            var currentIndex = 0;
            var result = text.ToCharArray();
            var skip = false;
            var character = ' ';
            var whiteSpaceCharacters = new List<char> {
                '\u0020', '\u00A0', '\u1680', '\u2000', '\u2001', '\u2002', '\u2003',
                '\u2004', '\u2005', '\u2006', '\u2007', '\u2008', '\u2009', '\u200A',
                '\u202F', '\u205F', '\u3000', '\u2028', '\u2029', '\u0009', '\u000A',
                '\u000B', '\u000C', '\u000D', '\u0085'
            };

            // if include space representations is true add those characters too
            if(includeSpaceRepresentations) {
                whiteSpaceCharacters.AddRange(
                    new List<char> {
                        '-', '_'
                    }
                );
            }

            for (; currentIndex < length; currentIndex++) {

                character = result[currentIndex];

                if(whiteSpaceCharacters.Contains(character) && !skip) {
                    result[index++] = character;
                    skip = true;
                }
                else {
                    skip = false;
                    result[index++] = character;
                }

            }

            return new string(result, 0, index);

        }

    }

}