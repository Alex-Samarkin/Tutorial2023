using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibrary1;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pathient person = new Pathient();
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.SNILS);

            Column column = new Column();
            Console.WriteLine(column.Head.Name);

            Console.ReadLine();
        }
    }
}
