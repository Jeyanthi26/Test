using System;
class Parent
{
public Parent()
{}
public Parent(int x)
{
Console.WriteLine(x*x);
Console.WriteLine("Parent Cons");
}
}
class Child :Parent
{
public Child()
{}
public Child(int n):base(n)
{
Console.WriteLine("Child Param Cons");
}
public static void Main()
{
Child cobj = new Child();
Child cj1 = new Child(4);
}
}