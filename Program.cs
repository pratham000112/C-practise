
// explicit  casting

using System;


double price = 99.99;

int product = (int)price;

Console.WriteLine(product);

// conversing using convert classes

string number = "123";

int result = Convert.ToInt32(number);

Console.WriteLine(result);




// Default Parameter.


static void MyMethod(string country = "London")
{
    Console.WriteLine(country +  "this is the  Most visited Country");
}

    MyMethod("India");
    MyMethod("USA");
    MyMethod();
    MyMethod("Japan");







    


