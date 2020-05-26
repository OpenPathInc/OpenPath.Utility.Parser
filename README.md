<a name='assembly'></a>
# OpenPath.Utility.Parser

## Contents

- [CaseParser](#T-OpenPath-Utility-Parser-CaseParser 'OpenPath.Utility.Parser.CaseParser')
  - [ToJsonCase(value)](#M-OpenPath-Utility-Parser-CaseParser-ToJsonCase-System-String- 'OpenPath.Utility.Parser.CaseParser.ToJsonCase(System.String)')
- [WhitespaceParser](#T-OpenPath-Utility-Parser-WhitespaceParser 'OpenPath.Utility.Parser.WhitespaceParser')
  - [RemoveWhitespace(text,includeSpaceRepresentations)](#M-OpenPath-Utility-Parser-WhitespaceParser-RemoveWhitespace-System-String,System-Boolean- 'OpenPath.Utility.Parser.WhitespaceParser.RemoveWhitespace(System.String,System.Boolean)')

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

<a name='T-OpenPath-Utility-Parser-WhitespaceParser'></a>
## WhitespaceParser `type`

##### Namespace

OpenPath.Utility.Parser

##### Summary

Extension methods for parsing whitespace from text.

<a name='M-OpenPath-Utility-Parser-WhitespaceParser-RemoveWhitespace-System-String,System-Boolean-'></a>
### RemoveWhitespace(text,includeSpaceRepresentations) `method`

##### Summary

Removes as types of whitespace in a string.

##### Returns

A string with no whitespace.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string you want to remove whitespace from. |
| includeSpaceRepresentations | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Include representations like '-' and '_'. |
