# IegTools.SemanticTypes

IegTools.SemanticTypes is a library that offers a minimalist collection of base classes and some type-implementations, which can be used to describe the meaning of a value.


## Why?
I created this library for usage in other open-source NuGet packages and internal projects.
Please feel free to examine the source code and use it in your projects.  

The primary focus was to keep the base classes as simple as possible to prevent any unnecessary confusion.


## What's included in the library?
The library currently contains the following:
- `SemanticType` base class
- `NumericSemanticType` base class
- `GrossPrice`
- `NetPrice`
- `Vat`
- `Percentage`
- `Percentage0to100`


## Unit Testing
The library has been thoroughly unit tested. The tests are located in the `UnitTests.SemanticTypes` project.
