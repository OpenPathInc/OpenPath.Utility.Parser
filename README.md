<a name='assembly'></a>
# OP-ParserUtility

## Contents

- [CaseParser](#T-OpenPath-Utility-Parser-CaseParser 'OpenPath.Utility.Parser.CaseParser')
  - [ToCamelCase(value)](#M-OpenPath-Utility-Parser-CaseParser-ToCamelCase-System-String- 'OpenPath.Utility.Parser.CaseParser.ToCamelCase(System.String)')
  - [ToJsonCase(value)](#M-OpenPath-Utility-Parser-CaseParser-ToJsonCase-System-String- 'OpenPath.Utility.Parser.CaseParser.ToJsonCase(System.String)')
  - [ToPascalCase(value)](#M-OpenPath-Utility-Parser-CaseParser-ToPascalCase-System-String- 'OpenPath.Utility.Parser.CaseParser.ToPascalCase(System.String)')
  - [ToProperTitleCase(value,removeWhitespace,culture)](#M-OpenPath-Utility-Parser-CaseParser-ToProperTitleCase-System-String,System-Boolean,System-String- 'OpenPath.Utility.Parser.CaseParser.ToProperTitleCase(System.String,System.Boolean,System.String)')
  - [ToSentenceCase(value,acceptNamespaceCase)](#M-OpenPath-Utility-Parser-CaseParser-ToSentenceCase-System-String,System-Boolean- 'OpenPath.Utility.Parser.CaseParser.ToSentenceCase(System.String,System.Boolean)')
  - [ToTitleCase(value,removeWhitespace,culture)](#M-OpenPath-Utility-Parser-CaseParser-ToTitleCase-System-String,System-Boolean,System-String- 'OpenPath.Utility.Parser.CaseParser.ToTitleCase(System.String,System.Boolean,System.String)')
  - [ToUrlCase(value)](#M-OpenPath-Utility-Parser-CaseParser-ToUrlCase-System-String- 'OpenPath.Utility.Parser.CaseParser.ToUrlCase(System.String)')
- [CharacterParser](#T-OpenPath-Utility-Parser-CharacterParser 'OpenPath.Utility.Parser.CharacterParser')
  - [ToLetters(value,removeSpaces)](#M-OpenPath-Utility-Parser-CharacterParser-ToLetters-System-String,System-Boolean- 'OpenPath.Utility.Parser.CharacterParser.ToLetters(System.String,System.Boolean)')
  - [ToLettersAndNumbers(value,removeSpaces)](#M-OpenPath-Utility-Parser-CharacterParser-ToLettersAndNumbers-System-String,System-Boolean- 'OpenPath.Utility.Parser.CharacterParser.ToLettersAndNumbers(System.String,System.Boolean)')
  - [ToNumbers(value,removeSpaces)](#M-OpenPath-Utility-Parser-CharacterParser-ToNumbers-System-String,System-Boolean- 'OpenPath.Utility.Parser.CharacterParser.ToNumbers(System.String,System.Boolean)')
- [WhitespaceParser](#T-OpenPath-Utility-Parser-WhitespaceParser 'OpenPath.Utility.Parser.WhitespaceParser')
  - [RemoveWhitespace(value,includeSpaceRepresentations)](#M-OpenPath-Utility-Parser-WhitespaceParser-RemoveWhitespace-System-String,System-Boolean- 'OpenPath.Utility.Parser.WhitespaceParser.RemoveWhitespace(System.String,System.Boolean)')
  - [ReplaceWhitespace(value,replacementValue,includeSpaceRepresentations)](#M-OpenPath-Utility-Parser-WhitespaceParser-ReplaceWhitespace-System-String,System-String,System-Boolean- 'OpenPath.Utility.Parser.WhitespaceParser.ReplaceWhitespace(System.String,System.String,System.Boolean)')

<a name='T-OpenPath-Utility-Parser-CaseParser'></a>
## CaseParser `type`

##### Namespace

OpenPath.Utility.Parser

##### Summary

The case parser does different casing options for strings. For example, it can title case,
Pascal case and camel.

<a name='M-OpenPath-Utility-Parser-CaseParser-ToCamelCase-System-String-'></a>
### ToCamelCase(value) `method`

##### Summary

The first letter of each word in a compound word is capitalized, except for the first
word.

##### Returns

A camel cased string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A string |

<a name='M-OpenPath-Utility-Parser-CaseParser-ToJsonCase-System-String-'></a>
### ToJsonCase(value) `method`

##### Summary

Converts a string to format like JSON keys.
(Example: This is my text converts to this_is_my_text)

##### Returns

A Json cased string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A string |

<a name='M-OpenPath-Utility-Parser-CaseParser-ToPascalCase-System-String-'></a>
### ToPascalCase(value) `method`

##### Summary

Converts a string to a valid Pascal Cased code representation.

##### Returns

Returns string as Pascal Case.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to convert to Pascal Case. |

<a name='M-OpenPath-Utility-Parser-CaseParser-ToProperTitleCase-System-String,System-Boolean,System-String-'></a>
### ToProperTitleCase(value,removeWhitespace,culture) `method`

##### Summary

Converts a string to title case, captilizing words over three characters and I.

##### Returns

The string converted to title case.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value of the string you want to convert to title case. |
| removeWhitespace | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, will remove extra whitespace (Default: fault). |
| culture | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Sets the local culture to base the conversion on (Default: "en-US", English). |

<a name='M-OpenPath-Utility-Parser-CaseParser-ToSentenceCase-System-String,System-Boolean-'></a>
### ToSentenceCase(value,acceptNamespaceCase) `method`

##### Summary

Converts a string with no spaces to a sentence styled case. For example: PascalCase
would return Pascal case and javascript_notation would return Javascript notation.

##### Returns

A sentence cased string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string you want to sentence case. |
| acceptNamespaceCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If set to true will replace '.' with spaces (Default: False). |

<a name='M-OpenPath-Utility-Parser-CaseParser-ToTitleCase-System-String,System-Boolean,System-String-'></a>
### ToTitleCase(value,removeWhitespace,culture) `method`

##### Summary

Converts a string to title case, captilizing every first word in string.

##### Returns

The string converted to title case.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value of the string you want to convert to title case. |
| removeWhitespace | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, will remove extra whitespace (Default: fault). |
| culture | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Sets the local culture to base the conversion on (Default: "en-US", English). |

<a name='M-OpenPath-Utility-Parser-CaseParser-ToUrlCase-System-String-'></a>
### ToUrlCase(value) `method`

##### Summary

Converts a string to format like url links.
(Example: This is my text converts to this-is-my-text)

##### Returns

A JSON cased string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A string |

<a name='T-OpenPath-Utility-Parser-CharacterParser'></a>
## CharacterParser `type`

##### Namespace

OpenPath.Utility.Parser

##### Summary

The CharacterParser contains extension methods for manipluating the characters in a string,
such as removing all numbers or letters or punctuation from a string.

<a name='M-OpenPath-Utility-Parser-CharacterParser-ToLetters-System-String,System-Boolean-'></a>
### ToLetters(value,removeSpaces) `method`

##### Summary

Removes all puctuation and numbers from a string.

##### Returns

Returns letters only.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String to remove numbers and puctuation from. |
| removeSpaces | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Remove whitespace from result. |

<a name='M-OpenPath-Utility-Parser-CharacterParser-ToLettersAndNumbers-System-String,System-Boolean-'></a>
### ToLettersAndNumbers(value,removeSpaces) `method`

##### Summary

Removes all puctuation from a string.

##### Returns

Returns letters numbers only.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String to puctuation from. |
| removeSpaces | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Remove whitespace from result. |

<a name='M-OpenPath-Utility-Parser-CharacterParser-ToNumbers-System-String,System-Boolean-'></a>
### ToNumbers(value,removeSpaces) `method`

##### Summary

Removes all puctuation and letters from a string.

##### Returns

Returns numbers only.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String to remove letters and puctuation from. |
| removeSpaces | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Remove whitespace from result. |

<a name='T-OpenPath-Utility-Parser-WhitespaceParser'></a>
## WhitespaceParser `type`

##### Namespace

OpenPath.Utility.Parser

##### Summary

Extension methods for parsing whitespace from text.

<a name='M-OpenPath-Utility-Parser-WhitespaceParser-RemoveWhitespace-System-String,System-Boolean-'></a>
### RemoveWhitespace(value,includeSpaceRepresentations) `method`

##### Summary

Removes all types of whitespace in a string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string you want to remove whitespace from. |
| includeSpaceRepresentations | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Include representations like '-' and '_' (Default: false). |

<a name='M-OpenPath-Utility-Parser-WhitespaceParser-ReplaceWhitespace-System-String,System-String,System-Boolean-'></a>
### ReplaceWhitespace(value,replacementValue,includeSpaceRepresentations) `method`

##### Summary

Replaces all types of whitespace in a string and replaces them with a replacement value.

##### Returns

A string with no whitespace.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string you want to remove and replace whitespace from. |
| replacementValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value you want to replace the whitespace with (Default: " "). |
| includeSpaceRepresentations | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Include representations like '-' and '_' (Default: false). |
