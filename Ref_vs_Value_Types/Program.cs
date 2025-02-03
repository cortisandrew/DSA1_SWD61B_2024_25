using Ref_vs_Value_Types;

// Value types
Console.WriteLine("Value types:");

int a = 5;
int b = 6;

Console.WriteLine($"The value of a = {a}");
Console.WriteLine($"The value of b = {b}");

// Assign a the value of b
a = b;

Console.WriteLine("a = b");
Console.WriteLine($"The value of a = {a}");
Console.WriteLine($"The value of b = {b}");

b = 10;
Console.WriteLine("b=10");
Console.WriteLine($"The value of a = {a}");
Console.WriteLine($"The value of b = {b}");

Console.WriteLine();
Console.WriteLine("Reference Types:");

ReferenceTypeData c = new ReferenceTypeData(5);
ReferenceTypeData d = new ReferenceTypeData(6);

Console.WriteLine($"The value of c = {c.InstanceValue}");
Console.WriteLine($"The value of d = {d.InstanceValue}");

c = d;

Console.WriteLine("c=d");
Console.WriteLine($"The value of c = {c.InstanceValue}");
Console.WriteLine($"The value of d = {d.InstanceValue}");

d.InstanceValue = 10;
Console.WriteLine("d=10");
Console.WriteLine($"The value of c = {c.InstanceValue}");
Console.WriteLine($"The value of d = {d.InstanceValue}");



