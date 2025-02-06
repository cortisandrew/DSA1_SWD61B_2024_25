using Ref_vs_Value_Types;

// Value types
Console.WriteLine("Value types:");

int a = 5;
int b = 6;

Console.WriteLine($"The value of a = {a}");     // 5
Console.WriteLine($"The value of b = {b}");     // 6

// Assign a the value of b
a = b;

Console.WriteLine("a = b");
Console.WriteLine($"The value of a = {a}");     // 6
Console.WriteLine($"The value of b = {b}");     // 6

b = 10;
Console.WriteLine("b=10");
Console.WriteLine($"The value of a = {a}");     // 6
Console.WriteLine($"The value of b = {b}");     // 10

Console.WriteLine();
Console.WriteLine("Reference Types:");

ReferenceTypeData c = new ReferenceTypeData(5);     // 5
ReferenceTypeData d = new ReferenceTypeData(6);     // 6

Console.WriteLine($"The value of c = {c.InstanceValue}");   // 5
Console.WriteLine($"The value of d = {d.InstanceValue}");   // 6

c = d;

Console.WriteLine("c=d");
Console.WriteLine($"The value of c = {c.InstanceValue}");   // 6
Console.WriteLine($"The value of d = {d.InstanceValue}");   // 6

d.InstanceValue = 10;
Console.WriteLine("d=10");
Console.WriteLine($"The value of c = {c.InstanceValue}");   // 10
Console.WriteLine($"The value of d = {d.InstanceValue}");   // 10



