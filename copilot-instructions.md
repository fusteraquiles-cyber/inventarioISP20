# Copilot Instructions for InventarioISP20

## Project Overview

**InventarioISP20** is a Windows Forms desktop application built in C# (.NET 8) for inventory management. The application provides a GUI for managing articles, categories, locations, and loans within an ISP system.

### Technology Stack
- **Framework**: .NET 8.0 (Windows Forms)
- **Language**: C# 12
- **UI Component Library**: FontAwesome.Sharp (v6.6.0) for icon support
- **Build System**: MSBuild (.csproj)

## Build & Run

### Build the project
```bash
dotnet build Desktop/Desktop.csproj
```

### Run the application
```bash
dotnet run --project Desktop/Desktop.csproj
```

### Build for Release
```bash
dotnet build -c Release Desktop/Desktop.csproj
```

## Project Structure

The entire application resides in the `Desktop/` folder, which is the main project directory:

- **Program.cs** - Application entry point; initializes and launches `MenuPrincipalView`
- **MenuPrincipalView.\*** - Main menu/dashboard window (entry form)
- **ArticulosView.\*** - View for managing articles/products
- **CategoriasView.\*** - View for managing product categories  
- **UbicacionesWiew.\*** - View for managing storage locations (note: typo in class name is "Wiew")
- **PrestamosView.\*** - View for managing loans/borrowings
- **\*.resx files** - Designer-generated resource files for Windows Forms
- **\*.Designer.cs files** - Auto-generated UI component code (do not edit manually unless necessary)

Each view follows the pattern: 
- `ViewName.cs` - Business logic and event handlers
- `ViewName.Designer.cs` - GUI component initialization (auto-generated)
- `ViewName.resx` - Form resources and layout metadata

## Code Conventions

### Naming
- Classes end with "View" suffix (e.g., `ArticulosView`, `PrestamosView`)
- **Exception**: Existing typo in class name `UbicacionesWiew` (should be "View" but is "Wiew")
- Forms inherit from `Form` base class
- Use PascalCase for class names and public members
- Use camelCase for local variables and private members

### File Organization
- Each form has three associated files: `.cs` (logic), `.Designer.cs` (UI), `.resx` (resources)
- Auto-generated Designer files should rarely be edited manually—use Visual Studio Designer instead
- Keep business logic in `.cs` files, UI code in `.Designer.cs`

### Namespace
- All classes are in the `Desktop` namespace

### Using Statements
- Standard .NET usings are included (System, System.Windows.Forms, etc.)
- Use `using System.Windows.Forms;` for form components
- FontAwesome icons: `using FontAwesome.Sharp;`

## Building Custom Controls & Forms

When adding new forms:
1. Create a new class inheriting from `Form` with "View" suffix
2. Use Windows Forms Designer to create UI (generates Designer.cs automatically)
3. Write event handlers in the main `.cs` file
4. If adding icons, use `FontAwesome.Sharp.IconButton` or `IconMenuItem` for consistency

## Dependencies

Only one external package is currently used:
- **FontAwesome.Sharp 6.6.0** - For icon support in buttons and menu items

To add new NuGet packages:
```bash
dotnet add Desktop/Desktop.csproj package PackageName
```

## Common Tasks

### Add a new form/view
- In Visual Studio: Right-click project → Add → Windows Form
- Name it with "View" suffix (e.g., `InventoryView`)
- Visual Studio auto-generates the Designer and partial class

### Modify existing form UI
- Open `.resx` file in Visual Studio Designer
- Do NOT manually edit `.Designer.cs` files
- Changes made in Designer are auto-reflected in Designer.cs

### Run the project
```bash
dotnet run --project Desktop/Desktop.csproj
```

## Notes

- Application targets `net8.0-windows` platform (Windows-only)
- Implicit usings are enabled (`ImplicitUsings` = true in .csproj)
- Nullable reference types enabled
- Entry point is `MenuPrincipalView` form
- No database layer is currently visible; determine if data persistence needs to be added

# Mandatory instructions for Copilot
- Siempre habla en español.