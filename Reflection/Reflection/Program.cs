// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Reflection;
namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            String studentName = "John";

            // current type of studentName
            Type studentNameType = studentName.GetType();

            Console.WriteLine("Type is: " + studentNameType);

            //==================>
            Type t = typeof(Program);
            Console.WriteLine(t.Assembly);

            //==================>
            Type t1 = typeof(Enumerable);
           //Type class properties return info about enumerable Type 
            Console.WriteLine("Name : {0}", t1.Name);
            Console.WriteLine("Namespace : {0}", t1.Namespace);
            Console.WriteLine("Base Type : {0}", t1.BaseType);

            Type t2 = typeof(String);

            // the Type class properties return information about the String Type 
            Console.WriteLine("Name : {0}", t2.Name);
            Console.WriteLine("Namespace : {0}", t2.Namespace);
            Console.WriteLine("Base Type : {0}", t2.BaseType);
        }
    }
}
