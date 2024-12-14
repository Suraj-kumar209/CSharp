using System;

class IfDemo{
static void Main(){
Console.WriteLine("Enter 1st number: ");
double d1= double.Parse(Console.ReadLine());
Console.WriteLine("Enter 2nd number: ");
double d2= double.Parse(Console.ReadLine());

if(d1>d2)
Console.WriteLine("1st high");
else if(d2>d1)
Console.WriteLine("2nd high");
else
Console.WriteLine("Both Same");
}}