# IegTools.SemanticTypes

IegTools.SemanticTypes is a library that provides a minimalistic set of base classes and some implementations 
 of types that can be used to describe the semantics of a value.


## Why?
I need this for some other open sourced NuGet packages and internal projects.
Feel free to take a look at the source code and use it in your projects.  

The focus was on simplicity of the base classes.
I tried to keep the code as simple as possible to avoid unnecessary confusion.

## What's included at the moment?
- base class SemanticType
- base class NumericSemanticType
- GrossPrice
- NetPrice
- Vat
- Percentage
- Percentage0to100

## UnitTests
It's pretty good unittested.  
You can find the tests in the UnitTests.SemanticTypes project.