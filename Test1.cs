using System;
class Test
{
public static void squareRef( ref int val)
{ val *= val;}
public static void squareVal(int val)
{ val *= val;}
public static void Main()
{
int arg;
arg =4;
squareRef(ref arg);
Console.WriteLine(arg);	
squareVal(arg);
Console.WriteLine(arg);
squareVal(arg);
Console.WriteLine(arg);
squareVal(arg);
Console.WriteLine(arg);
squareRef(ref arg);
Console.WriteLine(arg);	

}
}
