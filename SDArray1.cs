using System;
class SDArray1{

static void Main(){
Console.Clear();
int x=0;
int[] arr=new int[6];

//Accessing value of array with for loop

for(int i=0;i<6;i++){
Console.Write(arr[i]+" ");
Console.WriteLine();
}

//Assigning values to array with for loop
for(int i=0;i<6;i++){
x+=10;
arr[i]=x;
}

foreach(int a in arr){
Console.Write(a+" ");
//Console.WriteLine();
}}
}