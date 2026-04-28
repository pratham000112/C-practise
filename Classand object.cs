using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography;


//class Car
//{
//    public String color = "Black";

//    public void drive()
//    {
//        Console.WriteLine("Car is driving");
//    }


//    class Program
//    {
//        static void Main()
//        {
//            Car mycar = new Car();
//            Console.WriteLine(mycar.color);
//            mycar.drive();

//        }
//    }
//}



class  Student
{
    public string Name;
    public int  Age;


    public void Display()
    {
        Console.WriteLine("Name : " + Name + ", Age " + Age);

    }

}

class Program
{
    static void Main()
    {
        Student s1 = new Student();
        s1.Name = "Harshita Sachdeva";
        s1.Age = 20;

        Student s2 = new Student();
        s2.Name = "Pulkit virmani";
        s2.Age = 21;


        Student s3 = new Student();
        s3.Name = "kritika Sethi";
              s3.Age = 28;

        s1.Display();
        s2.Display();
        s3.Display();
    }


      
}


