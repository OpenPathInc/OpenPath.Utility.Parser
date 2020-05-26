using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenPath.Utility.Parser {
    
    /// <summary>
    /// The case parser does different casing options for strings. For example, it can title case,
    /// Pascal case and camel.
    /// </summary>
    public static class CaseParser {

        /// <summary>
        /// Converts a string to format like JSON keys.
        /// (Example: This is my text converts to this_is_my_text)
        /// </summary>
        /// <param name="value">A string</param>
        /// <returns>A Json cased string</returns>
        public static string ToJsonCase(this string value) {

            // validate
            if(value == null) return null;
            
            // convert value to jason type vaule
            var result = value
                .ToHuman()
                .Replace(" ", "_")
                .ToLower();

            return result;

        }

        public static string ToPascal(this string value)
        {
            // If there are 0 or 1 characters, just return the string.
            if (value == null) return value;
            if (value.Length < 2) return value.ToUpper();

            // Split the string into words.
            string[] words = value.Split(
                new char[] { },
                StringSplitOptions.RemoveEmptyEntries);

            // Combine the words.
            string result = "";
            foreach (string word in words)
            {
                result +=
                    word.Substring(0, 1).ToUpper() +
                    word.Substring(1);
            }

            return result;
        }

        public static string ToCamel(this string value)
        {
            // validate
            if (value == null || value.Length < 2) return value;

            // Split the string into words.
            string[] words = value.Split(
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

        public static string ToHuman(this string text) {

            // validate
            if (text == null) return text;
            if (text.Length < 2) return text.ToUpper();

            // clean whitespace and other characters
            text = text
                .RemoveWhitespace()
                .Replace("--", "-");

            // set pre-conditions
            var dontSkip = true;
            var spaceCharacters = new char[] { '-', '.', '_', ':' };

            // start with the first character.
            var result = text.Substring(0, 1).ToUpper();

            // Add the remaining characters.
            for (int i = 1; i < text.Length; i++) {
                if (dontSkip) { 
                    if (char.IsUpper(text[i])) result += " " + text[i];
                    else if (spaceCharacters.Contains(text[i])) { result += " " + text[i + 1].ToString().ToUpper(); dontSkip = false; }
                    else result += text[i];
                }
                else {
                    dontSkip = true;
                }
            }

            return result.RemoveWhitespace();
        }




    }
}
