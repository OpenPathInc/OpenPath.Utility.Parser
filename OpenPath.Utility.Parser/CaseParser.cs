using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

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
                .ToTitleCase()
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

        /// <summary>
        /// Converts a string to title case.
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




    }
}
