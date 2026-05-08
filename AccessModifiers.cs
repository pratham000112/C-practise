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