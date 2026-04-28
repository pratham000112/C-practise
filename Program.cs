
// explicit  casting

//using System;


//double price = 99.99;

//int product = (int)price;

//Console.WriteLine(product);

//// conversing using convert classes

//string number = "123";

//int result = Convert.ToInt32(number);

//Console.WriteLine(result);




// Default Parameter.


//static void MyMethod(string country = "London")
//{
//    Console.WriteLine(country  +  " this is the  Most visited Country ");
//}

//    MyMethod("India");
//    MyMethod("USA");
//    MyMethod();
//    MyMethod("Japan");

// Method Overloading

 class Program
{
    static int add (int a, int b)
    {
        return a + b;
    }
    static int add (int a, int b, int c)
        {
        return a + b + c;
    }

    static double add  (double a , double b)
    {
        return a + b;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(add(10, 20));
       Console.WriteLine(add(10, 20, 30));
        Console.WriteLine(add(10.5, 20.5));
    }


}







    


