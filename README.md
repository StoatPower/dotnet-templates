# dotnet-templates

Templates for creating .NET Core items and projects. Many are based on various principles and patterns in Domain Driven Design (DDD), including Event Sourcing (ES), Command/Query Responsibility Segregation (CQRS), Repository patterns, and more.

https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates

https://devblogs.microsoft.com/dotnet/how-to-create-your-own-templates-for-dotnet-new/

1. Add a `.template.config` folder at the root of the project or code you want templated.
2. Add a `template.json` file in this folder.
3. Copy and modify the following code as needed
    ```
    {
        "$schema": "http://json.schemastore.org/template",
        "author": "Me",
        "classifications": [ "Common", "Console", "C#8" ],
        "identity": "ExampleTemplate.AsyncProject",
        "name": "Example templates: async project",
        "shortName": "consoleasync",
        "tags": {
            "language": "C#",
            "type": "project"
        }
    }
    ```
4. Install it by navigating to this folder and execute `dotnet new -i .\`
5. Uninstall it by first finding it with `dotnet new -u`
6. Then copy the path and run it with `dotnet new -u "path"`