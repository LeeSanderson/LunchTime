This project is .NET 9 and uses C# 13.

Make sure all code generated is inside of the LunchTimeMCP project, which may be a subfolder inside of the main folder.

It is on GitHub at https://github.com/LeeSanderson/LunchTime

## Project Context
This is a console application that exposes restaurant data as an MCP server.

## C# Coding Standards
- Use PascalCase for class names, method names, and properties
- Use camelCase for local variables and parameters
- Use descriptive names that clearly indicate purpose
- Don't add XML documentation comments for public methods and classes
- Use `var` for local variables when the type is obvious
- Prefer explicit types when it improves readability
- Use async/await for asynchronous operations
- Follow the repository pattern for data access
- Use proper exception handling with try-catch blocks
- Implement IDisposable when managing resources
- Use nullable reference types to avoid null reference exceptions
- use file-scoped namespaces for cleaner code organization

## Naming Conventions
- Classes: `RestaurantHelper`, `Restaurant`, `Program`
- Methods: `GetRestaurants()`, `GetRandomRestaurant()`, `GetRestaurantByName()`
- Properties: `Name`, `Location`, `FoodType`
- Variables: `selectedRestaurant`, `restaurantCount`, `userInput`
- Constants: `MAX_RESTAURANTS`, `DEFAULT_FOOD_TYPE`

## Architecture
- Console application with interactive menu
- Static helper class for data management
- Model classes for data representation
- Separation of concerns between UI and business logic