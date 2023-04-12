# IegTools.SemanticTypes

IegTools.SemanticTypes is a library that offers a minimalist collection of SemanticTypes,
based on record(s) instead of classes.
The library is written in C# 11.0 and targets .NET Standard 2.0 (.NET Core and .NET Framework).


## Why?
I created this library for usage in other open-source NuGet packages and internal projects.
Please feel free to examine the source code and use it in your projects.  

The primary focus was to keep the base record(s) as simple as possible.


## What's included in the library?
The library includes the following components:
- `SemanticType` base record (handles comparison)
- `GrossPrice`
- `NetPrice`
- `Vat`
- `Percentage`
- `Percentage0to100`


## Unit Testing
The library has been thoroughly unit tested.
The tests are located in the project `UnitTests.SemanticTypes`.
