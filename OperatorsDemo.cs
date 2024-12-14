using System;

class OperatorsDemo{

static void Main(){
Console.WriteLine(sizeof(double));
Console.WriteLine(typeof(double));

double d= 34.56;
object obj1=d;
if(obj1 is double){
Console.WriteLine("d id of type System.Double");
}
string str="Hello World";
object obj2=str;
Console.WriteLine(obj2.GetType());
string str1=(string)obj2;
string str3=obj2 as string;
Console.WriteLine(str3.GetType());
string str4=obj2.ToString();

Console.WriteLine(str4.GetType());
int i=100;
Console.WriteLine(i==100?"Ternairy operator true":"False");
string country1=null,country2=null;
Console.WriteLine(country1??country2);
country2="India";
Console.WriteLine(country1??country2);
country1="USA";
Console.WriteLine(country1??country2);
}}