using System;

class VarDynamic{

static void Main(){
var i=100;
Console.WriteLine(i.GetType());
var c='A';
Console.WriteLine(c.GetType());
var f=45.67f;
Console.WriteLine(f.GetType());
var b=true;
Console.WriteLine(b.GetType());
var s="Hello";
Console.WriteLine(s.GetType());
Console.WriteLine("------------------------------------------>");

dynamic d;
d=200;
Console.WriteLine(f.GetType());
d='S';
Console.WriteLine(d.GetType());
d=34.56;
Console.WriteLine(d.GetType());
d=false;
Console.WriteLine(d.GetType());
d="hello";
Console.WriteLine(d.GetType());

}
}