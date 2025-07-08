# Sample C# Library

A sample C# library designed for testing release processes with comprehensive NuGet package metadata.

## Features

- **Calculator**: Basic mathematical operations (add, subtract, multiply, divide)
- **StringUtilities**: String manipulation utilities (reverse, word count, title case)
- Comprehensive XML documentation
- NuGet package ready with proper metadata
- Source Link support for debugging

## Installation

```bash
dotnet add package SampleLibrary
```

## Usage

### Calculator

```csharp
using SampleLibrary;

var calculator = new Calculator();
int sum = calculator.Add(5, 3);        // Returns 8
int difference = calculator.Subtract(10, 4);  // Returns 6
int product = calculator.Multiply(3, 7);      // Returns 21
double quotient = calculator.Divide(15.0, 3.0); // Returns 5.0
```

### String Utilities

```csharp
using SampleLibrary;

string reversed = StringUtilities.Reverse("hello");          // Returns "olleh"
int wordCount = StringUtilities.CountWords("hello world");   // Returns 2
string titleCase = StringUtilities.ToTitleCase("hello world"); // Returns "Hello World"
```

## Building

### Prerequisites

- .NET 8.0 SDK or later

### Build Commands

```bash
# Restore dependencies
dotnet restore

# Build the project
dotnet build

# Build in release mode
dotnet build -c Release

# Create NuGet package
dotnet pack

# Create NuGet package in release mode
dotnet pack -c Release
```

## NuGet Package Metadata

This project includes comprehensive NuGet package metadata:

- **Package ID**: SampleLibrary
- **Version**: 1.0.0
- **Description**: A sample C# library for testing release processes
- **License**: MIT
- **Source Link**: Enabled for debugging support
- **Symbol Packages**: Generated automatically (.snupkg)
- **Documentation**: XML documentation included

## Project Structure

```
sample-csharp-project/
├── Calculator.cs              # Basic calculator functionality
├── StringUtilities.cs         # String manipulation utilities
├── SampleLibrary.csproj      # Project file with NuGet metadata
├── SampleLibrary.sln         # Solution file
├── Directory.Build.props     # Global build properties
├── RELEASE_NOTES.md          # Release notes
└── README.md                 # This file
```

## Release Process

1. Update version in `SampleLibrary.csproj`
2. Update release notes in `RELEASE_NOTES.md`
3. Build and test: `dotnet build && dotnet test`
4. Create package: `dotnet pack -c Release`
5. Publish to NuGet: `dotnet nuget push bin/Release/SampleLibrary.*.nupkg --api-key YOUR_API_KEY --source https://api.nuget.org/v3/index.json`

## License

This project is licensed under the MIT License.