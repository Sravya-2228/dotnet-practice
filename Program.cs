using System;
namespace two;
public class two()
{
    public static void Main(string[] args)
    {
        //revsersal of name
        //string name = "John K";
        //string outp = new string(name.Reverse().ToArray());
        //Console.WriteLine(outp);
        //exec problem
        string fullname = "Sravya Sunkara Yadav";

        string[] splitname = fullname.Split(' ');
        Array.Reverse(splitname);
        string revname = string.Join(" ", splitname);
        Console.WriteLine(revname);



    }

}
