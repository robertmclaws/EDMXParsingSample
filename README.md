# EDMXParsingSample
This sample project demonstrates issues with the EF 6.3 EdmItemCollection on .NET Core 3. Please see https://github.com/aspnet/EntityFramework6/issues/1230 for more information and discussion.

## Project Contents:
- `src/EdmxParsingSample.Data/EntityModel.edmx`: A sample EDMX file containing a fictitious object model that demonstrates some standardized entity patterns.
- `src/EdmxParsingSample.Data/EdmxLoader.cs`: Uses an `XElement` to grab the CSDL from an EDMX file, and parse it into an `EdmItemCollection` so that the metadata can be used for code generation.
- `src/EdmxParsingSample.Data/Parser.csx`: A simple [dotnet-script](https://github.com/filipw/dotnet-script) file that finds any EDMX files in the script folder and tries to parse them.
- `src/EdmxParsingSample.Data/ScriptHelpers.csx`: A helper file that grabs the location of the script folder from an outside calling method.

## Instructions:
1) Pull the project down on a box that has .NET Core 3 Preview 9 and compile it.
2) From Powershell, run `dotnet tool install -g dotnet-script`.
3) From the src/EdmxParsingSample.Data folder, run `dotnet script parser.csx` from your Powershell window. You should get the exception mentioned in the GitHub Issue.
