# EDMXParsingSample
This sample project demonstrates issues with the EF 6.3 EdmItemCollection on .NET Core 3. Please see https://github.com/aspnet/EntityFramework6/issues/1230 for more information and discussion.

## Project Contents
- `EntityModel.edmx`: A sample EDMX file containing a fictitious object model that demonstrates some standardized entity patterns.
- `EdmxLoader.cs`: Uses an `XElement` to grab the CSDL from an EDMX file, and parse it into an `EdmItemCollection` so that the metadata can be used for code generation.
- `Parser.csx`: A simple [dotnet-script](https://github.com/filipw/dotnet-script) file that finds any EDMX files in the script folder and tries to parse them.
- `ScriptHelpers.csx`: A helper file that grabs the location of the script folder from an outside calling method.
