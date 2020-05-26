<a name='assembly'></a>
# OpenPath.Utility.Parser

## Contents

- [CaseParser](#T-OpenPath-Utility-Parser-CaseParser 'OpenPath.Utility.Parser.CaseParser')
  - [ToJsonCase(value)](#M-OpenPath-Utility-Parser-CaseParser-ToJsonCase-System-String- 'OpenPath.Utility.Parser.CaseParser.ToJsonCase(System.String)')
  - [ToTitleCase(value,removeWhitespace,culture)](#M-OpenPath-Utility-Parser-CaseParser-ToTitleCase-System-String,System-Boolean,System-String- 'OpenPath.Utility.Parser.CaseParser.ToTitleCase(System.String,System.Boolean,System.String)')
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

<a name='M-OpenPath-Utility-Parser-CaseParser-ToTitleCase-System-String,System-Boolean,System-String-'></a>
### ToTitleCase(value,removeWhitespace,culture) `method`

##### Summary

Converts a string to title case.

##### Returns

The string converted to title case.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value of the string you want to convert to title case. |
| removeWhitespace | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, will remove extra whitespace (Default: fault). |
| culture | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Sets the local culture to base the conversion on (Default: "en-US", English). |

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
