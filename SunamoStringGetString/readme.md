### SunamoStringGetString

A lightweight .NET library for converting string collections into a single string.

#### Features

- `SHGetString.GetString` - Concatenates all strings in a list into a single string without any delimiter.
- `SHGetString.ListToString` - Converts a list of strings into a single string representation, joining elements with a specified delimiter (defaults to `Environment.NewLine`).

#### Usage

```csharp
using SunamoStringGetString;

var lines = new List<string> { "Hello", " ", "World" };
string result = SHGetString.GetString(lines);
// result: "Hello World"

string joined = SHGetString.ListToString(lines, ", ");
// joined: "Hello, , World"
```

Part of PlatformIndependentNuGetPackages:

- [nuget.org](https://www.nuget.org/profiles/sunamo)
- [github.org](https://github.com/sunamo/PlatformIndependentNuGetPackages)

Another links:

- [Developer site](https://sunamo.cz)

Request for new features / bug report / etc: [Mail](mailto:radek.jancik@sunamo.cz) or on GitHub

## Target Frameworks

**TargetFrameworks:** `net10.0;net9.0;net8.0`
