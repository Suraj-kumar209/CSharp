using System;
class TypesDemo
    {
        static int x;
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Fied x value is :"+ x+" x data type is: "+ x.GetType());

            int y = 10;
            Console.WriteLine("Field y value is: "+y
                +" data type of y is: "+y.GetType());
            float f = 3.14f;
            Console.WriteLine("Field f value is: "+f+
                " data type of f is: "+f.GetType());
            double d = 3.14;
            Console.WriteLine("Field d value is: "+d+
                " Data type of d is: "+d.GetType());
            decimal dec = 3.14m;
            Console.WriteLine("Field dec value is: "+dec+
                dec.GetType());
            bool b = true;
            Console.WriteLine("Field b value is: "+b+
                " data type of b is: "+b.GetType());
            char ch = 'A';
            Console.WriteLine("Field ch value is: "+ch+
                " data type of ch is: "+ch.GetType());
            Console.ReadLine();





        }
    }