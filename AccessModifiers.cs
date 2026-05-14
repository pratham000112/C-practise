using System;

class Newstudent
{
    public string name = "Harshita Sachdeva";

    public void showname()
    {
        Console.WriteLine(name);
    }


}

  class Program
 {
    static void Main()
    {
        Newstudent s = new Newstudent();

        Console.WriteLine(s.name);

        s.showname();
    }

}


// A private class can be `acceessed within the same class only An outside class cannnot accessable in it sometimes we have to do that we can acccisble withim the same class using the get and set method or not .


// in c# are properties  are used to read(get) and Write(Set) the value of a private fields only it is a bridge between private field and the outside code.


// inertience 
// in that the class that can be derived from  the parent class to the child class in it


// Example  that for the big project the inheritance is used in that if i have to make the login for the User i can make  it using the Inheritence

