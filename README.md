# Tutorial

This repository contains a .NET console application with a series of C# practice problems.

## Project structure

- `Program.cs` - application entry point and problem runner
- `Problem/Problem-1.cs` through `Problem-18.cs` - individual problem implementations
- `Tutorial.cs`,  - helper or additional sample files
- `Tutorial.csproj` - project file for the .NET application

## How to run

1. Open the solution in Visual Studio or any .NET-compatible editor.
2. Build the project targeting `net6.0`.
3. Run the application.
4. In `Program.cs`, uncomment the desired problem method call in `Main` to execute that problem.

## Notes

- The project is configured for .NET 6.0.
- The application currently uses a single console entry point to invoke selected problem methods.
- To add new problems, create a new `.cs` file and call its method from `Program.Main`.
