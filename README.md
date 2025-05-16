# StudentValidation

This is a C# Windows Forms project that demonstrates how to perform **custom validation** on student input fields using **custom attributes** and **reflection**.

## Project Purpose

The purpose of this application is to validate user input dynamically by:
- Defining custom validation rules as attributes (e.g. [Required], [MaxLength])
- Using reflection to scan properties and apply validation
- Displaying validation messages to the user if any rule is violated

## 🔧 Technologies Used

- C# (.NET Framework)
- Windows Forms
- Reflection
- Custom Attributes
- Object-Oriented Programming

## How It Works

1. The user enters student information (e.g. Name, Surname, Number).
2. On form submission, each property is validated based on its custom attribute.
3. If any validation fails, a message is shown to the user.

### Example Attribute:

```csharp
[Required]
[MaxLength(10)]
public string Name { get; set; }
