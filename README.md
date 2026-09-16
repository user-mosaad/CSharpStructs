# C# Structs
Structs are value types, so they are stored on the stack. 

Structs can have the same members as classes: fields, properties, constructors, methods.

## Readonly Structs
Structs that are readonly have properties that can't be modified after initialised. And no methods inside the struct can modify those properties either. Much like a <code>{ get; init; }</code>, if not, it is that.
