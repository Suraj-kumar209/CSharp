using System;
class SwitchDemo{
static void Main(){
Console.WriteLine("Enter Student Id. (1-3): ");
int Id=int.Parse(Console.ReadLine());
switch(Id){
case 1:
Console.WriteLine("Std1");
break;
case 2:
Console.WriteLine("std2");
break;
case 3:
Console.WriteLine("std3");
break;
default:
Console.WriteLine("No Id exists");
break;
}
}
}