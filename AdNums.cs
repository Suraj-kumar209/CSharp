using System;
class AddNums{

static void Main(){
Console.Clear();
Console.WriteLine("Enter 1st Number:");
string s1=Console.ReadLine();
double d1=Convert.ToDouble(s1);
Console.WriteLine("Enter 2nd number");
//string s2=Console.ReadLine();
double d2=double.Parse(Console.ReadLine());

double d3=d1+d2;
Console.WriteLine("Sum of" +d1 +"&"+d2+"is: "+d3);
Console.WriteLine("Sum of {0}&{1} is:{2}",d1,d2,d3);
Console.WriteLine($"Sum of {d1}&{d2} is:{d3}");
}}